# Automated QA Initial Test Execution Results

**Execution Timestamp:** 2026-11-05 14:20:26
**Environment:** Windows .NET 8.0 Windows | SQLite Relational Engine
**Total Tests Executed:** 38
**Passed:** 12
**Failed:** 26
**Pass Rate:** 31.6%
**Total Duration:** 3.52 seconds

---

## Test Results by Module

| Test ID | Module | Category | Test Name | Status | Duration (ms) | Details / Failure Reason |
|---|---|---|---|---|---:|---|
| **TC-MOD1-001** | Overview | Boundary | Calculate Accurate KPIs with Empty Database | ❌ FAIL | 1475.2 | SQLite Error 1: 'no such table: Equipments'. |
| **TC-MOD1-002** | Overview | Unit / Integration | True Total Stock Formula Validation | ❌ FAIL | 314.8 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD1-003** | Overview | Boundary | Newly Arrived Intake Filter (30 Days Boundary) | ❌ FAIL | 67.6 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD1-004** | Overview | Functional | Multi-Criteria Status Filter: Overdue Detection | ❌ FAIL | 49.9 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD1-005** | Overview | Functional | Multi-Criteria Status Filter: Returned Late Detection | ❌ FAIL | 54.9 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD1-006** | Overview | Negative / Functional | Department Filter ALL Handling | ❌ FAIL | 58.3 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD2-001** | Inventory | Functional | Equipment Unique Types Count | ❌ FAIL | 69.7 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD2-002** | Inventory | Unit / Integration | Healthy Stock vs Total Stock Aggregation | ❌ FAIL | 97.1 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD2-003** | Inventory | Functional | Search Filter by Equipment Name Case-Insensitive | ❌ FAIL | 60.8 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD2-004** | Inventory | Boundary | Category Filter with All Categories | ❌ FAIL | 70.8 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD3-001** | Setup | Negative | New Supplier Validation Empty Input | ✅ PASS | 0.3 | Verified successfully |
| **TC-MOD3-002** | Setup | Unit | New Category Unique ID Prefix | ✅ PASS | 0.4 | Verified successfully |
| **TC-MOD3-003** | Setup | Integration | New Equipment Creation with Category FK | ❌ FAIL | 48.9 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD3-004** | Setup | Boundary | Equipment Auto-Generated ID and Defaults | ❌ FAIL | 58.7 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD4-001** | Supplier | Boundary | Supplier Summary with Zero Supplied Items | ❌ FAIL | 39.7 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD4-002** | Supplier | Negative | Non-Existent Supplier ID Null Safety | ❌ FAIL | 64.2 | SQLite Error 1: 'no such table: Suppliers'. |
| **TC-MOD4-003** | Supplier | Functional | Supplier Intake Date Range Filtering | ❌ FAIL | 48.1 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD4-004** | Supplier | Integration | ManageSupplier Stock Modification Sync | ❌ FAIL | 47.5 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD4-005** | Supplier | Functional | ManageSupplier Delete History with Stock Deduction | ❌ FAIL | 65.5 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD4-006** | Supplier | Functional | ManageSupplier Delete History without Stock Deduction | ❌ FAIL | 91.8 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD5-001** | Intake | Integration | Batch Intake Simultaneous Equipment Stock & History Update | ❌ FAIL | 73.1 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD5-002** | Intake | Negative / Boundary | Intake Null Supplier Handling | ❌ FAIL | 63.2 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD5-003** | Intake | Functional | Zero Quantity Intake Row Skipping | ✅ PASS | 0.2 | Verified successfully |
| **TC-MOD6-001** | Borrower / Loan | Unit | Borrower Role Staff Auto-Generated ID | ✅ PASS | 0.3 | Verified successfully |
| **TC-MOD6-002** | Borrower / Loan | Unit | Borrower Role Student Manual ID | ✅ PASS | 0.5 | Verified successfully |
| **TC-MOD6-003** | Borrower / Loan | Integration | Loan Stock Deduction on Checkout | ❌ FAIL | 69.9 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD6-004** | Borrower / Loan | Negative / Boundary | Out of Stock Checkout Prevention | ✅ PASS | 0.2 | Verified successfully |
| **TC-MOD6-005** | Borrower / Loan | Boundary | Aggregated Multi-Row Same Equipment Stock Validation | ✅ PASS | 10.1 | Verified successfully |
| **TC-MOD6-006** | Borrower / Loan | Integration | Receipt Return Restocks Inventory | ❌ FAIL | 60.3 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD6-007** | Borrower / Loan | Negative | Prevent Duplicate Restock on Already Returned Receipt | ❌ FAIL | 53.6 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD6-008** | Borrower / Loan | Integration | BorrowerForm Return Checkbox Uncheck Deducts Stock | ❌ FAIL | 60.8 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD7-001** | Domain Model | Unit | BorrowReceipt UpdateStatus: Active Loan | ✅ PASS | 0.3 | Verified successfully |
| **TC-MOD7-002** | Domain Model | Unit | BorrowReceipt UpdateStatus: Overdue Loan | ✅ PASS | 0.2 | Verified successfully |
| **TC-MOD7-003** | Domain Model | Unit | BorrowReceipt UpdateStatus: On-Time Return | ✅ PASS | 0.3 | Verified successfully |
| **TC-MOD7-004** | Domain Model | Unit | BorrowReceipt UpdateStatus: Late Return | ✅ PASS | 0.2 | Verified successfully |
| **TC-MOD8-001** | DB Integrity | DB Integrity | Foreign Key Cascade Delete: Category Deletion | ❌ FAIL | 73.5 | An error occurred while saving the entity changes. See the inner exception for details. |
| **TC-MOD8-002** | DB Integrity | Negative | Foreign Key Constraint: Invalid DepartmentId on Borrower | ✅ PASS | 121.4 | Verified successfully |
| **TC-MOD8-003** | DB Integrity | Negative | Foreign Key Constraint: IntakeItem Supplier FK | ❌ FAIL | 60.6 | An error occurred while saving the entity changes. See the inner exception for details. |

