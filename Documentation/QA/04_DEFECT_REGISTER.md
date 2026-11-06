# QA Confirmed Defect Register

**Project:** Sport Room Management System  
**Audit Standard:** ISO/IEC/IEEE 29119 Software Testing Standards  
**Last Updated:** 2026-11-05  

---

## Severity Classification
- **CRITICAL**: Causes database exceptions, data corruption, crashes, or breaks core lending/inventory workflows.
- **HIGH**: Major functionality failure, unhandled runtime null reference exceptions, or stock desynchronization.
- **MEDIUM**: Architectural inconsistency, empty catch blocks, redundant database roundtrips, or performance bottlenecks.
- **LOW**: Dead code, unused controls, or minor formatting/maintainability issues.

---

## Defect Inventory

### DEF-001: Entity Relationship Foreign Key Shadow Property in `BorrowedCombination`
- **Module:** Database & Lending Layer (`BorrowedCombination.cs`)
- **Severity:** **CRITICAL**
- **Type:** EF Core / Relational Schema Bug
- **Status:** **CONFIRMED** (Reproduced in TC-MOD1-002, TC-MOD1-004, TC-MOD1-005, TC-MOD1-006, TC-MOD2-002, TC-MOD6-003, TC-MOD6-006, TC-MOD6-007, TC-MOD6-008)
- **Description:** In `BorrowedCombination.cs`, `ReceiptId` lacks explicit `[ForeignKey(nameof(BorrowReceipt))]`. EF Core generates a shadow foreign key column `BorrowReceiptReceiptId`, leaving `ReceiptId` as an unmapped non-nullable column. When `BorrowReceipt` navigation property is assigned, `ReceiptId` remains null, triggering SQLite Error 19 (`NOT NULL constraint failed: BorrowedCombinations.ReceiptId`).
- **Root Cause:** Missing `[ForeignKey]` attribute or fluent configuration linking `ReceiptId` to `BorrowReceipt`.
- **Recommended Fix:** Add `[ForeignKey(nameof(BorrowReceipt))]` above `public string ReceiptId { get; set; }` in `BorrowedCombination.cs`, and ensure both properties are set correctly.

---

### DEF-002: Non-Nullable `SupplierId` Property in `IntakeItem.cs`
- **Module:** Intake & Supplier Layer (`IntakeItem.cs`)
- **Severity:** **HIGH**
- **Type:** Relational Constraint Defect
- **Status:** **CONFIRMED** (Reproduced in TC-MOD5-002)
- **Description:** `SupplierId` in `IntakeItem.cs` is declared as `public string SupplierId { get; set; }` (non-nullable), while intake items may be created without a supplier (e.g. initial stock or legacy items). This enforces a SQLite `NOT NULL` constraint causing insert failure.
- **Root Cause:** Incomplete nullability specification on foreign key property.
- **Recommended Fix:** Change to `public string? SupplierId { get; set; }` and `public Supplier? Supplier { get; set; }`.

---

### DEF-003: Unhandled Null Reference Dereferences in `SupplierForm.cs`
- **Module:** Supplier Module (`SupplierForm.cs`)
- **Severity:** **HIGH**
- **Type:** Runtime Exception (`NullReferenceException`)
- **Status:** **CONFIRMED**
- **Description:**
  1. Lines 117-118: `supplierData.FirstOrDefault().PhoneNumber ?? ""` directly calls `.PhoneNumber` without checking if `FirstOrDefault()` is null. If an invalid or deleted supplier ID is passed, the application crashes immediately.
  2. Lines 38, 90: `suppliersList.FirstOrDefault().Id` directly dereferences `FirstOrDefault()`.
- **Root Cause:** Missing null-conditional (`?.`) or existence check on LINQ queries.
- **Recommended Fix:** Use safe null-conditional navigation: `supplierData.FirstOrDefault()?.PhoneNumber ?? ""`.

---

### DEF-004: Unhandled Null Reference Dereference in `manageSupplier.cs`
- **Module:** Supplier Module (`manageSupplier.cs`)
- **Severity:** **HIGH**
- **Type:** Runtime Exception (`NullReferenceException`)
- **Status:** **CONFIRMED**
- **Description:** Line 96: `phoneNO.Text = Suppliers.FirstOrDefault().PhoneNumber;` crashes with `NullReferenceException` if no supplier matching `supplierID` is found.
- **Root Cause:** Missing null-conditional check on query result.
- **Recommended Fix:** Change to `phoneNO.Text = Suppliers.FirstOrDefault()?.PhoneNumber ?? "";`.

