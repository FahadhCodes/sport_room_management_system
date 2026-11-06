using System;

namespace Project_Sport_Room.TestRunner
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TestCaseAttribute : Attribute
    {
        public string TestId { get; }
        public string Module { get; }
        public string Name { get; }
        public string Category { get; }

        public TestCaseAttribute(string testId, string module, string name, string category)
        {
            TestId = testId;
            Module = module;
            Name = name;
            Category = category;
        }
    }

    public class TestResult
    {
        public string TestId { get; set; } = "";
        public string Module { get; set; } = "";
        public string Name { get; set; } = "";
        public string Category { get; set; } = "";
        public string Status { get; set; } = "NOT RUN"; // PASS, FAIL, BLOCKED
        public double DurationMs { get; set; }
        public string? ErrorMessage { get; set; }
        public string? StackTrace { get; set; }
    }

    public static class Assert
    {
        public static void True(bool condition, string message = "Expected true, got false")
        {
            if (!condition) throw new AssertionException(message);
        }

        public static void False(bool condition, string message = "Expected false, got true")
        {
            if (condition) throw new AssertionException(message);
        }

        public static void Equal<T>(T expected, T actual, string? message = null)
        {
            if (!object.Equals(expected, actual))
            {
                throw new AssertionException(message ?? $"Expected '{expected}', but was '{actual}'.");
            }
        }

        public static void NotNull(object? obj, string message = "Expected non-null object")
        {
            if (obj == null) throw new AssertionException(message);
        }

        public static void Null(object? obj, string message = "Expected null object")
        {
            if (obj != null) throw new AssertionException(message);
        }

        public static void Contains(string substring, string fullString, string? message = null)
        {
            if (fullString == null || !fullString.Contains(substring))
            {
                throw new AssertionException(message ?? $"String '{fullString}' does not contain expected substring '{substring}'.");
            }
        }

        public static TException Throws<TException>(Action action, string? message = null) where TException : Exception
        {
            try
            {
                action();
            }
            catch (TException ex)
            {
                return ex;
            }
            catch (Exception ex)
            {
                throw new AssertionException($"Expected exception of type '{typeof(TException).Name}', but caught '{ex.GetType().Name}'.");
            }

            throw new AssertionException(message ?? $"Expected exception of type '{typeof(TException).Name}', but no exception was thrown.");
        }

        public static async Task<TException> ThrowsAsync<TException>(Func<Task> action, string? message = null) where TException : Exception
        {
            try
            {
                await action();
            }
            catch (TException ex)
            {
                return ex;
            }
            catch (Exception ex)
            {
                throw new AssertionException($"Expected exception of type '{typeof(TException).Name}', but caught '{ex.GetType().Name}'.");
            }

            throw new AssertionException(message ?? $"Expected exception of type '{typeof(TException).Name}', but no exception was thrown.");
        }
    }

    public class AssertionException : Exception
    {
        public AssertionException(string message) : base(message) { }
    }
}