---

## Failed Tests Stack Traces & Diagnostic Logs

### [TC-MOD1-001] Overview - Calculate Accurate KPIs with Empty Database
- **Error Message:** `SQLite Error 1: 'no such table: Equipments'.`
- **Stack Trace:**
```text
   at Microsoft.Data.Sqlite.SqliteException.ThrowExceptionForRC(Int32 rc, sqlite3 db)
   at Microsoft.Data.Sqlite.SqliteCommand.PrepareAndEnumerateStatements()+MoveNext()
   at Microsoft.Data.Sqlite.SqliteCommand.GetStatements()+MoveNext()
   at Microsoft.Data.Sqlite.SqliteDataReader.NextResult()
   at Microsoft.Data.Sqlite.SqliteCommand.ExecuteReader(CommandBehavior behavior)
   at Microsoft.Data.Sqlite.SqliteCommand.ExecuteReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken)
   at Microsoft.Data.Sqlite.SqliteCommand.ExecuteDbDataReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Storage.RelationalCommand.ExecuteReaderAsync(RelationalCommandParameterObject parameterObject, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Storage.RelationalCommand.ExecuteReaderAsync(RelationalCommandParameterObject parameterObject, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Query.Internal.SingleQueryingEnumerable`1.AsyncEnumerator.InitializeReaderAsync(AsyncEnumerator enumerator, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Query.Internal.SingleQueryingEnumerable`1.AsyncEnumerator.MoveNextAsync()
   at Microsoft.EntityFrameworkCore.Query.ShapedQueryCompilingExpressionVisitor.SingleAsync[TSource](IAsyncEnumerable`1 asyncEnumerable, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Query.ShapedQueryCompilingExpressionVisitor.SingleAsync[TSource](IAsyncEnumerable`1 asyncEnumerable, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.OverviewTests.Test_KPIs_EmptyDatabase() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\OverviewTests.cs:line 17
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD1-002] Overview - True Total Stock Formula Validation
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.OverviewTests.Test_TotalStock_Calculation() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\OverviewTests.cs:line 55
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD1-003] Overview - Newly Arrived Intake Filter (30 Days Boundary)
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.OverviewTests.Test_NewlyArrived_Boundary() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\OverviewTests.cs:line 88
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD1-004] Overview - Multi-Criteria Status Filter: Overdue Detection
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.OverviewTests.Test_StatusFilter_Overdue() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\OverviewTests.cs:line 117
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD1-005] Overview - Multi-Criteria Status Filter: Returned Late Detection
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.OverviewTests.Test_StatusFilter_ReturnedLate() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\OverviewTests.cs:line 146
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD1-006] Overview - Department Filter ALL Handling
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.OverviewTests.Test_DepartmentFilter_ALL() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\OverviewTests.cs:line 178
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD2-001] Inventory - Equipment Unique Types Count
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.InventoryTests.Test_Equipment_UniqueTypesCount() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\InventoryTests.cs:line 24
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD2-002] Inventory - Healthy Stock vs Total Stock Aggregation
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.InventoryTests.Test_HealthyVsTotal_Aggregation() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\InventoryTests.cs:line 49
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD2-003] Inventory - Search Filter by Equipment Name Case-Insensitive
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.InventoryTests.Test_SearchFilter_EquipmentName() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\InventoryTests.cs:line 79
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD2-004] Inventory - Category Filter with All Categories
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.InventoryTests.Test_CategoryFilter_AllCategories() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\InventoryTests.cs:line 102
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD3-003] Setup - New Equipment Creation with Category FK
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.SetupTests.Test_Equipment_CreationWithCategory() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\SetupTests.cs:line 41
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD3-004] Setup - Equipment Auto-Generated ID and Defaults
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.SetupTests.Test_Equipment_DefaultsAndId() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\SetupTests.cs:line 65
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD4-001] Supplier - Supplier Summary with Zero Supplied Items
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.SupplierTests.Test_SupplierSummary_ZeroItems() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\SupplierTests.cs:line 19
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD4-002] Supplier - Non-Existent Supplier ID Null Safety
- **Error Message:** `SQLite Error 1: 'no such table: Suppliers'.`
- **Stack Trace:**
```text
   at Microsoft.Data.Sqlite.SqliteException.ThrowExceptionForRC(Int32 rc, sqlite3 db)
   at Microsoft.Data.Sqlite.SqliteCommand.PrepareAndEnumerateStatements()+MoveNext()
   at Microsoft.Data.Sqlite.SqliteCommand.GetStatements()+MoveNext()
   at Microsoft.Data.Sqlite.SqliteDataReader.NextResult()
   at Microsoft.Data.Sqlite.SqliteCommand.ExecuteReader(CommandBehavior behavior)
   at Microsoft.Data.Sqlite.SqliteCommand.ExecuteReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken)
   at Microsoft.Data.Sqlite.SqliteCommand.ExecuteDbDataReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Storage.RelationalCommand.ExecuteReaderAsync(RelationalCommandParameterObject parameterObject, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Storage.RelationalCommand.ExecuteReaderAsync(RelationalCommandParameterObject parameterObject, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Query.Internal.SingleQueryingEnumerable`1.AsyncEnumerator.InitializeReaderAsync(AsyncEnumerator enumerator, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Query.Internal.SingleQueryingEnumerable`1.AsyncEnumerator.MoveNextAsync()
   at Microsoft.EntityFrameworkCore.EntityFrameworkQueryableExtensions.ToListAsync[TSource](IQueryable`1 source, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.EntityFrameworkQueryableExtensions.ToListAsync[TSource](IQueryable`1 source, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.SupplierTests.Test_Supplier_InvalidIdNullSafety() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\SupplierTests.cs:line 41
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD4-003] Supplier - Supplier Intake Date Range Filtering
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.SupplierTests.Test_Supplier_DateRangeFilter() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\SupplierTests.cs:line 68
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD4-004] Supplier - ManageSupplier Stock Modification Sync
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.SupplierTests.Test_ManageSupplier_StockModificationSync() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\SupplierTests.cs:line 93
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD4-005] Supplier - ManageSupplier Delete History with Stock Deduction
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.SupplierTests.Test_ManageSupplier_DeleteWithStockDeduction() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\SupplierTests.cs:line 137
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD4-006] Supplier - ManageSupplier Delete History without Stock Deduction
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.SupplierTests.Test_ManageSupplier_DeleteWithoutStockDeduction() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\SupplierTests.cs:line 169
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD5-001] Intake - Batch Intake Simultaneous Equipment Stock & History Update
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.IntakeTests.Test_BatchIntake_SimultaneousStockUpdate() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\IntakeTests.cs:line 24
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD5-002] Intake - Intake Null Supplier Handling
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.IntakeTests.Test_Intake_NullSupplierHandling() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\IntakeTests.cs:line 65
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD6-003] Borrower / Loan - Loan Stock Deduction on Checkout
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.BorrowerLoanTests.Test_Loan_StockDeductionOnCheckout() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\BorrowerLoanTests.cs:line 49
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD6-006] Borrower / Loan - Receipt Return Restocks Inventory
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.BorrowerLoanTests.Test_Loan_ReceiptReturnRestocksInventory() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\BorrowerLoanTests.cs:line 137
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD6-007] Borrower / Loan - Prevent Duplicate Restock on Already Returned Receipt
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.BorrowerLoanTests.Test_Loan_PreventDuplicateRestock() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\BorrowerLoanTests.cs:line 191
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD6-008] Borrower / Loan - BorrowerForm Return Checkbox Uncheck Deducts Stock
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.BorrowerLoanTests.Test_Loan_UncheckReturnedDeductsStock() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\BorrowerLoanTests.cs:line 238
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD8-001] DB Integrity - Foreign Key Cascade Delete: Category Deletion
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.DatabaseIntegrityTests.Test_Category_CascadeDelete() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\DatabaseIntegrityTests.cs:line 23
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

### [TC-MOD8-003] DB Integrity - Foreign Key Constraint: IntakeItem Supplier FK
- **Error Message:** `An error occurred while saving the entity changes. See the inner exception for details.`
- **Stack Trace:**
```text
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(StateManager stateManager, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Project_Sport_Room.TestRunner.Modules.DatabaseIntegrityTests.Test_IntakeItem_InvalidSupplierFk() in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Modules\DatabaseIntegrityTests.cs:line 66
   at Project_Sport_Room.TestRunner.Program.Main(String[] args) in C:\Users\FHD29\Desktop\FHD\Sport Room Management System\Project Sport Room\Tests\Project_Sport_Room.TestRunner\Program.cs:line 68
```

