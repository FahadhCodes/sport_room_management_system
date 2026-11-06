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

namespace Project_Sport_Room
{
    public partial class ReturnInspectionDialog : Form
    {
        private string? _receiptId;

        public class InspectionRowDTO
        {
            public string CombinationId { get; set; } = "";
            public string EquipmentId { get; set; } = "";
            public string EquipmentName { get; set; } = "";
            public string CategoryName { get; set; } = "";
            public int BorrowedQty { get; set; }
            public int ReturnedQty { get; set; }
            public int BrokenQty { get; set; }
            public int HealthyQty => Math.Max(0, ReturnedQty - BrokenQty);
            public int LostQty => Math.Max(0, BorrowedQty - ReturnedQty);
        }

        private BindingList<InspectionRowDTO> _itemsList = new BindingList<InspectionRowDTO>();
        private BorrowReceipt? _currentReceipt;

        public ReturnInspectionDialog()
        {
            InitializeComponent();
            SetupForm();
        }

        public ReturnInspectionDialog(string receiptId) : this()
        {
            _receiptId = receiptId;
        }

        private void SetupForm()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Wire event handlers
            this.Load += ReturnInspectionDialog_Load;
            genDmgReport.Click += genDmgReport_Click;

            // Configure Grid
            borrowingList.AutoGenerateColumns = false;
            borrowingList.AllowUserToAddRows = false;
            borrowingList.AllowUserToDeleteRows = false;

            // Map data property names
            EquipmentName.DataPropertyName = "EquipmentId";
            brrQty.DataPropertyName = "BorrowedQty";
            BrokenQty.DataPropertyName = "BrokenQty";
            ReturnedQty.DataPropertyName = "ReturnedQty";

            // Set column read-only states
            EquipmentName.ReadOnly = true;
            brrQty.ReadOnly = true;
            ReturnedQty.ReadOnly = false;
            BrokenQty.ReadOnly = false;

            // Prevent WinForms ComboBox DataError popups
            borrowingList.DataError += (s, e) => { e.Cancel = true; };

            // Real-time calculation on cell edits
            borrowingList.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (borrowingList.IsCurrentCellDirty)
                {
                    borrowingList.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            };
            borrowingList.CellValueChanged += BorrowingList_CellValueChanged;
        }