---

### DEF-005: Stock Desynchronization during Receipt Edit in `manageBorrower.cs`
- **Module:** Borrower & Lending Management (`manageBorrower.cs`)
- **Severity:** **HIGH**
- **Type:** Business Logic & Stock Integrity Bug
- **Status:** **CONFIRMED**
- **Description:** When an administrator edits `ReturnedDate` or loan `Qty` in `manageBorrower` and clicks Save, the master equipment stock (`Equipment.Quantity`) is never adjusted. In contrast, `BorrowerForm.cs` properly adjusts stock when items are returned or un-returned.
- **Root Cause:** Incomplete update logic in `updateBtn_Click` that only writes to receipt headers without propagating stock changes to equipment shelf counts.
- **Recommended Fix:** Check whether `ReturnedDate` transition occurred (e.g. from null to set, or vice versa) and adjust corresponding `Equipment.Quantity` accordingly.

---

### DEF-006: Inconsistent Long-Lived `DbContext` Instance in `manageBorrower.cs`
- **Module:** Architecture & Database Context (`manageBorrower.cs`)
- **Severity:** **MEDIUM**
- **Type:** Architectural Defect / Concurrency Risk
- **Status:** **CONFIRMED**
- **Description:** `manageBorrower` maintains a single `_db` context instance field for the entire duration the dialog is open. If entities are modified in other forms while this dialog is open, stale data or entity tracking collision occurs.
- **Root Cause:** Legacy WinForms pattern storing context at class level.
- **Recommended Fix:** Refactor database operations to use short-lived `using (var db = new SportRoomContext())` scopes.

---

### DEF-007: Silent Exception Swallowing in `SupplierForm.cs` and `Add.cs`
- **Module:** Cross-Module Error Handling
- **Severity:** **MEDIUM**
- **Type:** Error Handling Defect
- **Status:** **CONFIRMED**
- **Description:**
  - `SupplierForm.cs` lines 42 and 94: `catch (Exception ex) { }` silently ignores database failures.
  - `Add.cs` line 49: `catch { }` silently swallows UI refresh exceptions.
- **Root Cause:** Empty catch blocks left during prototyping.
- **Recommended Fix:** Replace with structured logging or user-friendly `MessageBox.Show` notifications.

---

### DEF-008: Redundant Duplicate Database Queries on `SupplierForm_Load`
- **Module:** Performance & Query Optimization (`SupplierForm.cs`)
- **Severity:** **MEDIUM**
- **Type:** Performance Inefficiency
- **Status:** **CONFIRMED**
- **Description:** In `SupplierForm_Load`, lines 77-92 query `db.Suppliers` and bind `suppliersTb`. Line 95 then immediately calls `await LoadAllSuppliers()`, which runs the exact same query and binding a second time.
- **Root Cause:** Duplicate copy-pasted code during development.
- **Recommended Fix:** Remove the duplicated inline code and keep single clean call to `await LoadAllSuppliers()`.

---

### DEF-009: Orphaned Dead Code Files at Solution Root
- **Module:** Solution Cleanliness
- **Severity:** **LOW**
- **Type:** Code Quality
- **Status:** **CONFIRMED**
- **Description:** `Class1.cs` and `Equipment.cs` exist at the solution root folder outside the project file with incomplete or syntax-broken code snippets.
- **Root Cause:** Stray files created during initial project experimentation.
- **Recommended Fix:** Archive or remove unused root files to prevent developer confusion.

---

### DEF-011: Equipment Stock Calculation Defect in Batch Intake (`addNewIntake.cs` & `manageSupplier.cs`)
- **Module:** Intake & Inventory Stock Synchronization (`addNewIntake.cs`, `manageSupplier.cs`)
- **Severity:** **HIGH**
- **Type:** Business Logic / Calculation Bug
- **Status:** **RESOLVED & VERIFIED** (TC-MOD5-001, TC-MOD4-005)
- **Description:** When new equipment batches were submitted via `addNewIntake.cs`, the code updated `Equipment.Quantity` with `row.HealthyQuantity + row.DamagedQuantity` (total batch) instead of just `row.HealthyQuantity`. Simultaneously, `Equipment.BrokenQty` was increased by `row.DamagedQuantity`. Since `Equipment.Quantity` represents available healthy stock, the damaged items were counted twice: once in `Quantity` and once in `BrokenQty`. For example: initially 5 healthy and 3 damaged, receiving 3 healthy and 5 damaged caused `Quantity` = 5 + (3 + 5) = 13 (should be 8) and `BrokenQty` = 3 + 5 = 8. A symmetric deduction bug also existed in `manageSupplier.cs` history deletion.
- **Root Cause:** Conflation between total batch quantity (`IntakeItem.Quantity`) and available healthy shelf quantity (`Equipment.Quantity`).
- **Fix:**
  - `addNewIntake.cs`: Changed `equipment.Quantity += (row.HealthyQuantity + row.DamagedQuantity);` to `equipment.Quantity += row.HealthyQuantity;`.
  - `manageSupplier.cs`: Adjusted stock deduction to subtract `healthyQty` (`Quantity - BrokenQty`) from `equipment.Quantity` and `brokenQty` from `equipment.BrokenQty`.

