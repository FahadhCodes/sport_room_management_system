using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Project_Sport_Room.Models
{
    public class SportRoomContext : DbContext
    {
        public SportRoomContext()
        {
            // THIS IS THE MAGIC LINE. 
            // If the database or any tables are missing, it builds them instantly.
            Database.EnsureCreated();
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<BorrowReceipt> BorrowReceipts { get; set; }
        public DbSet<BorrowedCombination> BorrowedCombinations { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<IntakeItem> IntakeItems { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connects to your local SQLite file
            optionsBuilder.UseSqlite("Data Source=sportroom.db");
        }
    }
}