        private async void ReturnInspectionDialog_Load(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_receiptId))
            {
                MessageBox.Show("No Receipt ID provided.", "Inspection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            await LoadReceiptData(_receiptId);
        }

        private async Task LoadReceiptData(string receiptId)
        {
            try
            {
                using (var db = new SportRoomContext())
                {
                    // 1. Load equipment dropdown source for ComboBox column
                    var equipments = await db.Equipments.Select(eq => new { eq.Id, eq.Name }).ToListAsync();
                    EquipmentName.DataSource = equipments;
                    EquipmentName.DisplayMember = "Name";
                    EquipmentName.ValueMember = "Id";

                    // 2. Fetch Receipt with all navigations
                    _currentReceipt = await db.BorrowReceipts
                        .Include(r => r.Borrower)
                            .ThenInclude(b => b.Department)
                        .Include(r => r.BorrowedCombinations)
                            .ThenInclude(c => c.Equipment)
                                .ThenInclude(eq => eq.Category)
                        .FirstOrDefaultAsync(r => r.ReceiptId == receiptId);

                    if (_currentReceipt == null)
                    {
                        MessageBox.Show($"Receipt '{receiptId}' could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }

                    // 3. Populate Header Labels
                    borrowerName.Text = _currentReceipt.Borrower?.Name ?? "N/A";
                    role.Text = _currentReceipt.Borrower?.Role ?? "N/A";
                    departmentLbl.Text = _currentReceipt.Borrower?.Department?.Name ?? _currentReceipt.Borrower?.DepartmentId ?? "N/A";
                    issuedDate.Text = _currentReceipt.IssuedDate.ToString("yyyy-MM-dd");
                    dueDate.Text = _currentReceipt.DueDate.ToString("yyyy-MM-dd");
                    returnedDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

                    // 4. Populate Items Grid
                    _itemsList.Clear();
                    foreach (var combo in _currentReceipt.BorrowedCombinations)
                    {
                        int retQty = combo.ReturnedQuantity > 0 ? combo.ReturnedQuantity : combo.Qty;
                        _itemsList.Add(new InspectionRowDTO
                        {
                            CombinationId = combo.CombinationId,
                            EquipmentId = combo.EquipmentId,
                            EquipmentName = combo.Equipment?.Name ?? combo.EquipmentId,
                            CategoryName = combo.Equipment?.Category?.CategoryName ?? "General",
                            BorrowedQty = combo.Qty,
                            ReturnedQty = retQty,
                            BrokenQty = combo.BrokenQty
                        });
                    }

                    borrowingList.DataSource = _itemsList;
                    UpdateKpiLabels();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading inspection details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrowingList_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _itemsList.Count) return;

            var row = _itemsList[e.RowIndex];

            // Validation & Clamping
            if (row.ReturnedQty < 0) row.ReturnedQty = 0;
            if (row.ReturnedQty > row.BorrowedQty)
            {
                MessageBox.Show($"Returned quantity cannot exceed borrowed quantity ({row.BorrowedQty}).", "Validation Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                row.ReturnedQty = row.BorrowedQty;
            }

            if (row.BrokenQty < 0) row.BrokenQty = 0;
            if (row.BrokenQty > row.ReturnedQty)
            {
                MessageBox.Show($"Damaged quantity ({row.BrokenQty}) cannot exceed returned quantity ({row.ReturnedQty}).", "Validation Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                row.BrokenQty = row.ReturnedQty;
            }

            borrowingList.InvalidateRow(e.RowIndex);
            UpdateKpiLabels();
        }

        private void UpdateKpiLabels()
        {
            int totalBorrowed = _itemsList.Sum(x => x.BorrowedQty);
            int totalHealthy = _itemsList.Sum(x => x.HealthyQty);
            int totalDamaged = _itemsList.Sum(x => x.BrokenQty);
            int totalLost = _itemsList.Sum(x => x.LostQty);

            summary.Text = totalBorrowed.ToString();
            healthy.Text = totalHealthy.ToString();
            dmgs.Text = totalDamaged.ToString();
            lost.Text = totalLost.ToString();

            // Dynamic button text based on whether damage/loss occurred
            if (totalDamaged > 0 || totalLost > 0)
            {
                genDmgReport.Text = "Confirm Return & Generate Damage Report";
                genDmgReport.BackColor = Color.Brown;
                genDmgReport.ForeColor = Color.White;
            }
            else
            {
                genDmgReport.Text = "Confirm Return (All Healthy)";
                genDmgReport.BackColor = Color.ForestGreen;
                genDmgReport.ForeColor = Color.White;
            }
        }

        private async void genDmgReport_Click(object? sender, EventArgs e)
        {
            borrowingList.EndEdit();

            if (_currentReceipt == null || string.IsNullOrEmpty(_receiptId))
            {
                MessageBox.Show("Invalid receipt reference.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm prompt
            int totalDamaged = _itemsList.Sum(x => x.BrokenQty);
            int totalLost = _itemsList.Sum(x => x.LostQty);
            string promptMsg = totalDamaged > 0 || totalLost > 0
                ? $"Confirm loan return with {totalDamaged} damaged and {totalLost} lost items?\nAn official university damage incident report will be generated automatically."
                : "Confirm loan return? All items will be restocked as healthy to inventory.";

            var dr = MessageBox.Show(promptMsg, "Confirm Return Inspection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes) return;

            try
            {
                using (var db = new SportRoomContext())
                {
                    var receipt = await db.BorrowReceipts
                        .Include(r => r.Borrower)
                            .ThenInclude(b => b.Department)
                        .Include(r => r.BorrowedCombinations)
                            .ThenInclude(c => c.Equipment)
                                .ThenInclude(eq => eq.Category)
                        .FirstOrDefaultAsync(r => r.ReceiptId == _receiptId);

                    if (receipt == null)
                    {
                        MessageBox.Show("Receipt not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DateTime actualReturnTime = DateTime.Now;
                    receipt.ReturnedDate = actualReturnTime;
                    receipt.UpdateStatus();

                    // Apply restock and damage allocations
                    foreach (var row in _itemsList)
                    {
                        var combo = receipt.BorrowedCombinations.FirstOrDefault(c => c.CombinationId == row.CombinationId);
                        if (combo != null)
                        {
                            combo.ReturnedQuantity = row.ReturnedQty;
                            combo.BrokenQty = row.BrokenQty;

                            var eq = await db.Equipments.FindAsync(row.EquipmentId);
                            if (eq != null)
                            {
                                eq.Quantity += row.HealthyQty;
                                eq.BrokenQty += row.BrokenQty;
                            }
                        }
                    }

                    await db.SaveChangesAsync();

                    // If damaged or lost items exist, automatically generate official SUSL HTML report
                    if (totalDamaged > 0 || totalLost > 0)
                    {
                        string reportPath = GenerateSuslDamageReport(receipt, _itemsList.ToList(), actualReturnTime);
                        if (!string.IsNullOrEmpty(reportPath) && File.Exists(reportPath))
                        {
                            try
                            {
                                Process.Start(new ProcessStartInfo
                                {
                                    FileName = reportPath,
                                    UseShellExecute = true
                                });
                            }
                            catch { }
                        }

                        MessageBox.Show("Return processed successfully!\n\nOfficial University Equipment Damage Report generated and opened for printing.",
                            "Return Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Return processed successfully! All equipment items restocked to healthy inventory.",
                            "Return Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing return: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string? _cachedLogoBase64;

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

        private string GenerateSuslDamageReport(BorrowReceipt receipt, List<InspectionRowDTO> items, DateTime returnDate)
        {
            try
            {
                string reportsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "DamageReports");
                if (!Directory.Exists(reportsDir))
                {
                    Directory.CreateDirectory(reportsDir);
                }

                string reportId = $"SUSL/SSPE/DMG/{DateTime.Now:yyyyMMdd}-{receipt.ReceiptId}";
                string fileName = $"Damage_Report_{receipt.ReceiptId}_{DateTime.Now:yyyyMMdd_HHmmss}.html";
                string fullPath = Path.Combine(reportsDir, fileName);

                var sbRows = new StringBuilder();
                int idx = 1;
                foreach (var item in items)
                {
                    sbRows.AppendLine($@"
                    <tr style='height: 34px;'>
                        <td style='text-align: center;'>{idx++}</td>
                        <td><strong>{item.EquipmentId}</strong></td>
                        <td>{item.EquipmentName}</td>
                        <td>{item.CategoryName}</td>
                        <td style='text-align: center;'>{item.BorrowedQty}</td>
                        <td style='text-align: center; color: #16a34a; font-weight: bold;'>{item.HealthyQty}</td>
                        <td style='text-align: center; color: #dc2626; font-weight: bold;'>{item.BrokenQty}</td>
                        <td style='height: 34px;'>&nbsp;</td>
                    </tr>");
                }

                int totalBorrowed = items.Sum(x => x.BorrowedQty);
                int totalHealthy = items.Sum(x => x.HealthyQty);
                int totalDamaged = items.Sum(x => x.BrokenQty);
                int totalLost = items.Sum(x => x.LostQty);

                string logoBase64 = GetUniversityLogoBase64();
                string logoHtml = !string.IsNullOrEmpty(logoBase64)
                    ? $"<img class='emblem-img' src='{logoBase64}' alt='Sabaragamuwa University Emblem' />"
                    : "<div style='width:75px;height:75px;border:1px solid #7f1d1d;border-radius:50%;display:flex;align-items:center;justify-content:center;color:#7f1d1d;font-weight:bold;font-size:11px;margin:auto;'>SUSL</div>";

                string borrowerNameStr = receipt.Borrower?.Name ?? "N/A";
                string borrowerIdStr = receipt.Borrower?.BorrowerId ?? "N/A";
                string borrowerRoleStr = receipt.Borrower?.Role ?? "N/A";
                string deptStr = receipt.Borrower?.Department?.Name ?? receipt.Borrower?.DepartmentId ?? "N/A";
                string phoneStr = receipt.Borrower?.PhoneNumber ?? "N/A";
                string returnStatusStr = returnDate > receipt.DueDate ? "RETURNED LATE" : "RETURNED";
                string badgeBg = returnDate > receipt.DueDate ? "#dc2626" : "#2563eb";

                string html = $@"<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <title>Equipment Return & Damage Report - {reportId}</title>
    <style>
        @page {{
            size: A4 portrait;
            margin: 12mm 15mm;
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
            padding: 20px;
            font-size: 13px;
            line-height: 1.4;
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
            width: 90px;
            text-align: center;
            vertical-align: middle;
        }}
        .emblem-img {{
            max-width: 80px;
            max-height: 80px;
            object-fit: contain;
            display: inline-block;
        }}
        .uni-title-cell {{
            text-align: center;
            padding: 0 10px;
        }}
        .uni-title {{
            font-family: 'Times New Roman', Georgia, serif;
            font-size: 19px;
            font-weight: 800;
            color: #7f1d1d;
            letter-spacing: 0.8px;
            margin: 0;
            text-transform: uppercase;
        }}
        .dept-title {{
            font-size: 13px;
            font-weight: 700;
            color: #1e293b;
            margin: 3px 0;
            text-transform: uppercase;
        }}
        .sub-dept {{
            font-size: 11px;
            color: #475569;
            margin: 0;
        }}
        .system-tag {{
            font-size: 10px;
            font-weight: bold;
            color: #0369a1;
            margin-top: 2px;
            letter-spacing: 0.5px;
        }}
        .ornamental-line {{
            height: 3px;
            background: #7f1d1d;
            border-bottom: 1px solid #000;
            margin: 8px 0 14px 0;
        }}
        .slip-header {{
            display: flex;
            justify-content: space-between;
            align-items: center;
            background: #f8fafc;
            border: 1px solid #cbd5e1;
            border-radius: 4px;
            padding: 8px 14px;
            margin-bottom: 12px;
        }}
        .slip-title {{
            font-size: 14px;
            font-weight: bold;
            color: #7f1d1d;
            text-transform: uppercase;
            letter-spacing: 0.5px;
        }}
        .slip-meta {{
            font-size: 11px;
            color: #475569;
        }}
        .status-badge {{
            background: {badgeBg};
            color: #ffffff;
            font-size: 10px;
            font-weight: bold;
            padding: 3px 8px;
            border-radius: 3px;
            text-transform: uppercase;
        }}
        .info-grid {{
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 14px;
            border: 1px solid #cbd5e1;
        }}
        .info-grid td {{
            padding: 6px 10px;
            border: 1px solid #e2e8f0;
            font-size: 12px;
        }}
        .info-label {{
            background: #f1f5f9;
            font-weight: 600;
            color: #334155;
            width: 18%;
        }}
        .info-value {{
            color: #0f172a;
            width: 32%;
        }}
        .items-table {{
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 14px;
        }}
        .items-table th {{
            background: #7f1d1d;
            color: #ffffff;
            font-weight: 600;
            font-size: 11px;
            text-transform: uppercase;
            padding: 7px 6px;
            border: 1px solid #7f1d1d;
        }}
        .items-table td {{
            padding: 7px 6px;
            border: 1px solid #cbd5e1;
            font-size: 12px;
        }}
        .items-table tr:nth-child(even) {{
            background: #f8fafc;
        }}
        .kpi-container {{
            display: flex;
            justify-content: space-between;
            gap: 10px;
            margin-bottom: 14px;
        }}
        .kpi-card {{
            flex: 1;
            padding: 8px;
            border-radius: 4px;
            text-align: center;
            border: 1px solid #cbd5e1;
            background: #f8fafc;
        }}
        .kpi-card.alert {{
            background: #fef2f2;
            border-color: #fca5a5;
        }}
        .kpi-num {{
            font-size: 18px;
            font-weight: bold;
            margin: 2px 0;
        }}
        .kpi-title {{
            font-size: 10px;
            font-weight: 600;
            text-transform: uppercase;
            color: #475569;
        }}
        .declaration {{
            font-size: 11px;
            color: #334155;
            background: #fafafa;
            border-left: 3px solid #7f1d1d;
            padding: 7px 10px;
            margin-bottom: 20px;
            font-style: italic;
        }}
        .signatures-table {{
            width: 100%;
            border-collapse: collapse;
            margin-top: 15px;
        }}
        .sig-block {{
            width: 33%;
            vertical-align: top;
            padding: 0 10px;
            text-align: center;
        }}
        .sig-line {{
            margin-top: 45px;
            border-top: 1px solid #334155;
            padding-top: 4px;
            font-weight: 600;
            font-size: 11px;
        }}
        .sig-subtitle {{
            font-size: 10px;
            color: #64748b;
        }}
        .stamp-box {{
            height: 75px;
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
            body {{ padding: 0; }}
            .no-print {{ display: none; }}
        }}
    </style>
</head>
<body>

    <!-- University Letterhead -->
    <table class='header-table'>
        <tr>
            <td class='emblem-cell'>
                {logoHtml}
            </td>
            <td class='uni-title-cell'>
                <h1 class='uni-title'>Sabaragamuwa University of Sri Lanka</h1>
                <div class='dept-title'>Department of Sport Sciences and Physical Education</div>
                <div class='sub-dept'>Faculty of Applied Sciences &bull; P.O. Box 02, Belihuloya, 70140, Sri Lanka</div>
                <div class='system-tag'>SPORT ROOM MANAGEMENT SYSTEM &bull; EQUIPMENT AUDIT DIVISION</div>
            </td>
        </tr>
    </table>

    <div class='ornamental-line'></div>

    <!-- Slip Header Bar -->
    <div class='slip-header'>
        <div>
            <span class='slip-title'>Equipment Return & Damage Incident Report</span>
        </div>
        <div class='slip-meta'>
            <strong>Ref:</strong> {reportId} &nbsp;|&nbsp;
            <strong>Date:</strong> {DateTime.Now:yyyy-MM-dd HH:mm} &nbsp;|&nbsp;
            <span class='status-badge'>{returnStatusStr}</span>
        </div>
    </div>

    <!-- Borrower and Loan Information -->
    <table class='info-grid'>
        <tr>
            <td class='info-label'>Borrower Name</td>
            <td class='info-value'><strong>{borrowerNameStr}</strong></td>
            <td class='info-label'>Receipt ID</td>
            <td class='info-value'><strong>{receipt.ReceiptId}</strong></td>
        </tr>
        <tr>
            <td class='info-label'>Borrower ID / Reg No</td>
            <td class='info-value'>{borrowerIdStr}</td>
            <td class='info-label'>Issued Date</td>
            <td class='info-value'>{receipt.IssuedDate:yyyy-MM-dd}</td>
        </tr>
        <tr>
            <td class='info-label'>Role</td>
            <td class='info-value'>{borrowerRoleStr}</td>
            <td class='info-label'>Scheduled Due Date</td>
            <td class='info-value'>{receipt.DueDate:yyyy-MM-dd}</td>
        </tr>
        <tr>
            <td class='info-label'>Department / Faculty</td>
            <td class='info-value'>{deptStr}</td>
            <td class='info-label'>Actual Return Date</td>
            <td class='info-value'><strong>{returnDate:yyyy-MM-dd HH:mm}</strong></td>
        </tr>
        <tr>
            <td class='info-label'>Contact Phone</td>
            <td class='info-value'>{phoneStr}</td>
            <td class='info-label'>Inspection Status</td>
            <td class='info-value' style='color: {(totalDamaged > 0 ? "#dc2626" : "#16a34a")}; font-weight: bold;'>
                {(totalDamaged > 0 ? $"Damaged ({totalDamaged} Items)" : "All Items Intact")}
            </td>
        </tr>
    </table>

    <!-- Equipment Inspection Details -->
    <table class='items-table'>
        <thead>
            <tr>
                <th style='width: 4%;'>#</th>
                <th style='width: 12%;'>Item Code</th>
                <th style='width: 24%;'>Equipment Description</th>
                <th style='width: 14%;'>Category</th>
                <th style='width: 7%;'>Issued</th>
                <th style='width: 8%;'>Healthy</th>
                <th style='width: 9%;'>Damaged</th>
                <th style='width: 22%;'>Nature of Defect / Officer's Remarks</th>
            </tr>
        </thead>
        <tbody>
            {sbRows}
        </tbody>
    </table>

    <!-- Summary KPI Cards -->
    <div class='kpi-container'>
        <div class='kpi-card'>
            <div class='kpi-title'>Total Issued</div>
            <div class='kpi-num' style='color: #0f172a;'>{totalBorrowed}</div>
        </div>
        <div class='kpi-card'>
            <div class='kpi-title'>Restocked Healthy</div>
            <div class='kpi-num' style='color: #16a34a;'>{totalHealthy}</div>
        </div>
        <div class='kpi-card alert'>
            <div class='kpi-title' style='color: #991b1b;'>Damaged / Broken</div>
            <div class='kpi-num' style='color: #dc2626;'>{totalDamaged}</div>
        </div>
        <div class='kpi-card'>
            <div class='kpi-title'>Unreturned / Lost</div>
            <div class='kpi-num' style='color: #b45309;'>{totalLost}</div>
        </div>
    </div>

    <!-- Official Declaration -->
    <div class='declaration'>
        <strong>Declaration:</strong> I hereby confirm that the equipment listed above has been inspected upon return to the Department Sports Room. Any noted damages or deficiencies have been recorded according to the inventory guidelines of the Sabaragamuwa University of Sri Lanka.
    </div>

    <!-- Signatures & Verification -->
    <table class='signatures-table'>
        <tr>
            <td class='sig-block'>
                <div class='sig-line'>Borrower Signature</div>
                <div class='sig-subtitle'>{borrowerNameStr} ({borrowerIdStr})</div>
                <div class='sig-subtitle'>Date: ____________________</div>
            </td>
            <td class='sig-block'>
                <div class='sig-line'>Sport Room Officer-in-Charge</div>
                <div class='sig-subtitle'>Dept of Sport Sciences & Physical Education</div>
                <div class='sig-subtitle'>Date: ____________________</div>
            </td>
            <td class='sig-block'>
                <div class='stamp-box'>
                    Official Department Seal
                </div>
            </td>
        </tr>
    </table>

</body>
</html>";

                File.WriteAllText(fullPath, html, Encoding.UTF8);
                return fullPath;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Report generation failed: {ex.Message}");
                return string.Empty;
            }
        }
    }
}