---

### DEF-012: Damaged Equipment Return Stock Split Defect (`BorrowerForm.cs`, `manageBorrower.cs`)
- **Module:** Equipment Loan & Return Restocking (`BorrowerForm.cs`, `manageBorrower.cs`)
- **Severity:** **HIGH**
- **Type:** Business Logic / Mathematical Stock Inflation
- **Status:** **RESOLVED & VERIFIED** (TC-MOD6-009, TC-MOD6-010, TC-MOD6-014)
- **Description:** When marking a loan receipt as returned, all three return code paths (`ReturnPicker_SaveAndHide`, `borrowerInfoTB_CellDoubleClick`, and `manageBorrower.cs`) executed `equipment.Quantity += combo.Qty`. If `combo.BrokenQty > 0`, the damaged items were added directly to `equipment.Quantity` (available healthy shelf stock) instead of `equipment.BrokenQty`. This caused damaged equipment to convert into healthy equipment, inflating healthy stock while leaving damaged stock unrecorded. Additionally, `ReturnedQuantity` remained 0 instead of `combo.Qty`.
- **Root Cause:** Restock logic did not partition `combo.Qty` into `healthy = Qty - BrokenQty` and `broken = BrokenQty`.
- **Fix:**
  - On return: Add `healthy` to `equipment.Quantity`, add `broken` to `equipment.BrokenQty`, set `combo.ReturnedQuantity = combo.Qty`.
  - On uncheck/cancellation: Deduct `healthy` from `equipment.Quantity`, deduct `broken` from `equipment.BrokenQty`, reset `combo.ReturnedQuantity = 0`.

---

### DEF-013: Missing Stock Synchronization on Loan Editing (`manageBorrower.cs`)
- **Module:** Borrower & Loan Management (`manageBorrower.cs`)
- **Severity:** **HIGH**
- **Type:** Inventory Desynchronization
- **Status:** **RESOLVED & VERIFIED** (TC-MOD6-011, TC-MOD6-012)
- **Description:** In `manageBorrower.cs`, editing equipment quantities in `borrwedEquipmentTB` updated `dbCombo.Qty` and `dbCombo.BrokenQty` without adjusting `Equipment.Quantity` or `Equipment.BrokenQty`. If a borrower took 2 more items or returned 2 items early on an active loan, the master shelf stock was unchanged. If edited on a returned receipt, the returned inventory was desynchronized.
- **Root Cause:** Missing delta calculation between old and new combination quantities and lack of stock adjustment.
- **Fix:** Added differential stock updates: for active loans, `equipment.Quantity -= (newQty - oldQty)` with availability check; for returned loans, `equipment.Quantity += (newHealthy - oldHealthy)` and `equipment.BrokenQty += (newBroken - oldBroken)`.

---

### DEF-014: Missing Boundary Validations on Input Quantities (`addBorrowers.cs`, `addNewIntake.cs`, `manageSupplier.cs`)
- **Module:** Input Validation & Mathematical Bounds
- **Severity:** **MEDIUM**
- **Type:** Validation / Arithmetic Flaw
- **Status:** **RESOLVED & VERIFIED** (TC-MOD6-013)
- **Description:** Input fields allowed entering zero or negative borrowed quantities (`qty <= 0`), which inverted stock deductions (`Quantity -= (-5)` increased shelf stock). Damaged quantity could also be negative or exceed borrowed quantity (`bqty > qty`).
- **Root Cause:** Incomplete boundary validation checks on input parsing.
- **Fix:** Enforced `qty > 0`, `bqty >= 0`, `bqty <= qty` in `addBorrowers.cs` and `manageBorrower.cs`, and enforced non-negative quantities in `addNewIntake.cs` and `manageSupplier.cs`.



