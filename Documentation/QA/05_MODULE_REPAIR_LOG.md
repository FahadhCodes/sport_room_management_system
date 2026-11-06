# QA Module Repair Log

**Project:** Sport Room Management System  
**Audit Standard:** ISO/IEC/IEEE 29119 Software Testing Standards  
**Last Updated:** 2026-11-05  

---

## Repair Verification Summary

| Module | Finding ID | Severity | Root Cause | Changed Files | Status |
|---|---|---|---|---|---|
| **Database / Lending Layer** | DEF-001 | **CRITICAL** | Shadow foreign key `BorrowReceiptReceiptId` was created because `ReceiptId` lacked `[ForeignKey]` attribute, leaving `ReceiptId` null and failing SQLite NOT NULL constraint | `Project Sport Room/Models/BorrowedCombination.cs` | **FIXED AND VERIFIED** |
| **Intake / Supplier Layer** | DEF-002 | **HIGH** | `SupplierId` was non-nullable in `IntakeItem.cs`, failing SQLite NOT NULL constraint on records without a supplier | `Project Sport Room/Models/IntakeItem.cs` | **FIXED AND VERIFIED** |
| **Supplier Module** | DEF-003 | **HIGH** | Unchecked `.FirstOrDefault().PhoneNumber` and `.Id` dereferenced without null check | `Project Sport Room/Forms/SupplierForm.cs` | **FIXED AND VERIFIED** |
| **Supplier Module** | DEF-004 | **HIGH** | Unchecked `Suppliers.FirstOrDefault().PhoneNumber` dereference in `manageSupplier` | `Project Sport Room/Forms/manageSupplier.cs` | **FIXED AND VERIFIED** |
| **Borrower Module** | DEF-005 | **HIGH** | `manageBorrower.cs` saved changes to loan `ReturnedDate` and `Qty` without adjusting master equipment shelf stock | `Project Sport Room/Forms/manageBorrower.cs` | **FIXED AND VERIFIED** |
| **Borrower Module** | DEF-006 | **MEDIUM** | Form-level long-lived `_db` context kept open across form lifecycle | `Project Sport Room/Forms/manageBorrower.cs` | **FIXED AND VERIFIED** |
| **Cross-Module** | DEF-007 | **MEDIUM** | Empty catch blocks silently swallowed database and UI exceptions | `Project Sport Room/Forms/SupplierForm.cs`, `Project Sport Room/Forms/Add.cs` | **FIXED AND VERIFIED** |
| **Supplier Module** | DEF-008 | **MEDIUM** | `SupplierForm_Load` executed duplicate supplier query before calling `LoadAllSuppliers` | `Project Sport Room/Forms/SupplierForm.cs` | **FIXED AND VERIFIED** |
| **Intake Module** | DEF-010 | **MEDIUM** | Unchecked `data.Supplier.Name` projection in `newIntake.cs` | `Project Sport Room/Forms/newIntake.cs` | **FIXED AND VERIFIED** |
| **Intake / Inventory** | DEF-011 | **HIGH** | `addNewIntake.cs` added total batch (healthy + damaged) to `Equipment.Quantity` (healthy stock), counting damaged items twice | `Project Sport Room/Forms/addNewIntake.cs`, `Project Sport Room/Forms/manageSupplier.cs` | **FIXED AND VERIFIED** |
| **Borrower / Lending** | DEF-012 | **HIGH** | Loan return logic added all borrowed units to `Equipment.Quantity` without splitting damaged units into `BrokenQty` | `Project Sport Room/Forms/BorrowerForm.cs`, `Project Sport Room/Forms/manageBorrower.cs` | **FIXED AND VERIFIED** |
| **Borrower / Lending** | DEF-013 | **HIGH** | Modifying borrowed equipment quantity in `manageBorrower.cs` did not adjust master shelf stock | `Project Sport Room/Forms/manageBorrower.cs` | **FIXED AND VERIFIED** |
| **Validation / Bounds** | DEF-014 | **MEDIUM** | Negative or contradictory quantities allowed in borrow and intake forms | `Project Sport Room/Forms/addBorrowers.cs`, `Project Sport Room/Forms/addNewIntake.cs`, `Project Sport Room/Forms/manageSupplier.cs` | **FIXED AND VERIFIED** |

---

## Detailed Repair Records

### Module 1: Database & Relational Layer (`BorrowedCombination.cs`, `IntakeItem.cs`)
- **Original Behavior:** Loans created by assigning `combo.BorrowReceipt = receipt` failed SQLite save changes with `SQLite Error 19: 'NOT NULL constraint failed: BorrowedCombinations.ReceiptId'`.
- **Root Cause:** EF Core created a shadow foreign key column `BorrowReceiptReceiptId`, leaving the explicit `ReceiptId` property unpopulated.
- **Repair:**
  - Added `[ForeignKey(nameof(BorrowReceipt))]` to `ReceiptId`.
  - Added `[ForeignKey(nameof(Equipment))]` to `EquipmentId`.
  - Added `[ForeignKey(nameof(Supplier))]` to `IntakeItem.SupplierId` with nullable type `string?`.
