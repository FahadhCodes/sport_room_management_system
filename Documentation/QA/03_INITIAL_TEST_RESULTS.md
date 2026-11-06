# Automated QA Initial Test Execution Results

**Execution Timestamp:** 2026-11-06 19:08:07
**Environment:** Windows .NET 8.0 Windows | SQLite Relational Engine
**Total Tests Executed:** 44
**Passed:** 44
**Failed:** 0
**Pass Rate:** 100.0%
**Total Duration:** 3.92 seconds

---

## Test Results by Module

| Test ID | Module | Category | Test Name | Status | Duration (ms) | Details / Failure Reason |
|---|---|---|---|---|---:|---|
| **TC-MOD1-001** | Overview | Boundary | Calculate Accurate KPIs with Empty Database | ✅ PASS | 1241.7 | Verified successfully |
| **TC-MOD1-002** | Overview | Unit / Integration | True Total Stock Formula Validation | ✅ PASS | 336.1 | Verified successfully |
| **TC-MOD1-003** | Overview | Boundary | Newly Arrived Intake Filter (30 Days Boundary) | ✅ PASS | 74.9 | Verified successfully |
| **TC-MOD1-004** | Overview | Functional | Multi-Criteria Status Filter: Overdue Detection | ✅ PASS | 79.4 | Verified successfully |
| **TC-MOD1-005** | Overview | Functional | Multi-Criteria Status Filter: Returned Late Detection | ✅ PASS | 63.6 | Verified successfully |
| **TC-MOD1-006** | Overview | Negative / Functional | Department Filter ALL Handling | ✅ PASS | 63.6 | Verified successfully |
| **TC-MOD2-001** | Inventory | Functional | Equipment Unique Types Count | ✅ PASS | 85.9 | Verified successfully |
| **TC-MOD2-002** | Inventory | Unit / Integration | Healthy Stock vs Total Stock Aggregation | ✅ PASS | 63.9 | Verified successfully |
| **TC-MOD2-003** | Inventory | Functional | Search Filter by Equipment Name Case-Insensitive | ✅ PASS | 86.6 | Verified successfully |
| **TC-MOD2-004** | Inventory | Boundary | Category Filter with All Categories | ✅ PASS | 76.0 | Verified successfully |
| **TC-MOD3-001** | Setup | Negative | New Supplier Validation Empty Input | ✅ PASS | 0.3 | Verified successfully |
| **TC-MOD3-002** | Setup | Unit | New Category Unique ID Prefix | ✅ PASS | 0.4 | Verified successfully |
| **TC-MOD3-003** | Setup | Integration | New Equipment Creation with Category FK | ✅ PASS | 101.3 | Verified successfully |
| **TC-MOD3-004** | Setup | Boundary | Equipment Auto-Generated ID and Defaults | ✅ PASS | 89.6 | Verified successfully |
| **TC-MOD4-001** | Supplier | Boundary | Supplier Summary with Zero Supplied Items | ✅ PASS | 95.6 | Verified successfully |
| **TC-MOD4-002** | Supplier | Negative | Non-Existent Supplier ID Null Safety | ✅ PASS | 70.8 | Verified successfully |
| **TC-MOD4-003** | Supplier | Functional | Supplier Intake Date Range Filtering | ✅ PASS | 100.1 | Verified successfully |
| **TC-MOD4-004** | Supplier | Integration | ManageSupplier Stock Modification Sync | ✅ PASS | 68.5 | Verified successfully |
| **TC-MOD4-005** | Supplier | Functional | ManageSupplier Delete History with Stock Deduction | ✅ PASS | 85.2 | Verified successfully |
| **TC-MOD4-006** | Supplier | Functional | ManageSupplier Delete History without Stock Deduction | ✅ PASS | 57.9 | Verified successfully |
| **TC-MOD5-001** | Intake | Integration | Batch Intake Simultaneous Equipment Stock & History Update | ✅ PASS | 71.4 | Verified successfully |
| **TC-MOD5-002** | Intake | Negative / Boundary | Intake Null Supplier Handling | ✅ PASS | 77.7 | Verified successfully |
| **TC-MOD5-003** | Intake | Functional | Zero Quantity Intake Row Skipping | ✅ PASS | 0.2 | Verified successfully |
| **TC-MOD6-001** | Borrower / Loan | Unit | Borrower Role Staff Auto-Generated ID | ✅ PASS | 0.2 | Verified successfully |
| **TC-MOD6-002** | Borrower / Loan | Unit | Borrower Role Student Manual ID | ✅ PASS | 0.1 | Verified successfully |
| **TC-MOD6-003** | Borrower / Loan | Integration | Loan Stock Deduction on Checkout | ✅ PASS | 122.0 | Verified successfully |
| **TC-MOD6-004** | Borrower / Loan | Negative / Boundary | Out of Stock Checkout Prevention | ✅ PASS | 0.2 | Verified successfully |
| **TC-MOD6-005** | Borrower / Loan | Boundary | Aggregated Multi-Row Same Equipment Stock Validation | ✅ PASS | 3.3 | Verified successfully |
| **TC-MOD6-006** | Borrower / Loan | Integration | Receipt Return Restocks Inventory | ✅ PASS | 61.4 | Verified successfully |
| **TC-MOD6-007** | Borrower / Loan | Negative | Prevent Duplicate Restock on Already Returned Receipt | ✅ PASS | 72.6 | Verified successfully |
| **TC-MOD6-008** | Borrower / Loan | Integration | BorrowerForm Return Checkbox Uncheck Deducts Stock | ✅ PASS | 79.9 | Verified successfully |
| **TC-MOD6-009** | Borrower / Loan | Functional / Math | Return with Damaged Items Correct Stock Split | ✅ PASS | 78.4 | Verified successfully |
| **TC-MOD6-010** | Borrower / Loan | Functional / Math | Uncheck Return with Damaged Items Reverses Correctly | ✅ PASS | 60.1 | Verified successfully |
| **TC-MOD6-011** | Borrower / Loan | Functional / Math | ManageBorrower Active Loan Quantity Change Adjusts Shelf Stock | ✅ PASS | 81.9 | Verified successfully |
| **TC-MOD6-012** | Borrower / Loan | Functional / Math | ManageBorrower Returned Loan Edit Adjusts Stock and Broken | ✅ PASS | 79.2 | Verified successfully |
| **TC-MOD6-013** | Borrower / Loan | Boundary / Validation | AddBorrowers Validation Rejects Negative or Contradictory Quantities | ✅ PASS | 0.2 | Verified successfully |
| **TC-MOD6-014** | Borrower / Loan | Math / Architecture | Inventory Conservation of Physical Stock Across Full Lifecycle | ✅ PASS | 75.3 | Verified successfully |
| **TC-MOD7-001** | Domain Model | Unit | BorrowReceipt UpdateStatus: Active Loan | ✅ PASS | 0.2 | Verified successfully |
| **TC-MOD7-002** | Domain Model | Unit | BorrowReceipt UpdateStatus: Overdue Loan | ✅ PASS | 0.1 | Verified successfully |
| **TC-MOD7-003** | Domain Model | Unit | BorrowReceipt UpdateStatus: On-Time Return | ✅ PASS | 0.2 | Verified successfully |
| **TC-MOD7-004** | Domain Model | Unit | BorrowReceipt UpdateStatus: Late Return | ✅ PASS | 0.2 | Verified successfully |
| **TC-MOD8-001** | DB Integrity | DB Integrity | Foreign Key Cascade Delete: Category Deletion | ✅ PASS | 65.7 | Verified successfully |
| **TC-MOD8-002** | DB Integrity | Negative | Foreign Key Constraint: Invalid DepartmentId on Borrower | ✅ PASS | 76.0 | Verified successfully |
| **TC-MOD8-003** | DB Integrity | Negative | Foreign Key Constraint: IntakeItem Supplier FK | ✅ PASS | 59.6 | Verified successfully |
