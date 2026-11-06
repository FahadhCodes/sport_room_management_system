# Sport Room Management System (SRMS)

[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/)
[![Windows Forms](https://img.shields.io/badge/UI-Windows%20Forms-brightgreen.svg)]()
[![EF Core](https://img.shields.io/badge/ORM-EF%20Core%208.0-purple.svg)]()
[![Database](https://img.shields.io/badge/Database-SQLite-lightgrey.svg)]()
[![QA Tests](https://img.shields.io/badge/Tests-44%2F44%20PASS-success.svg)]()

> Developed for the **Department of Sport Sciences and Physical Education**, Faculty of Applied Sciences, **Sabaragamuwa University of Sri Lanka (SUSL)**.

The **Sport Room Management System (SRMS)** is an enterprise desktop application designed to modernize, streamline, and audit physical sports inventory, student/staff loans, supplier procurement batches, and equipment condition tracking.

---

## 📌 Key Features

### 1. Executive Home Dashboard
- **System-Wide Real-Time KPIs**:
  - **Total Physical Stock**: Comprehensive stock conservation formula ($\text{Available} + \text{Damaged} + \text{Borrowed}$).
  - **Available on Shelf**: Healthy stock ready for loan.
  - **Currently Borrowed**: Equipment actively checked out by students and staff.
  - **Damaged Stock**: Items recorded as broken or unusable needing repair/condemnation.
  - **Catalog Types**: Total unique equipment models registered.
  - **Active & Overdue Loans**: Live counts of open receipts and overdue items.
  - **New Arrivals**: Intake equipment received within the past 30 days.
- **Interactive Damage Registry**: Real-time searchable DataGridView of all equipment with damaged stock, sorted by urgency.
- **Automatic Lifecycle Refresh**: Dynamically reloads and syncs fresh data whenever returning from any other module.

### 2. Loan Return & Equipment Condition Inspection
- **Dedicated Modal Inspection Dialog** (`ReturnInspectionDialog`):
  - Automatically loads loan items, borrower profile, and due dates upon return checkbox toggle.
  - Real-time stock calculation separating items into **Healthy Restocked**, **Damaged**, and **Lost / Unreturned**.
  - Built-in validation clamping: prevents negative quantities or values exceeding loan amounts.
  - Dynamic button feedback (green for standard restock; red for damage/loss detection).

### 3. Automated Official Report Generation
- **Print-Ready A4 HTML Reports**:
  - **Individual Loan Return & Damage Incident Slips**:
    - Auto-generated upon equipment return when damages or lost items are detected.
    - Embedded official Sabaragamuwa University of Sri Lanka logo as self-contained Base64 data URI (offline compatible).
    - Open "Nature of Defect / Officer's Remarks" column with ample row height for physical handwritten annotations.
    - Formal declaration and borrower & officer signature blocks.
  - **Comprehensive Equipment Damage, Loss & Deficiency Audit Report**:
    - Triggered via the `Generate Summaries Damage Report` action on the Home dashboard.
    - Executive summary KPI cards with color-coded severity metrics.
    - Category-wise distribution table with loss percentages.
    - Itemized deficiency registry with actionable audit recommendations (*Condemnation Board Write-Off*, *Borrower Surcharge*, *Repair & Restore*, *Urgent Procurement*).

### 4. Inventory & Category Management
- Categorized sports equipment database (Cricket, Football, Basketball, Track & Field, etc.).
- Complete physical conservation tracking ensuring stock balance consistency across loans, returns, and damages.

### 5. Borrower & Circulation Management
- Student and Staff registration with automatic/manual ID generation.
- Full loan checkout history, due date enforcement, and overdue tracking.
- Double-click receipt inspection and one-click return processing.

### 6. Supplier & Intake Tracking
- Track intake shipments from vendors with supply date, batch quantities, and supplier contact details.
- Real-time inventory replenishment syncing.

---

## 🛠️ Architecture & Tech Stack

- **Target Framework**: .NET 8.0 (`net8.0-windows`)
- **UI Framework**: Windows Forms (WinForms) with custom responsive styling
- **ORM**: Entity Framework Core 8.0.22 (`Microsoft.EntityFrameworkCore.Sqlite`)
- **Database**: SQLite (`sportroom.db`)
- **Design Standard**: Material & University Maroon `#7f1d1d` Palette
- **QA Standard**: ISO/IEC/IEEE 29119 Test Suites

---

## 📂 Project Structure

```text
├── Documentation/
│   └── QA/                     # QA test plans, specifications, and test results
├── Project Sport Room/
│   ├── Forms/
│   │   ├── Form1.cs            # Main navigation shell & workspace sidebar
│   │   ├── MainPanel.cs        # Home dashboard, KPIs, damage grid & summary report generator
│   │   ├── ReturnInspectionDialog.cs # Modal inspection & damage slip generator
│   │   ├── OverviewForm.cs     # Inventory circulation overview & multi-filter
│   │   ├── InventoryForm.cs    # Stock catalog & category management
│   │   ├── BorrowerForm.cs     # Borrower registry, loan checkout & receipts
│   │   ├── SupplierForm.cs     # Supplier directories & intake log
│   │   ├── newIntake.cs        # Intake operations
│   │   └── ...                 # Modal dialogs (Add, addBorrowers, etc.)
│   ├── Migrations/             # EF Core database migrations
│   ├── Models/                 # Domain entities (Equipment, BorrowReceipt, Borrower, etc.)
│   ├── Properties/             # Resources & designer assets
│   └── sportroom.db            # Local SQLite database
├── Tests/
│   └── Project_Sport_Room.TestRunner/ # Automated QA test runner (44 test cases)
├── .gitignore
├── README.md
└── Project Sport Room.sln
```

---

## 🚀 Getting Started

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- Visual Studio 2022 (v17.8+) with *.NET desktop development* workload, or Visual Studio Code with C# Dev Kit.

### Installation & Run

1. **Clone the repository**:
   ```bash
   git clone https://github.com/FahadhCodes/sport_room_management_system.git
   cd sport_room_management_system
   ```

2. **Restore dependencies & Build**:
   ```bash
   dotnet build "Project Sport Room/Project Sport Room.csproj"
   ```

3. **Run the Application**:
   ```bash
   dotnet run --project "Project Sport Room/Project Sport Room.csproj"
   ```

---

## 🧪 Automated Testing & Quality Assurance

The system includes an automated test runner conforming to **ISO/IEC/IEEE 29119** standards covering 8 domain modules:
- True Total Stock Conservation Formula
- Intake & Restock Lifecycle
- Borrower Loan Checkout, Overdue Detection & Stock Deductions
- Damage Split & Return Inspection Flow
- Database Foreign Key Integrity & Cascade Constraints

To execute the test runner:
```bash
dotnet run --project "Tests/Project_Sport_Room.TestRunner/Project_Sport_Room.TestRunner.csproj"
```

**Results**: `Total: 44 | Passed: 44 | Failed: 0 (100% Pass Rate)`

---

## 📜 License & Acknowledgments

- **Institution**: Sabaragamuwa University of Sri Lanka (SUSL)
- **Department**: Department of Sport Sciences and Physical Education, Faculty of Applied Sciences
- **Author**: [FahadhCodes](https://github.com/FahadhCodes)