- **Verification:** TC-MOD1-002, TC-MOD1-004, TC-MOD1-005, TC-MOD1-006, TC-MOD2-002, TC-MOD5-002, TC-MOD6-003, TC-MOD6-006, TC-MOD6-007, TC-MOD6-008 passed 100%.

### Module 2: Supplier Module (`SupplierForm.cs`, `manageSupplier.cs`)
- **Original Behavior:** Loading suppliers or viewing an invalid/empty supplier list resulted in potential crashes (`NullReferenceException`), empty catch blocks, and redundant DB queries.
- **Root Cause:** Missing null-conditional operators (`?.`), empty `catch (Exception ex) { }` blocks, and copy-pasted duplicate query code in `Form_Load`.
- **Repair:**
  - Standardized on safe navigation `supplier?.PhoneNumber ?? ""`.
  - Removed duplicated query in `SupplierForm_Load` and routed directly to `LoadAllSuppliers()`.
  - Added meaningful user-facing notifications on database errors.
- **Verification:** TC-MOD4-001, TC-MOD4-002, TC-MOD4-003, TC-MOD4-004, TC-MOD4-005, TC-MOD4-006 passed.

### Module 3: Borrower Profile Management (`manageBorrower.cs`)
- **Original Behavior:** Modifying receipt `ReturnedDate` in `manageBorrower` did not restock equipment shelf counts, causing stock discrepancies. Long-lived context risked stale tracking.
- **Root Cause:** `updateBtn_Click` only updated receipt header dates without checking state transitions or executing equipment stock adjustments.
- **Repair:**
  - Added return transition checks (`oldReturned == null && newReturned != null` -> restock; `oldReturned != null && newReturned == null` -> deduct).
  - Refactored all data operations to short-lived `using (var db = new SportRoomContext())` scopes.
- **Verification:** Full compilation without context disposal warnings and verified inventory consistency.

### Module 4: Intake & Inventory Stock Calculation (`addNewIntake.cs`, `manageSupplier.cs`)
- **Original Behavior:** In `addNewIntake.cs`, adding new equipment calculated healthy inventory incorrectly. For instance: 5 initial healthy + 3 damaged receiving 3 healthy + 5 damaged resulted in Healthy: 13, Damaged: 8 (instead of Healthy: 8, Damaged: 8).
- **Root Cause:** Line 115 added `row.HealthyQuantity + row.DamagedQuantity` to `equipment.Quantity` (which represents available healthy units), double-counting damaged items. A corresponding defect existed in `manageSupplier.cs` history deletion.
- **Repair:**
  - `addNewIntake.cs`: Changed `equipment.Quantity += (row.HealthyQuantity + row.DamagedQuantity);` to `equipment.Quantity += row.HealthyQuantity;`.
  - `manageSupplier.cs`: Recomputed `healthyQty = item.Quantity - item.BrokenQty` and deducted `healthyQty` from `equipment.Quantity` and `brokenQty` from `equipment.BrokenQty`.
- **Verification:** TC-MOD5-001 and TC-MOD4-005 passed in test suite. Inventory now accurately reflects `Healthy = 8, Damaged = 8`.

### Module 5: Damaged Item Restock Partitioning on Loan Return (`BorrowerForm.cs`, `manageBorrower.cs`)
- **Original Behavior:** When marking receipts returned, all items were added to `equipment.Quantity` (healthy shelf stock). Damaged items were never moved to `equipment.BrokenQty`. Additionally, `ReturnedQuantity` remained 0.
- **Root Cause:** Returning code directly added `combo.Qty` to `equipment.Quantity` without partitioning into healthy (`Qty - BrokenQty`) and broken (`BrokenQty`).
- **Repair:**
  - Standardized all return points (`ReturnPicker_SaveAndHide`, `borrowerInfoTB_CellDoubleClick`, and `manageBorrower.cs`) to add `healthy` to `equipment.Quantity` and `broken` to `equipment.BrokenQty`, and set `combo.ReturnedQuantity = combo.Qty`.
  - On cancellation/unchecking: deducted `healthy` from `equipment.Quantity` and `broken` from `equipment.BrokenQty`, and reset `combo.ReturnedQuantity = 0`.
- **Verification:** TC-MOD6-009, TC-MOD6-010, and TC-MOD6-014 passed. Stock is strictly conserved across entire borrow/return cycle.

### Module 6: Loan Quantity Editing & Bounds Validation (`manageBorrower.cs`, `addBorrowers.cs`, `addNewIntake.cs`, `manageSupplier.cs`)
- **Original Behavior:** Editing loan quantities in `manageBorrower.cs` changed database records without syncing inventory shelves. Negative numbers or contradictory quantities (`BrokenQty > Qty`) were accepted.
- **Root Cause:** Absence of differential stock update logic and missing input validations.
- **Repair:**
  - In `manageBorrower.cs`: Calculated difference between old and new quantity/broken quantity and synchronized with `Equipment` stock accordingly.
  - In `addBorrowers.cs`, `manageBorrower.cs`, `addNewIntake.cs`, `manageSupplier.cs`: Enforced non-negative inputs, positive borrowed quantities, and `BrokenQty <= Qty`.
- **Verification:** TC-MOD6-011, TC-MOD6-012, and TC-MOD6-013 passed.



