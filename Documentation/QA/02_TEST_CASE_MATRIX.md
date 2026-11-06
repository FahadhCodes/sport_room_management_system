# QA Comprehensive Test Case Matrix

**Project:** Sport Room Management System  
**Audit Standard:** ISO/IEC/IEEE 29119 Software Testing Standards  
**Target Environment:** Isolated Relational SQLite Test Database (Zero Production Impact)  
**Execution Status:** Complete (100% Pass Rate)  

---

## Status Legend
- **PASS**: Executed and verified expected result.
- **FAIL**: Executed and encountered assertion failure, unexpected error, or crash.
- **BLOCKED**: Execution blocked by prerequisite failure.
- **NOT RUN**: Defined test awaiting automated test runner execution.

---

## Test Cases & Execution Evidence

| Test ID | Module | Test Name | Category | Preconditions | Steps | Expected Result | Status | Severity | Evidence |
|---|---|---|---|---|---|---|---|---|---|
| **TC-MOD1-001** | Overview | Calculate Accurate KPIs with Empty Database | Boundary | Isolated fresh test database | Query total, available, damaged, borrowed, and 30-day intake on empty DB | All KPIs return 0 without throwing null or format exceptions | **PASS** | HIGH | Automated Test Runner (1500.8ms) |
| **TC-MOD1-002** | Overview | True Total Stock Formula Validation | Unit / Integration | Seeded DB with healthy, damaged, and borrowed items | Seed 10 healthy, 2 damaged, 3 active loans. Compute Total stock. | Total = Available (10) + Damaged (2) + Borrowed (3) = 15 | **PASS** | CRITICAL | Automated Test Runner (461.1ms) |
| **TC-MOD1-003** | Overview | Newly Arrived Intake Filter (30 Days Boundary) | Boundary | Seed intake records: 10 days ago, 31 days ago | Query newly arrived intake count | Only intakes >= DateTime.Now - 30 days are summed | **PASS** | MEDIUM | Automated Test Runner (83.5ms) |
| **TC-MOD1-004** | Overview | Multi-Criteria Status Filter: Overdue Detection | Functional | Loan with DueDate in past and ReturnedDate = null | Query grid with statusFilter = "Overdue" | Record is included and labeled "Overdue" | **PASS** | HIGH | Automated Test Runner (83.4ms) |
| **TC-MOD1-005** | Overview | Multi-Criteria Status Filter: Returned Late Detection | Functional | Loan with ReturnedDate > DueDate | Query grid with statusFilter = "Returned Late" | Record is included and labeled "Returned Late" | **PASS** | MEDIUM | Automated Test Runner (52.1ms) |
| **TC-MOD1-006** | Overview | Department Filter "ALL" Handling | Negative / Functional | Multiple borrowers across different departments | Apply department filter with Id = "ALL" | All transactions returned regardless of department | **PASS** | MEDIUM | Automated Test Runner (66.4ms) |
| **TC-MOD2-001** | Inventory | Equipment Unique Types Count | Functional | 3 distinct equipment records seeded | Query total unique equipment types | Returns 3 | **PASS** | MEDIUM | Automated Test Runner (88.5ms) |
| **TC-MOD2-002** | Inventory | Healthy Stock vs Total Stock Aggregation | Unit / Integration | Equipments with Quantity=20, BrokenQty=4, 5 borrowed | Compute totals | Available=20, Damaged=4, Borrowed=5, Total=29, Healthy=25 | **PASS** | CRITICAL | Automated Test Runner (65.9ms) |
| **TC-MOD2-003** | Inventory | Search Filter by Equipment Name Case-Insensitive | Functional | Seeded equipment "Basketball", "Tennis Racket" | Search text "basket" | Returns only "Basketball" | **PASS** | LOW | Automated Test Runner (65.6ms) |
| **TC-MOD2-004** | Inventory | Category Filter with "All Categories" | Boundary | Seeded items in "Balls", "Rackets" | Filter by "All Categories" | Returns all items across all categories | **PASS** | LOW | Automated Test Runner (55.9ms) |
| **TC-MOD3-001** | Setup (Add) | New Supplier Validation Empty Input | Negative | None | Attempt to create Supplier with empty name/phone | Validation rejected, no record added to database | **PASS** | HIGH | Automated Test Runner (0.1ms) |
| **TC-MOD3-002** | Setup (Add) | New Category Unique ID Prefix | Unit | None | Instantiate `new Category()` | ID begins with `CTGR_` and has 10 characters | **PASS** | MEDIUM | Automated Test Runner (0.2ms) |
| **TC-MOD3-003** | Setup (Add) | New Equipment Creation with Category FK | Integration | Existing Category in DB | Add equipment linking to CategoryId | Successfully saved; Category FK navigation works | **PASS** | HIGH | Automated Test Runner (110.7ms) |
| **TC-MOD3-004** | Setup (Add) | Equipment Auto-Generated ID and Defaults | Boundary | None | Create Equipment without specifying optional properties | ID starts with `EQP_`, Quantity defaults to 0, BrokenQty to 0 | **PASS** | HIGH | Automated Test Runner (69.9ms) |
| **TC-MOD4-001** | Supplier | Supplier Summary with Zero Supplied Items | Boundary | Supplier created with no intake history | Call updateSummary(supplierId) | Total supplied count is 0; no null dereference crash | **PASS** | HIGH | Automated Test Runner (62.5ms) |
| **TC-MOD4-002** | Supplier | Non-Existent Supplier ID Null Safety | Negative | DB with no suppliers matching "SUPP_INVALID" | Call updateSummary with invalid ID | Safe fallback or null check; no `NullReferenceException` | **PASS** | CRITICAL | Automated Test Runner (43.5ms) |
| **TC-MOD4-003** | Supplier | Supplier Intake Date Range Filtering | Functional | Intake items on 2026-01-01 and 2026-06-01 | Filter between 2026-05-01 and 2026-07-01 | Only 2026-06-01 item is returned | **PASS** | MEDIUM | Automated Test Runner (74.5ms) |
| **TC-MOD4-004** | Supplier | ManageSupplier Stock Modification Sync | Integration | Intake with Qty=10 (8 healthy, 2 broken). Update to 12 healthy, 3 broken. | Save changes | Equipment Quantity increased by +4, BrokenQty by +1; IntakeItem updated | **PASS** | CRITICAL | Automated Test Runner (60.9ms) |
| **TC-MOD4-005** | Supplier | ManageSupplier Delete History with Stock Deduction | Functional | Intake with 10 units. Delete with dialog choice = Yes. | Execute delete | Intake item removed from DB; Equipment Quantity reduced by 10 | **PASS** | HIGH | Automated Test Runner (72.1ms) |
| **TC-MOD4-006** | Supplier | ManageSupplier Delete History without Stock Deduction | Functional | Intake with 10 units. Delete with dialog choice = No. | Execute delete | Intake item removed from DB; Equipment Quantity remains unchanged | **PASS** | MEDIUM | Automated Test Runner (72.0ms) |
| **TC-MOD5-001** | Intake | Batch Intake Simultaneous Equipment Stock & History Update | Integration | Supplier "S1", Equipment "E1" (Qty=5, Broken=0) | Intake 10 healthy, 2 damaged via `addNewIntake` logic | Equipment.Quantity becomes 17, BrokenQty becomes 2; IntakeItem record created with SupplierId | **PASS** | CRITICAL | Automated Test Runner (84.1ms) |
| **TC-MOD5-002** | Intake | Intake Null Supplier Handling | Negative / Boundary | Legacy IntakeItem where SupplierId is null | Load Intake query projecting `data.Supplier.Name` | Handles null supplier gracefully without throwing null reference | **PASS** | HIGH | Automated Test Runner (87.5ms) |
| **TC-MOD5-003** | Intake | Zero Quantity Intake Row Skipping | Functional | User inputs row with 0 healthy and 0 damaged | Process intake batch | Row skipped; no zero-quantity log inserted | **PASS** | LOW | Automated Test Runner (0.5ms) |
| **TC-MOD6-001** | Borrower / Loan | Borrower Role Staff Auto-Generated ID | Unit | None | `new Borrower("Staff")` | ID starts with `STFF_` and is not null | **PASS** | HIGH | Automated Test Runner (0.4ms) |
| **TC-MOD6-002** | Borrower / Loan | Borrower Role Student Manual ID | Unit | Student ID = "ST12345" | `new Borrower("Student", "ST12345")` | BorrowerId equals "ST12345" | **PASS** | HIGH | Automated Test Runner (0.2ms) |
| **TC-MOD6-003** | Borrower / Loan | Loan Stock Deduction on Checkout | Integration | Equipment stock = 10 units. Student borrows 3 units. | Execute borrow transaction in `addBorrowers` | Equipment stock reduced to 7; `BorrowReceipt` and `BorrowedCombination` saved | **PASS** | CRITICAL | Automated Test Runner (81.1ms) |
| **TC-MOD6-004** | Borrower / Loan | Out of Stock Checkout Prevention | Negative / Boundary | Equipment stock = 2 units. Student requests 5 units. | Attempt borrow transaction | Transaction aborted; stock remains 2; error message returned | **PASS** | CRITICAL | Automated Test Runner (0.2ms) |
| **TC-MOD6-005** | Borrower / Loan | Aggregated Multi-Row Same Equipment Stock Validation | Boundary | Equipment stock = 5 units. Grid has row 1 with 3 units and row 2 with 3 units (total 6). | Attempt borrow transaction | System aggregates total demand (6 > 5) and rejects checkout | **PASS** | HIGH | Automated Test Runner (3.7ms) |
| **TC-MOD6-006** | Borrower / Loan | Receipt Return Restocks Inventory | Integration | Active loan of 4 units. Equipment stock currently 6 units. Mark receipt returned. | Execute return | Equipment stock replenished to 10; Receipt.ReturnedDate set; Status becomes "Returned" | **PASS** | CRITICAL | Automated Test Runner (64.4ms) |
| **TC-MOD6-007** | Borrower / Loan | Prevent Duplicate Restock on Already Returned Receipt | Negative | Receipt already marked returned. Return logic called again. | Attempt return | Equipment stock is not incremented a second time | **PASS** | HIGH | Automated Test Runner (57.5ms) |
| **TC-MOD6-008** | Borrower / Loan | BorrowerForm Return Checkbox Uncheck Deducts Stock | Integration | Previously returned receipt is unchecked | Execute uncheck logic | Receipt.ReturnedDate reset to null; Equipment stock deducted back down | **PASS** | HIGH | Automated Test Runner (58.9ms) |
| **TC-MOD7-001** | Domain Model | BorrowReceipt UpdateStatus: Active Loan | Unit | IssuedDate = Now, DueDate = Tomorrow, ReturnedDate = null | `receipt.UpdateStatus()` | Status = "Borrowed" | **PASS** | MEDIUM | Automated Test Runner (0.2ms) |
| **TC-MOD7-002** | Domain Model | BorrowReceipt UpdateStatus: Overdue Loan | Unit | IssuedDate = 5 days ago, DueDate = 2 days ago, ReturnedDate = null | `receipt.UpdateStatus()` | Status = "Overdue" | **PASS** | MEDIUM | Automated Test Runner (0.1ms) |
| **TC-MOD7-003** | Domain Model | BorrowReceipt UpdateStatus: On-Time Return | Unit | DueDate = Today 5pm, ReturnedDate = Today 3pm | `receipt.UpdateStatus()` | Status = "Returned" | **PASS** | MEDIUM | Automated Test Runner (0.2ms) |
| **TC-MOD7-004** | Domain Model | BorrowReceipt UpdateStatus: Late Return | Unit | DueDate = Yesterday, ReturnedDate = Today | `receipt.UpdateStatus()` | Status = "Returned Late" | **PASS** | MEDIUM | Automated Test Runner (0.1ms) |
| **TC-MOD8-001** | DB Integrity | Foreign Key Cascade Delete: Category Deletion | DB Integrity | Category with linked Equipment | Delete Category | Linked Equipments deleted according to cascade rule | **PASS** | MEDIUM | Automated Test Runner (81.5ms) |
| **TC-MOD8-002** | DB Integrity | Foreign Key Constraint: Invalid DepartmentId on Borrower | Negative | Non-existent DepartmentId "DEP_NONE" | Attempt to insert Borrower | Foreign key constraint fails in relational database | **PASS** | HIGH | Automated Test Runner (80.0ms) |
| **TC-MOD8-003** | DB Integrity | Foreign Key Constraint: IntakeItem Supplier FK | Negative | Invalid SupplierId on IntakeItem | Attempt to insert IntakeItem | Foreign key constraint violation caught | **PASS** | HIGH | Automated Test Runner (58.4ms) |
