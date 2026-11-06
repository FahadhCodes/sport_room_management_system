using Microsoft.EntityFrameworkCore;
using Project_Sport_Room.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Sport_Room.Forms
{
    public partial class MainPanel : Form
    {
        private bool _isLoaded = false;
        private static string? _cachedLogoBase64;

        public class DamagedItemDTO
        {
            public string EquipmentId { get; set; } = "";
            public string EquipmentName { get; set; } = "";
            public string CategoryName { get; set; } = "";
            public int HealthyQty { get; set; }
            public int BrokenQty { get; set; }
            public int TotalQty { get; set; }
        }

        private class AuditItemDTO
        {
            public string EquipmentId { get; set; } = "";
            public string EquipmentName { get; set; } = "";
            public string CategoryName { get; set; } = "";
            public int ProcuredQty { get; set; }
            public int HealthyShelfQty { get; set; }
            public int BorrowedQty { get; set; }
            public int TotalHealthyQty => HealthyShelfQty + BorrowedQty;
            public int DamagedQty { get; set; }
            public int LostQty { get; set; }
            public int TotalLack => DamagedQty + LostQty;
            public double LackPercentage => (ProcuredQty > 0) ? ((double)TotalLack / ProcuredQty) * 100.0 : 0.0;
            public string StatusBadge { get; set; } = "";
            public string Recommendation { get; set; } = "";
        }

        private class CategorySummaryDTO
        {
            public string CategoryName { get; set; } = "";
            public int TotalItemTypes { get; set; }
            public int ProcuredQty { get; set; }
            public int HealthyQty { get; set; }
            public int DamagedQty { get; set; }
            public int LostQty { get; set; }
            public int TotalLack => DamagedQty + LostQty;
            public double LackPercentage => (ProcuredQty > 0) ? ((double)TotalLack / ProcuredQty) * 100.0 : 0.0;
        }

        public MainPanel()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            // Hook VisibleChanged and Load for automatic refresh
            this.VisibleChanged += MainPanel_VisibleChanged;
            this.Load += MainPanel_Load;

            // Configure Grid
            damageReportGrid.AutoGenerateColumns = false;
            damageReportGrid.AllowUserToAddRows = false;
            damageReportGrid.AllowUserToDeleteRows = false;
            damageReportGrid.ReadOnly = true;
            damageReportGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            damageReportGrid.MultiSelect = false;

            // Map grid columns to DTO properties
            EquipmentId.DataPropertyName = "EquipmentId";
            Equipment.DataPropertyName = "EquipmentName";
            Category.DataPropertyName = "CategoryName";
            healthyQty.DataPropertyName = "HealthyQty";
            BrokenQty.DataPropertyName = "BrokenQty";
            totQty.DataPropertyName = "TotalQty";

            // Align quantity columns
            EquipmentId.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            healthyQty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BrokenQty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            totQty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Highlight damaged column
            BrokenQty.DefaultCellStyle.ForeColor = Color.Brown;
            BrokenQty.DefaultCellStyle.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);

            // Wire search box for instant real-time filtering
            txtSearchDamage.TextChanged += async (s, e) => await LoadDamageReport();

            // Style and wire the Summary Report Generator button
            reportGen.BackColor = Color.Brown;
            reportGen.ForeColor = Color.White;
            reportGen.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold);
            reportGen.FlatStyle = FlatStyle.Flat;
            reportGen.FlatAppearance.BorderSize = 0;
            reportGen.Cursor = Cursors.Hand;
            reportGen.Click += async (s, e) => await GenerateSummaryDamageReportAsync();
        }

        private async void MainPanel_Load(object sender, EventArgs e)
        {
            await RefreshAllData();
            _isLoaded = true;
        }

        private async void MainPanel_VisibleChanged(object sender, EventArgs e)
        {
            // Automatically refreshes the dashboard whenever returning to Home
            if (this.Visible && _isLoaded)
            {
                await RefreshAllData();
            }
        }

        public async Task RefreshAllData()
        {
            await UpdateKPIs();
            await LoadDamageReport();
        }

        private async Task UpdateKPIs()
        {
            try
            {
                using (var db = new SportRoomContext())
                {
                    // 1. Available healthy items currently on the shelf
                    int available = await db.Equipments.SumAsync(e => (int?)e.Quantity) ?? 0;
                    lblAvailableStock.Text = available.ToString();

                    // 2. Total items currently broken / damaged
                    int damaged = await db.Equipments.SumAsync(e => (int?)e.BrokenQty) ?? 0;
                    lblDamagedStock.Text = damaged.ToString();

                    // 3. Borrowed healthy items currently in borrower hands
                    int borrowed = await db.BorrowedCombinations
                        .Where(bc => bc.BorrowReceipt.ReturnedDate == null)
                        .SumAsync(bc => (int?)bc.Qty) ?? 0;
                    lblBorrowedStock.Text = borrowed.ToString();

                    // 4. True total equipment (Available + Damaged + Borrowed)
                    int totalStock = available + damaged + borrowed;
                    lblTotalStock.Text = totalStock.ToString();

                    // 5. Unique catalog types count
                    int catalogTypes = await db.Equipments.CountAsync();
                    lblCatalogTypes.Text = catalogTypes.ToString();

                    // 6. Active loans (open unreturned receipts)
                    int activeLoans = await db.BorrowReceipts.CountAsync(r => r.ReturnedDate == null);
                    lblActiveLoans.Text = activeLoans.ToString();

                    // 7. Overdue loans (unreturned past due date)
                    DateTime now = DateTime.Now;
                    int overdueLoans = await db.BorrowReceipts.CountAsync(r => r.ReturnedDate == null && now > r.DueDate);
                    lblOverdueLoans.Text = overdueLoans.ToString();

                    // 8. New arrivals in last 30 days
                    DateTime thirtyDaysAgo = DateTime.Now.AddDays(-30);
                    int newArrivals = await db.IntakeItems
                        .Where(i => i.SuppliedDate >= thirtyDaysAgo)
                        .SumAsync(i => (int?)i.Quantity) ?? 0;
                    lblNewArrivals.Text = newArrivals.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating home dashboard statistics: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadDamageReport()
        {
            try
            {
                using (var db = new SportRoomContext())
                {
                    string searchTxt = txtSearchDamage.Text.Trim();

                    // Fetch active borrowed counts per equipment to calculate true total quantity
                    var borrowedCounts = await db.BorrowedCombinations
                        .Where(bc => bc.BorrowReceipt.ReturnedDate == null)
                        .GroupBy(bc => bc.EquipmentId)
                        .Select(g => new { EquipmentId = g.Key, BorrowedQty = g.Sum(bc => bc.Qty) })
                        .ToDictionaryAsync(x => x.EquipmentId, x => x.BorrowedQty);

                    // Query equipment that has broken quantity > 0
                    var query = db.Equipments
                        .Include(e => e.Category)
                        .Where(e => e.BrokenQty > 0)
                        .AsNoTracking()
                        .AsQueryable();

                    if (!string.IsNullOrEmpty(searchTxt))
                    {
                        query = query.Where(e =>
                            e.Id.Contains(searchTxt) ||
                            e.Name.Contains(searchTxt) ||
                            (e.Category != null && e.Category.CategoryName.Contains(searchTxt)));
                    }

                    var rawList = await query
                        .OrderByDescending(e => e.BrokenQty)
                        .ThenBy(e => e.Name)
                        .Select(e => new
                        {
                            EquipmentId = e.Id,
                            EquipmentName = e.Name,
                            CategoryName = e.Category != null ? e.Category.CategoryName : "N/A",
                            HealthyQty = e.Quantity,
                            BrokenQty = e.BrokenQty
                        })
                        .ToListAsync();

                    var dtoList = rawList.Select(item =>
                    {
                        int borrowedQty = borrowedCounts.TryGetValue(item.EquipmentId, out int b) ? b : 0;
                        int totalQty = item.HealthyQty + item.BrokenQty + borrowedQty;
                        return new DamagedItemDTO
                        {
                            EquipmentId = item.EquipmentId,
                            EquipmentName = item.EquipmentName,
                            CategoryName = item.CategoryName,
                            HealthyQty = item.HealthyQty,
                            BrokenQty = item.BrokenQty,
                            TotalQty = totalQty
                        };
                    }).ToList();

                    damageReportGrid.DataSource = dtoList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading damaged equipment report: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string GetUniversityLogoBase64()
        {
            if (!string.IsNullOrEmpty(_cachedLogoBase64))
                return _cachedLogoBase64;

            try
            {
                var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
                var img = resources.GetObject("pictureBox1.Image") as Image;
                if (img != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        _cachedLogoBase64 = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                        return _cachedLogoBase64;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Failed to load logo from Form1: {ex.Message}");
            }

            return string.Empty;
        }

        private async Task GenerateSummaryDamageReportAsync()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                List<AuditItemDTO> auditItems = new List<AuditItemDTO>();
                List<CategorySummaryDTO> categorySummaries = new List<CategorySummaryDTO>();
                int totalCatalogCount = 0;
                int totalProcuredSum = 0;
                int totalHealthySum = 0;
                int totalBorrowedSum = 0;
                int totalDamagedSum = 0;
                int totalLostSum = 0;

                using (var db = new SportRoomContext())
                {
                    var equipments = await db.Equipments
                        .Include(e => e.Category)
                        .AsNoTracking()
                        .ToListAsync();

                    if (equipments.Count == 0)
                    {
                        MessageBox.Show("No equipment records found in the database to generate a report.",
                            "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Procured quantities from intakes
                    var procuredCounts = await db.IntakeItems
                        .GroupBy(i => i.EquipmentId)
                        .Select(g => new { EquipmentId = g.Key, ProcuredQty = g.Sum(i => i.Quantity) })
                        .ToDictionaryAsync(x => x.EquipmentId, x => x.ProcuredQty);

                    // Currently borrowed (active) quantities
                    var activeBorrowedCounts = await db.BorrowedCombinations
                        .Where(bc => bc.BorrowReceipt.ReturnedDate == null)
                        .GroupBy(bc => bc.EquipmentId)
                        .Select(g => new { EquipmentId = g.Key, BorrowedQty = g.Sum(bc => bc.Qty) })
                        .ToDictionaryAsync(x => x.EquipmentId, x => x.BorrowedQty);

                    // Lost quantities from returned loans where Qty > ReturnedQuantity
                    var lostCounts = await db.BorrowedCombinations
                        .Where(bc => bc.BorrowReceipt.ReturnedDate != null && bc.Qty > bc.ReturnedQuantity)
                        .GroupBy(bc => bc.EquipmentId)
                        .Select(g => new { EquipmentId = g.Key, LostQty = g.Sum(bc => bc.Qty - bc.ReturnedQuantity) })
                        .ToDictionaryAsync(x => x.EquipmentId, x => x.LostQty);

                    totalCatalogCount = equipments.Count;

                    foreach (var eq in equipments)
                    {
                        int procured = procuredCounts.TryGetValue(eq.Id, out int pQty) ? pQty : (eq.Quantity + eq.BrokenQty);
                        if (procured < (eq.Quantity + eq.BrokenQty))
                            procured = eq.Quantity + eq.BrokenQty;

                        int healthyShelf = eq.Quantity;
                        int borrowed = activeBorrowedCounts.TryGetValue(eq.Id, out int bQty) ? bQty : 0;
                        int damaged = eq.BrokenQty;
                        int lost = lostCounts.TryGetValue(eq.Id, out int lQty) ? lQty : 0;

                        totalProcuredSum += procured;
                        totalHealthySum += healthyShelf;
                        totalBorrowedSum += borrowed;
                        totalDamagedSum += damaged;
                        totalLostSum += lost;

                        string badge;
                        string recommendation;

                        if (damaged > 0 && lost > 0)
                        {
                            badge = $"<span class='badge badge-critical'>Damaged ({damaged}) & Lost ({lost})</span>";
                            recommendation = "Condemn Broken Items & Initiate Borrower Recovery Surcharge";
                        }
                        else if (damaged > 0)
                        {
                            badge = $"<span class='badge badge-danger'>Damaged ({damaged} Units)</span>";
                            recommendation = damaged > 5 ? "Submit to Annual Condemnation Board for Write-off" : "Send for Equipment Repair / Maintenance";
                        }
                        else if (lost > 0)
                        {
                            badge = $"<span class='badge badge-warning'>Lost ({lost} Units)</span>";
                            recommendation = "Borrower Surcharge Applied / Formal Asset Write-off";
                        }
                        else if (healthyShelf == 0 && procured > 0)
                        {
                            badge = "<span class='badge badge-depleted'>Stock Depleted (0 Left)</span>";
                            recommendation = "Priority Re-order Requisition to Department Head";
                        }
                        else
                        {
                            badge = "<span class='badge badge-normal'>Healthy Stock</span>";
                            recommendation = "Routine Scheduled Maintenance & Monitoring";
                        }

                        auditItems.Add(new AuditItemDTO
                        {
                            EquipmentId = eq.Id,
                            EquipmentName = eq.Name,
                            CategoryName = eq.Category != null ? eq.Category.CategoryName : "Unassigned",
                            ProcuredQty = procured,
                            HealthyShelfQty = healthyShelf,
                            BorrowedQty = borrowed,
                            DamagedQty = damaged,
                            LostQty = lost,
                            StatusBadge = badge,
                            Recommendation = recommendation
                        });
                    }

                    // Build Category summaries
                    categorySummaries = auditItems
                        .GroupBy(x => x.CategoryName)
                        .Select(g => new CategorySummaryDTO
                        {
                            CategoryName = g.Key,
                            TotalItemTypes = g.Count(),
                            ProcuredQty = g.Sum(x => x.ProcuredQty),
                            HealthyQty = g.Sum(x => x.TotalHealthyQty),
                            DamagedQty = g.Sum(x => x.DamagedQty),
                            LostQty = g.Sum(x => x.LostQty)
                        })
                        .OrderByDescending(c => c.TotalLack)
                        .ThenBy(c => c.CategoryName)
                        .ToList();
                }

                int totalNetLack = totalDamagedSum + totalLostSum;
                double overallDegradationRate = totalProcuredSum > 0 ? ((double)totalNetLack / totalProcuredSum) * 100.0 : 0.0;

                // Filter audit items to those with damages, losses, or stockouts
                var deficitItems = auditItems
                    .Where(x => x.DamagedQty > 0 || x.LostQty > 0 || x.HealthyShelfQty == 0)
                    .OrderByDescending(x => x.TotalLack)
                    .ThenBy(x => x.HealthyShelfQty)
                    .ThenBy(x => x.EquipmentName)
                    .ToList();

                string reportsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "SummaryReports");
                if (!Directory.Exists(reportsDir))
                {
                    Directory.CreateDirectory(reportsDir);
                }

                string reportId = $"SUSL/SSPE/AUDIT-DMG/{DateTime.Now:yyyyMMdd}-{DateTime.Now:HHmmss}";
                string fileName = $"Equipment_Damage_Loss_Summary_Report_{DateTime.Now:yyyyMMdd_HHmmss}.html";
                string fullPath = Path.Combine(reportsDir, fileName);

                string logoBase64 = GetUniversityLogoBase64();
                string logoHtml = !string.IsNullOrEmpty(logoBase64)
                    ? $"<img class='emblem-img' src='{logoBase64}' alt='SUSL Emblem' />"
                    : "<div style='width:75px;height:75px;border:2px solid #7f1d1d;border-radius:50%;display:flex;align-items:center;justify-content:center;color:#7f1d1d;font-weight:bold;margin:auto;'>SUSL</div>";

                // Build Category Rows
                var sbCategories = new StringBuilder();
                int catIdx = 1;
                foreach (var cat in categorySummaries)
                {
                    sbCategories.AppendLine($@"
                    <tr>
                        <td style='text-align: center;'>{catIdx++}</td>
                        <td><strong>{cat.CategoryName}</strong></td>
                        <td style='text-align: center;'>{cat.TotalItemTypes}</td>
                        <td style='text-align: center;'>{cat.ProcuredQty}</td>
                        <td style='text-align: center; color: #16a34a; font-weight: bold;'>{cat.HealthyQty}</td>
                        <td style='text-align: center; color: #dc2626; font-weight: bold;'>{cat.DamagedQty}</td>
                        <td style='text-align: center; color: #b45309; font-weight: bold;'>{cat.LostQty}</td>
                        <td style='text-align: center; color: #7f1d1d; font-weight: bold;'>{cat.TotalLack}</td>
                        <td style='text-align: center; font-weight: bold;'>{cat.LackPercentage:F1}%</td>
                    </tr>");
                }

                // Build Itemized Deficiency Rows
                var sbItems = new StringBuilder();
                int itemIdx = 1;
                foreach (var item in deficitItems)
                {
                    string lackColor = item.TotalLack > 0 ? "#7f1d1d" : "#475569";
                    sbItems.AppendLine($@"
                    <tr>
                        <td style='text-align: center;'>{itemIdx++}</td>
                        <td><strong>{item.EquipmentId}</strong></td>
                        <td><strong>{item.EquipmentName}</strong></td>
                        <td>{item.CategoryName}</td>
                        <td style='text-align: center;'>{item.ProcuredQty}</td>
                        <td style='text-align: center; color: #16a34a; font-weight: bold;'>{item.HealthyShelfQty}</td>
                        <td style='text-align: center; color: #dc2626; font-weight: bold;'>{item.DamagedQty}</td>
                        <td style='text-align: center; color: #b45309; font-weight: bold;'>{item.LostQty}</td>
                        <td style='text-align: center; color: {lackColor}; font-weight: bold;'>{item.TotalLack}</td>
                        <td style='text-align: center; font-weight: bold;'>{item.LackPercentage:F1}%</td>
                        <td>{item.StatusBadge}</td>
                        <td style='font-size: 11px; color: #334155;'>{item.Recommendation}</td>
                    </tr>");
                }

                string html = $@"<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <title>Equipment Damage, Loss & Deficiency Report - {reportId}</title>
    <style>
        @page {{
            size: A4 portrait;
            margin: 10mm 12mm;
        }}
        * {{
            box-sizing: border-box;
            -webkit-print-color-adjust: exact !important;
            print-color-adjust: exact !important;
        }}
        body {{
            font-family: 'Segoe UI', Arial, Helvetica, sans-serif;
            color: #1e293b;
            background: #ffffff;
            margin: 0;
            padding: 16px;
            font-size: 12px;
            line-height: 1.4;
        }}
        .top-action-bar {{
            display: flex;
            justify-content: space-between;
            align-items: center;
            background: #f8fafc;
            border: 1px solid #cbd5e1;
            padding: 10px 16px;
            border-radius: 6px;
            margin-bottom: 16px;
        }}
        .btn-print {{
            background: #7f1d1d;
            color: #ffffff;
            border: none;
            padding: 8px 18px;
            font-size: 13px;
            font-weight: bold;
            border-radius: 4px;
            cursor: pointer;
        }}
        .btn-print:hover {{
            background: #991b1b;
        }}
        .header-table {{
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 8px;
        }}
        .header-table td {{
            vertical-align: middle;
        }}
        .emblem-cell {{
            width: 85px;
            text-align: center;
            vertical-align: middle;
        }}
        .emblem-img {{
            max-width: 80px;
            max-height: 80px;
            object-fit: contain;
            display: block;
            margin: auto;
        }}
        .uni-titles {{
            text-align: center;
            padding-right: 85px;
        }}
        .uni-name {{
            font-size: 15px;
            font-weight: 800;
            color: #7f1d1d;
            letter-spacing: 0.5px;
            margin: 0;
            text-transform: uppercase;
        }}
        .faculty-name {{
            font-size: 11px;
            font-weight: 700;
            color: #334155;
            margin: 2px 0;
            text-transform: uppercase;
            letter-spacing: 0.3px;
        }}
        .dept-name {{
            font-size: 12px;
            font-weight: 700;
            color: #1e293b;
            margin: 2px 0;
            text-transform: uppercase;
        }}
        .system-name {{
            font-size: 10px;
            font-weight: 600;
            color: #64748b;
            margin: 2px 0 0 0;
            text-transform: uppercase;
            letter-spacing: 0.5px;
        }}
        .divider-bar {{
            height: 3px;
            background: linear-gradient(to right, #7f1d1d, #b91c1c, #7f1d1d);
            margin: 8px 0 12px 0;
            border-radius: 2px;
        }}
        .report-meta-table {{
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 12px;
            background: #f8fafc;
            border: 1px solid #e2e8f0;
            border-radius: 4px;
        }}
        .report-meta-table td {{
            padding: 6px 10px;
            font-size: 11px;
        }}
        .meta-title {{
            font-size: 13px;
            font-weight: 800;
            color: #7f1d1d;
            text-transform: uppercase;
        }}
        .kpi-row {{
            display: flex;
            gap: 8px;
            margin-bottom: 14px;
        }}
        .kpi-card {{
            flex: 1;
            padding: 8px 6px;
            border-radius: 5px;
            text-align: center;
            border: 1px solid #cbd5e1;
            background: #f8fafc;
        }}
        .kpi-card.alert-damaged {{
            background: #fef2f2;
            border-color: #fca5a5;
        }}
        .kpi-card.alert-lost {{
            background: #fffbeb;
            border-color: #fde68a;
        }}
        .kpi-card.alert-lack {{
            background: #faf5ff;
            border-color: #d8b4fe;
        }}
        .kpi-num {{
            font-size: 17px;
            font-weight: 800;
            margin: 2px 0;
        }}
        .kpi-title {{
            font-size: 9px;
            font-weight: 700;
            text-transform: uppercase;
            color: #475569;
        }}
        .section-title {{
            font-size: 12px;
            font-weight: 700;
            color: #1e293b;
            text-transform: uppercase;
            letter-spacing: 0.5px;
            border-bottom: 2px solid #cbd5e1;
            padding-bottom: 4px;
            margin: 14px 0 8px 0;
            display: flex;
            justify-content: space-between;
        }}
        .data-table {{
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 12px;
            font-size: 11px;
        }}
        .data-table th {{
            background-color: #f1f5f9;
            color: #334155;
            font-weight: 700;
            text-transform: uppercase;
            padding: 6px 6px;
            border: 1px solid #cbd5e1;
            font-size: 10px;
        }}
        .data-table td {{
            padding: 5px 6px;
            border: 1px solid #cbd5e1;
            vertical-align: middle;
        }}
        .data-table tr:nth-child(even) {{
            background-color: #fafbfc;
        }}
        .badge {{
            display: inline-block;
            padding: 2px 6px;
            border-radius: 3px;
            font-size: 9px;
            font-weight: 700;
            text-transform: uppercase;
        }}
        .badge-danger {{
            background: #fee2e2;
            color: #dc2626;
            border: 1px solid #fca5a5;
        }}
        .badge-warning {{
            background: #fef3c7;
            color: #b45309;
            border: 1px solid #fcd34d;
        }}
        .badge-critical {{
            background: #fdf2f8;
            color: #9d174d;
            border: 1px solid #fbcfe8;
        }}
        .badge-depleted {{
            background: #f3f4f6;
            color: #4b5563;
            border: 1px solid #d1d5db;
        }}
        .badge-normal {{
            background: #dcfce7;
            color: #15803d;
            border: 1px solid #86efac;
        }}
        .declaration {{
            font-size: 11px;
            color: #334155;
            background: #f8fafc;
            border-left: 4px solid #7f1d1d;
            padding: 8px 12px;
            margin: 14px 0;
            font-style: italic;
        }}
        .signatures-table {{
            width: 100%;
            border-collapse: collapse;
            margin-top: 15px;
            page-break-inside: avoid;
        }}
        .sig-block {{
            width: 33.3%;
            vertical-align: top;
            padding: 0 10px;
            text-align: center;
        }}
        .sig-line {{
            margin-top: 40px;
            border-top: 1px solid #334155;
            padding-top: 4px;
            font-weight: 700;
            font-size: 11px;
        }}
        .sig-subtitle {{
            font-size: 10px;
            color: #64748b;
        }}
        .stamp-box {{
            height: 70px;
            border: 1px dashed #94a3b8;
            border-radius: 4px;
            margin-top: 5px;
            display: flex;
            align-items: center;
            justify-content: center;
            font-size: 10px;
            color: #94a3b8;
            text-transform: uppercase;
            font-weight: 600;
        }}
        @media print {{
            .top-action-bar {{
                display: none;
            }}
            body {{
                padding: 0;
            }}
            .data-table tr {{
                page-break-inside: avoid;
            }}
        }}
    </style>
</head>
<body>

    <!-- Print Navigation Bar -->
    <div class='top-action-bar'>
        <div>
            <strong style='color: #7f1d1d;'>Official University Document:</strong> Equipment Damage, Loss & Deficiency Summary Report
        </div>
        <button class='btn-print' onclick='window.print()'>Print Report / Save PDF</button>
    </div>

    <!-- Official Header Table -->
    <table class='header-table'>
        <tr>
            <td class='emblem-cell'>
                {logoHtml}
            </td>
            <td class='uni-titles'>
                <div class='uni-name'>Sabaragamuwa University of Sri Lanka</div>
                <div class='faculty-name'>Faculty of Applied Sciences</div>
                <div class='dept-name'>Department of Sport Sciences and Physical Education</div>
                <div class='system-name'>Sport Room Management System (SRMS)</div>
            </td>
        </tr>
    </table>

    <div class='divider-bar'></div>

    <!-- Report Metadata Summary -->
    <table class='report-meta-table'>
        <tr>
            <td style='width: 60%;'>
                <div class='meta-title'>Equipment Damage, Loss & Deficiency Report</div>
                <div style='color: #64748b; font-size: 10px; margin-top: 2px;'>Formal Reconciliation of Broken Assets, Unreturned Equipment & Inventory Deficits</div>
            </td>
            <td style='width: 40%; text-align: right;'>
                <div><strong>Report Ref:</strong> {reportId}</div>
                <div><strong>Audit Date:</strong> {DateTime.Now:dd/MM/yyyy  hh:mm tt}</div>
            </td>
        </tr>
    </table>

    <!-- Executive KPI Summary Cards -->
    <div class='kpi-row'>
        <div class='kpi-card'>
            <div class='kpi-title'>Total Procured</div>
            <div class='kpi-num' style='color: #1e293b;'>{totalProcuredSum}</div>
            <div style='font-size: 9px; color: #64748b;'>{totalCatalogCount} Equipment Types</div>
        </div>
        <div class='kpi-card'>
            <div class='kpi-title'>Available Healthy</div>
            <div class='kpi-num' style='color: #16a34a;'>{totalHealthySum}</div>
            <div style='font-size: 9px; color: #64748b;'>On Shelves Ready</div>
        </div>
        <div class='kpi-card alert-damaged'>
            <div class='kpi-title' style='color: #991b1b;'>Damaged / Broken</div>
            <div class='kpi-num' style='color: #dc2626;'>{totalDamagedSum}</div>
            <div style='font-size: 9px; color: #991b1b;'>Needs Repair / Write-off</div>
        </div>
        <div class='kpi-card alert-lost'>
            <div class='kpi-title' style='color: #92400e;'>Lost / Unreturned</div>
            <div class='kpi-num' style='color: #b45309;'>{totalLostSum}</div>
            <div style='font-size: 9px; color: #92400e;'>Missing from Loans</div>
        </div>
        <div class='kpi-card alert-lack'>
            <div class='kpi-title' style='color: #6b21a8;'>Total Net Deficit (Lack)</div>
            <div class='kpi-num' style='color: #7f1d1d;'>{totalNetLack}</div>
            <div style='font-size: 9px; color: #6b21a8;'>Degradation: {overallDegradationRate:F1}%</div>
        </div>
    </div>

    <!-- Category Summary Breakdown Table -->
    <div class='section-title'>
        <span>1. Category-Wise Damage & Shortage Distribution</span>
        <span style='font-size: 10px; font-weight: normal; text-transform: none; color: #64748b;'>{categorySummaries.Count} Registered Categories</span>
    </div>

    <table class='data-table'>
        <thead>
            <tr>
                <th style='width: 35px; text-align: center;'>#</th>
                <th>Equipment Category</th>
                <th style='width: 70px; text-align: center;'>Item Types</th>
                <th style='width: 75px; text-align: center;'>Procured</th>
                <th style='width: 75px; text-align: center;'>Healthy</th>
                <th style='width: 75px; text-align: center;'>Damaged</th>
                <th style='width: 70px; text-align: center;'>Lost</th>
                <th style='width: 80px; text-align: center;'>Net Deficit</th>
                <th style='width: 70px; text-align: center;'>Deficit %</th>
            </tr>
        </thead>
        <tbody>
            {sbCategories}
            <tr style='background: #f1f5f9; font-weight: bold;'>
                <td colspan='2' style='text-align: right; padding-right: 10px;'>TOTAL CONSOLIDATED:</td>
                <td style='text-align: center;'>{totalCatalogCount}</td>
                <td style='text-align: center;'>{totalProcuredSum}</td>
                <td style='text-align: center; color: #16a34a;'>{totalHealthySum + totalBorrowedSum}</td>
                <td style='text-align: center; color: #dc2626;'>{totalDamagedSum}</td>
                <td style='text-align: center; color: #b45309;'>{totalLostSum}</td>
                <td style='text-align: center; color: #7f1d1d;'>{totalNetLack}</td>
                <td style='text-align: center;'>{overallDegradationRate:F1}%</td>
            </tr>
        </tbody>
    </table>

    <!-- Detailed Deficit & Damage Registry -->
    <div class='section-title'>
        <span>2. Itemized Equipment Damage, Loss & Deficiency Audit Registry</span>
        <span style='font-size: 10px; font-weight: normal; text-transform: none; color: #64748b;'>Listing {deficitItems.Count} Deficient / Damaged / Depleted Items</span>
    </div>

    <table class='data-table'>
        <thead>
            <tr>
                <th style='width: 30px; text-align: center;'>#</th>
                <th style='width: 65px;'>Item Code</th>
                <th>Equipment Name</th>
                <th style='width: 95px;'>Category</th>
                <th style='width: 55px; text-align: center;'>Procured</th>
                <th style='width: 55px; text-align: center;'>Healthy</th>
                <th style='width: 55px; text-align: center;'>Damaged</th>
                <th style='width: 50px; text-align: center;'>Lost</th>
                <th style='width: 55px; text-align: center;'>Lack</th>
                <th style='width: 55px; text-align: center;'>Rate</th>
                <th style='width: 140px;'>Deficiency Status</th>
                <th style='width: 170px;'>Audit Recommendation</th>
            </tr>
        </thead>
        <tbody>
            {sbItems}
        </tbody>
    </table>

    <!-- Official Declaration -->
    <div class='declaration'>
        <strong>Official Audit Certification:</strong> This document certifies an accurate and truthful physical audit reconciliation of all damaged, broken, lost, and depleted sports equipment within the Department of Sport Sciences and Physical Education. All recorded damages and shortages have been verified according to the Inventory Regulations and Asset Disposal Code of the Sabaragamuwa University of Sri Lanka.
    </div>

    <!-- Official Signatures & Verification -->
    <table class='signatures-table'>
        <tr>
            <td class='sig-block'>
                <div class='sig-line'>Sport Room Officer-in-Charge</div>
                <div class='sig-subtitle'>Inventory Custodian / Storekeeper</div>
                <div class='sig-subtitle'>Date: ________________________</div>
            </td>
            <td class='sig-block'>
                <div class='stamp-box'></div>
            </td>
            <td class='sig-block'>
                <div class='sig-line'>Head of Department / Director</div>
                <div class='sig-subtitle'>Dept. of Sport Sciences & Physical Education</div>
                <div class='sig-subtitle'>Date: ________________________</div>
            </td>
        </tr>
    </table>

</body>
</html>";

                File.WriteAllText(fullPath, html, Encoding.UTF8);

                if (File.Exists(fullPath))
                {
                    try
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = fullPath,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception procEx)
                    {
                        Debug.WriteLine($"Failed to auto-open browser: {procEx.Message}");
                    }

                    MessageBox.Show(
                        $"Equipment Damage, Loss & Deficiency Summary Report generated successfully!\n\nSaved to: {fullPath}",
                        "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating damage and loss summary report: {ex.Message}",
                    "Report Generation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
