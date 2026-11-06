using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Project_Sport_Room.TestRunner
{
    internal class Program
    {
        static async Task<int> Main(string[] args)
        {
            Console.WriteLine("================================================================================");
            Console.WriteLine("   SPORT ROOM MANAGEMENT SYSTEM - AUTOMATED QA TEST RUNNER");
            Console.WriteLine("   Standards: ISO/IEC/IEEE 29119 | Target: Isolated Relational SQLite");
            Console.WriteLine("================================================================================");

            var testClasses = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.Namespace != null && t.Namespace.StartsWith("Project_Sport_Room.TestRunner.Modules"))
                .ToList();

            var testCases = new List<(MethodInfo method, Type classType, TestCaseAttribute attr)>();

            foreach (var type in testClasses)
            {
                foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance))
                {
                    var attr = method.GetCustomAttribute<TestCaseAttribute>();
                    if (attr != null)
                    {
                        testCases.Add((method, type, attr));
                    }
                }
            }

            testCases = testCases.OrderBy(t => t.attr.TestId).ToList();
            Console.WriteLine($"Discovered {testCases.Count} automated test cases across {testClasses.Count} modules.\n");

            var results = new List<TestResult>();
            int passed = 0;
            int failed = 0;

            var globalWatch = Stopwatch.StartNew();

            foreach (var (method, classType, attr) in testCases)
            {
                var result = new TestResult
                {
                    TestId = attr.TestId,
                    Module = attr.Module,
                    Name = attr.Name,
                    Category = attr.Category
                };

                Console.Write($"[{attr.TestId}] {attr.Module} :: {attr.Name,-50} ... ");

                object? instance = Activator.CreateInstance(classType);
                var sw = Stopwatch.StartNew();

                try
                {
                    if (method.ReturnType == typeof(Task))
                    {
                        var task = (Task)method.Invoke(instance, null)!;
                        await task;
                    }
                    else
                    {
                        method.Invoke(instance, null);
                    }

                    sw.Stop();
                    result.DurationMs = sw.Elapsed.TotalMilliseconds;
                    result.Status = "PASS";
                    passed++;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"PASS ({result.DurationMs:F1}ms)");
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    sw.Stop();
                    result.DurationMs = sw.Elapsed.TotalMilliseconds;
                    result.Status = "FAIL";
                    failed++;

                    var actualEx = ex is TargetInvocationException tie && tie.InnerException != null ? tie.InnerException : ex;
                    if (actualEx is DbUpdateException dbEx && dbEx.InnerException != null)
                    {
                        actualEx = dbEx.InnerException;
                    }
                    result.ErrorMessage = $"{actualEx.GetType().Name}: {actualEx.Message}";
                    result.StackTrace = actualEx.StackTrace;

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"FAIL ({result.DurationMs:F1}ms)");
                    Console.WriteLine($"    -> {actualEx.GetType().Name}: {actualEx.Message}");
                    Console.ResetColor();
                }

                results.Add(result);
            }

            globalWatch.Stop();

            Console.WriteLine("\n================================================================================");
            Console.WriteLine($"EXECUTION SUMMARY: Total: {results.Count} | Passed: {passed} | Failed: {failed} | Time: {globalWatch.Elapsed.TotalSeconds:F2}s");
            Console.WriteLine("================================================================================");

            // Generate Markdown Test Results Report
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo? dir = new DirectoryInfo(baseDir);
            while (dir != null && !File.Exists(Path.Combine(dir.FullName, "Project Sport Room.sln")))
            {
                dir = dir.Parent;
            }
            string rootDir = dir != null ? dir.FullName : Path.GetFullPath(Path.Combine(baseDir, "..", "..", "..", "..", ".."));
            string qaFolder = Path.Combine(rootDir, "Documentation", "QA");
            if (!Directory.Exists(qaFolder)) Directory.CreateDirectory(qaFolder);

            string initialReportPath = Path.Combine(qaFolder, "03_INITIAL_TEST_RESULTS.md");
            WriteMarkdownReport(initialReportPath, results, globalWatch.Elapsed.TotalSeconds);
            Console.WriteLine($"Saved Markdown Test Results: {initialReportPath}");

            // Generate TRX File
            string trxPath = Path.Combine(qaFolder, "QA-Results.trx");
            WriteTrxReport(trxPath, results, globalWatch.Elapsed);
            Console.WriteLine($"Saved TRX Test Report: {trxPath}");

            return failed > 0 ? 1 : 0;
        }

        private static void WriteMarkdownReport(string filePath, List<TestResult> results, double totalSeconds)
        {
            var sb = new StringBuilder();
            sb.AppendLine("# Automated QA Initial Test Execution Results");
            sb.AppendLine();
            sb.AppendLine($"**Execution Timestamp:** {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine($"**Environment:** Windows .NET 8.0 Windows | SQLite Relational Engine");
            sb.AppendLine($"**Total Tests Executed:** {results.Count}");
            sb.AppendLine($"**Passed:** {results.Count(r => r.Status == "PASS")}");
            sb.AppendLine($"**Failed:** {results.Count(r => r.Status == "FAIL")}");
            sb.AppendLine($"**Pass Rate:** {(double)results.Count(r => r.Status == "PASS") / results.Count * 100:F1}%");
            sb.AppendLine($"**Total Duration:** {totalSeconds:F2} seconds");
            sb.AppendLine();
            sb.AppendLine("---");
            sb.AppendLine();
            sb.AppendLine("## Test Results by Module");
            sb.AppendLine();
            sb.AppendLine("| Test ID | Module | Category | Test Name | Status | Duration (ms) | Details / Failure Reason |");
            sb.AppendLine("|---|---|---|---|---|---:|---|");

            foreach (var r in results)
            {
                string statusBadge = r.Status == "PASS" ? "✅ PASS" : "❌ FAIL";
                string error = string.IsNullOrEmpty(r.ErrorMessage) ? "Verified successfully" : r.ErrorMessage.Replace("\n", " ").Replace("\r", "");
                sb.AppendLine($"| **{r.TestId}** | {r.Module} | {r.Category} | {r.Name} | {statusBadge} | {r.DurationMs:F1} | {error} |");
            }

            if (results.Any(r => r.Status == "FAIL"))
            {
                sb.AppendLine();
                sb.AppendLine("---");
                sb.AppendLine();
                sb.AppendLine("## Failed Tests Stack Traces & Diagnostic Logs");
                sb.AppendLine();

                foreach (var fail in results.Where(r => r.Status == "FAIL"))
                {
                    sb.AppendLine($"### [{fail.TestId}] {fail.Module} - {fail.Name}");
                    sb.AppendLine($"- **Error Message:** `{fail.ErrorMessage}`");
                    sb.AppendLine("- **Stack Trace:**");
                    sb.AppendLine("```text");
                    sb.AppendLine(fail.StackTrace ?? "No stack trace available");
                    sb.AppendLine("```");
                    sb.AppendLine();
                }
            }

            File.WriteAllText(filePath, sb.ToString());
        }

        private static void WriteTrxReport(string filePath, List<TestResult> results, TimeSpan totalDuration)
        {
            var sb = new StringBuilder();
            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sb.AppendLine($"<TestRun id=\"{Guid.NewGuid()}\" name=\"SportRoom_QA_{DateTime.Now:yyyyMMdd_HHmmss}\" xmlns=\"http://microsoft.com/schemas/VisualStudio/TeamTest/2010\">");
            sb.AppendLine($"  <Times creation=\"{DateTime.UtcNow:O}\" queuing=\"{DateTime.UtcNow:O}\" start=\"{DateTime.UtcNow:O}\" finish=\"{DateTime.UtcNow.Add(totalDuration):O}\" />");
            sb.AppendLine("  <Results>");

            foreach (var r in results)
            {
                string outcome = r.Status == "PASS" ? "Passed" : "Failed";
                sb.AppendLine($"    <UnitTestResult executionId=\"{Guid.NewGuid()}\" testId=\"{Guid.NewGuid()}\" testName=\"{r.TestId}_{r.Name}\" duration=\"00:00:{(r.DurationMs / 1000.0):00.000}\" outcome=\"{outcome}\">");
                if (!string.IsNullOrEmpty(r.ErrorMessage))
                {
                    sb.AppendLine("      <Output>");
                    sb.AppendLine("        <ErrorInfo>");
                    sb.AppendLine($"          <Message><![CDATA[{r.ErrorMessage}]]></Message>");
                    sb.AppendLine($"          <StackTrace><![CDATA[{r.StackTrace}]]></StackTrace>");
                    sb.AppendLine("        </ErrorInfo>");
                    sb.AppendLine("      </Output>");
                }
                sb.AppendLine("    </UnitTestResult>");
            }

            sb.AppendLine("  </Results>");
            sb.AppendLine("</TestRun>");

            File.WriteAllText(filePath, sb.ToString());
        }
    }
}
