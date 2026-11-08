# Automated QA Initial Test Execution Results

**Execution Timestamp:** 2026-11-08 10:14:08
**Environment:** Windows .NET 8.0 Windows | SQLite Relational Engine
**Total Tests Executed:** 46
**Passed:** 46
**Failed:** 0
**Pass Rate:** 100.0%
**Total Duration:** 9.57 seconds

---

## Test Results by Module

| Test ID | Module | Category | Test Name | Status | Duration (ms) | Details / Failure Reason |
|---|---|---|---|---|---:|---|
| **TC-MOD1-001** | Overview | Boundary | Calculate Accurate KPIs with Empty Database | ✅ PASS | 3467.8 | Verified successfully |
| **TC-MOD1-002** | Overview | Unit / Integration | True Total Stock Formula Validation | ✅ PASS | 875.1 | Verified successfully |
| **TC-MOD1-003** | Overview | Boundary | Newly Arrived Intake Filter (30 Days Boundary) | ✅ PASS | 190.6 | Verified successfully |
| **TC-MOD1-004** | Overview | Functional | Multi-Criteria Status Filter: Overdue Detection | ✅ PASS | 210.7 | Verified successfully |
| **TC-MOD1-005** | Overview | Functional | Multi-Criteria Status Filter: Returned Late Detection | ✅ PASS | 122.5 | Verified successfully |
| **TC-MOD1-006** | Overview | Negative / Functional | Department Filter ALL Handling | ✅ PASS | 151.8 | Verified successfully |
| **TC-MOD2-001** | Inventory | Functional | Equipment Unique Types Count | ✅ PASS | 282.9 | Verified successfully |
| **TC-MOD2-002** | Inventory | Unit / Integration | Healthy Stock vs Total Stock Aggregation | ✅ PASS | 169.5 | Verified successfully |
| **TC-MOD2-003** | Inventory | Functional | Search Filter by Equipment Name Case-Insensitive | ✅ PASS | 184.4 | Verified successfully |
| **TC-MOD2-004** | Inventory | Boundary | Category Filter with All Categories | ✅ PASS | 165.3 | Verified successfully |
| **TC-MOD2-005** | Inventory | Functional / Integration | Direct Equipment Stock Edit Healthy and Damaged Quantities | ✅ PASS | 171.9 | Verified successfully |
| **TC-MOD3-001** | Setup | Negative | New Supplier Validation Empty Input | ✅ PASS | 0.4 | Verified successfully |
| **TC-MOD3-002** | Setup | Unit | New Category Unique ID Prefix | ✅ PASS | 0.6 | Verified successfully |
| **TC-MOD3-003** | Setup | Integration | New Equipment Creation with Category FK | ✅ PASS | 157.0 | Verified successfully |
| **TC-MOD3-004** | Setup | Boundary | Equipment Auto-Generated ID and Defaults | ✅ PASS | 123.2 | Verified successfully |
| **TC-MOD4-001** | Supplier | Boundary | Supplier Summary with Zero Supplied Items | ✅ PASS | 125.6 | Verified successfully |
| **TC-MOD4-002** | Supplier | Negative | Non-Existent Supplier ID Null Safety | ✅ PASS | 108.7 | Verified successfully |
| **TC-MOD4-003** | Supplier | Functional | Supplier Intake Date Range Filtering | ✅ PASS | 121.5 | Verified successfully |
| **TC-MOD4-004** | Supplier | Integration | ManageSupplier Stock Modification Sync | ✅ PASS | 147.5 | Verified successfully |
| **TC-MOD4-005** | Supplier | Functional | ManageSupplier Delete History with Stock Deduction | ✅ PASS | 142.4 | Verified successfully |
| **TC-MOD4-006** | Supplier | Functional | ManageSupplier Delete History without Stock Deduction | ✅ PASS | 130.5 | Verified successfully |
| **TC-MOD5-001** | Intake | Integration | Batch Intake Simultaneous Equipment Stock & History Update | ✅ PASS | 137.8 | Verified successfully |
| **TC-MOD5-002** | Intake | Negative / Boundary | Intake Null Supplier Handling | ✅ PASS | 188.6 | Verified successfully |
| **TC-MOD5-003** | Intake | Functional | Zero Quantity Intake Row Skipping | ✅ PASS | 0.3 | Verified successfully |
| **TC-MOD6-001** | Borrower / Loan | Unit | Borrower Role Staff Auto-Generated ID | ✅ PASS | 0.6 | Verified successfully |
| **TC-MOD6-002** | Borrower / Loan | Unit | Borrower Role Student Manual ID | ✅ PASS | 0.4 | Verified successfully |
| **TC-MOD6-003** | Borrower / Loan | Integration | Loan Stock Deduction on Checkout | ✅ PASS | 280.0 | Verified successfully |
| **TC-MOD6-004** | Borrower / Loan | Negative / Boundary | Out of Stock Checkout Prevention | ✅ PASS | 0.4 | Verified successfully |
| **TC-MOD6-005** | Borrower / Loan | Boundary | Aggregated Multi-Row Same Equipment Stock Validation | ✅ PASS | 13.7 | Verified successfully |
| **TC-MOD6-006** | Borrower / Loan | Integration | Receipt Return Restocks Inventory | ✅ PASS | 191.7 | Verified successfully |
| **TC-MOD6-007** | Borrower / Loan | Negative | Prevent Duplicate Restock on Already Returned Receipt | ✅ PASS | 192.4 | Verified successfully |
| **TC-MOD6-008** | Borrower / Loan | Integration | BorrowerForm Return Checkbox Uncheck Deducts Stock | ✅ PASS | 150.1 | Verified successfully |
| **TC-MOD6-009** | Borrower / Loan | Functional / Math | Return with Damaged Items Correct Stock Split | ✅ PASS | 225.4 | Verified successfully |
| **TC-MOD6-010** | Borrower / Loan | Functional / Math | Uncheck Return with Damaged Items Reverses Correctly | ✅ PASS | 117.8 | Verified successfully |
| **TC-MOD6-011** | Borrower / Loan | Functional / Math | ManageBorrower Active Loan Quantity Change Adjusts Shelf Stock | ✅ PASS | 128.0 | Verified successfully |
| **TC-MOD6-012** | Borrower / Loan | Functional / Math | ManageBorrower Returned Loan Edit Adjusts Stock and Broken | ✅ PASS | 139.0 | Verified successfully |
| **TC-MOD6-013** | Borrower / Loan | Boundary / Validation | AddBorrowers Validation Rejects Negative or Contradictory Quantities | ✅ PASS | 0.3 | Verified successfully |
| **TC-MOD6-014** | Borrower / Loan | Math / Architecture | Inventory Conservation of Physical Stock Across Full Lifecycle | ✅ PASS | 146.3 | Verified successfully |
| **TC-MOD7-001** | Domain Model | Unit | BorrowReceipt UpdateStatus: Active Loan | ✅ PASS | 0.3 | Verified successfully |
| **TC-MOD7-002** | Domain Model | Unit | BorrowReceipt UpdateStatus: Overdue Loan | ✅ PASS | 0.3 | Verified successfully |
| **TC-MOD7-003** | Domain Model | Unit | BorrowReceipt UpdateStatus: On-Time Return | ✅ PASS | 0.4 | Verified successfully |
| **TC-MOD7-004** | Domain Model | Unit | BorrowReceipt UpdateStatus: Late Return | ✅ PASS | 0.3 | Verified successfully |
| **TC-MOD8-001** | DB Integrity | DB Integrity | Foreign Key Cascade Delete: Category Deletion | ✅ PASS | 132.8 | Verified successfully |
| **TC-MOD8-002** | DB Integrity | Negative | Foreign Key Constraint: Invalid DepartmentId on Borrower | ✅ PASS | 110.4 | Verified successfully |
| **TC-MOD8-003** | DB Integrity | Negative | Foreign Key Constraint: IntakeItem Supplier FK | ✅ PASS | 143.2 | Verified successfully |
| **TC-MOD8-004** | DB Integrity | Functional / DB Integrity | SQLite Online Backup VACUUM INTO Snapshot Integrity | ✅ PASS | 199.2 | Verified successfully |
