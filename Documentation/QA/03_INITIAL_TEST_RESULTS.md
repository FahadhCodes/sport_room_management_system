# Automated QA Initial Test Execution Results

**Execution Timestamp:** 2026-11-06 23:02:26
**Environment:** Windows .NET 8.0 Windows | SQLite Relational Engine
**Total Tests Executed:** 45
**Passed:** 45
**Failed:** 0
**Pass Rate:** 100.0%
**Total Duration:** 4.08 seconds

---

## Test Results by Module

| Test ID | Module | Category | Test Name | Status | Duration (ms) | Details / Failure Reason |
|---|---|---|---|---|---:|---|
| **TC-MOD1-001** | Overview | Boundary | Calculate Accurate KPIs with Empty Database | ✅ PASS | 1133.0 | Verified successfully |
| **TC-MOD1-002** | Overview | Unit / Integration | True Total Stock Formula Validation | ✅ PASS | 355.5 | Verified successfully |
| **TC-MOD1-003** | Overview | Boundary | Newly Arrived Intake Filter (30 Days Boundary) | ✅ PASS | 117.5 | Verified successfully |
| **TC-MOD1-004** | Overview | Functional | Multi-Criteria Status Filter: Overdue Detection | ✅ PASS | 96.9 | Verified successfully |
| **TC-MOD1-005** | Overview | Functional | Multi-Criteria Status Filter: Returned Late Detection | ✅ PASS | 66.6 | Verified successfully |
| **TC-MOD1-006** | Overview | Negative / Functional | Department Filter ALL Handling | ✅ PASS | 74.0 | Verified successfully |
| **TC-MOD2-001** | Inventory | Functional | Equipment Unique Types Count | ✅ PASS | 84.5 | Verified successfully |
| **TC-MOD2-002** | Inventory | Unit / Integration | Healthy Stock vs Total Stock Aggregation | ✅ PASS | 65.0 | Verified successfully |
| **TC-MOD2-003** | Inventory | Functional | Search Filter by Equipment Name Case-Insensitive | ✅ PASS | 67.7 | Verified successfully |
| **TC-MOD2-004** | Inventory | Boundary | Category Filter with All Categories | ✅ PASS | 75.9 | Verified successfully |
| **TC-MOD2-005** | Inventory | Functional / Integration | Direct Equipment Stock Edit Healthy and Damaged Quantities | ✅ PASS | 83.3 | Verified successfully |
| **TC-MOD3-001** | Setup | Negative | New Supplier Validation Empty Input | ✅ PASS | 0.2 | Verified successfully |
| **TC-MOD3-002** | Setup | Unit | New Category Unique ID Prefix | ✅ PASS | 0.3 | Verified successfully |
| **TC-MOD3-003** | Setup | Integration | New Equipment Creation with Category FK | ✅ PASS | 75.3 | Verified successfully |
| **TC-MOD3-004** | Setup | Boundary | Equipment Auto-Generated ID and Defaults | ✅ PASS | 60.9 | Verified successfully |
| **TC-MOD4-001** | Supplier | Boundary | Supplier Summary with Zero Supplied Items | ✅ PASS | 90.7 | Verified successfully |
| **TC-MOD4-002** | Supplier | Negative | Non-Existent Supplier ID Null Safety | ✅ PASS | 66.7 | Verified successfully |
| **TC-MOD4-003** | Supplier | Functional | Supplier Intake Date Range Filtering | ✅ PASS | 70.0 | Verified successfully |
| **TC-MOD4-004** | Supplier | Integration | ManageSupplier Stock Modification Sync | ✅ PASS | 85.6 | Verified successfully |
| **TC-MOD4-005** | Supplier | Functional | ManageSupplier Delete History with Stock Deduction | ✅ PASS | 89.2 | Verified successfully |
| **TC-MOD4-006** | Supplier | Functional | ManageSupplier Delete History without Stock Deduction | ✅ PASS | 67.6 | Verified successfully |
| **TC-MOD5-001** | Intake | Integration | Batch Intake Simultaneous Equipment Stock & History Update | ✅ PASS | 79.3 | Verified successfully |
| **TC-MOD5-002** | Intake | Negative / Boundary | Intake Null Supplier Handling | ✅ PASS | 95.8 | Verified successfully |
| **TC-MOD5-003** | Intake | Functional | Zero Quantity Intake Row Skipping | ✅ PASS | 0.2 | Verified successfully |
| **TC-MOD6-001** | Borrower / Loan | Unit | Borrower Role Staff Auto-Generated ID | ✅ PASS | 0.2 | Verified successfully |
| **TC-MOD6-002** | Borrower / Loan | Unit | Borrower Role Student Manual ID | ✅ PASS | 0.1 | Verified successfully |
| **TC-MOD6-003** | Borrower / Loan | Integration | Loan Stock Deduction on Checkout | ✅ PASS | 93.7 | Verified successfully |
| **TC-MOD6-004** | Borrower / Loan | Negative / Boundary | Out of Stock Checkout Prevention | ✅ PASS | 0.2 | Verified successfully |
| **TC-MOD6-005** | Borrower / Loan | Boundary | Aggregated Multi-Row Same Equipment Stock Validation | ✅ PASS | 2.6 | Verified successfully |
| **TC-MOD6-006** | Borrower / Loan | Integration | Receipt Return Restocks Inventory | ✅ PASS | 77.1 | Verified successfully |
| **TC-MOD6-007** | Borrower / Loan | Negative | Prevent Duplicate Restock on Already Returned Receipt | ✅ PASS | 68.1 | Verified successfully |
| **TC-MOD6-008** | Borrower / Loan | Integration | BorrowerForm Return Checkbox Uncheck Deducts Stock | ✅ PASS | 71.7 | Verified successfully |
| **TC-MOD6-009** | Borrower / Loan | Functional / Math | Return with Damaged Items Correct Stock Split | ✅ PASS | 94.8 | Verified successfully |
| **TC-MOD6-010** | Borrower / Loan | Functional / Math | Uncheck Return with Damaged Items Reverses Correctly | ✅ PASS | 65.0 | Verified successfully |
| **TC-MOD6-011** | Borrower / Loan | Functional / Math | ManageBorrower Active Loan Quantity Change Adjusts Shelf Stock | ✅ PASS | 89.4 | Verified successfully |
| **TC-MOD6-012** | Borrower / Loan | Functional / Math | ManageBorrower Returned Loan Edit Adjusts Stock and Broken | ✅ PASS | 94.4 | Verified successfully |
| **TC-MOD6-013** | Borrower / Loan | Boundary / Validation | AddBorrowers Validation Rejects Negative or Contradictory Quantities | ✅ PASS | 0.1 | Verified successfully |
| **TC-MOD6-014** | Borrower / Loan | Math / Architecture | Inventory Conservation of Physical Stock Across Full Lifecycle | ✅ PASS | 128.9 | Verified successfully |
| **TC-MOD7-001** | Domain Model | Unit | BorrowReceipt UpdateStatus: Active Loan | ✅ PASS | 0.3 | Verified successfully |
| **TC-MOD7-002** | Domain Model | Unit | BorrowReceipt UpdateStatus: Overdue Loan | ✅ PASS | 0.3 | Verified successfully |
| **TC-MOD7-003** | Domain Model | Unit | BorrowReceipt UpdateStatus: On-Time Return | ✅ PASS | 0.3 | Verified successfully |
| **TC-MOD7-004** | Domain Model | Unit | BorrowReceipt UpdateStatus: Late Return | ✅ PASS | 0.3 | Verified successfully |
| **TC-MOD8-001** | DB Integrity | DB Integrity | Foreign Key Cascade Delete: Category Deletion | ✅ PASS | 103.5 | Verified successfully |
| **TC-MOD8-002** | DB Integrity | Negative | Foreign Key Constraint: Invalid DepartmentId on Borrower | ✅ PASS | 83.5 | Verified successfully |
| **TC-MOD8-003** | DB Integrity | Negative | Foreign Key Constraint: IntakeItem Supplier FK | ✅ PASS | 97.0 | Verified successfully |
