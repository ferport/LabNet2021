using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using TPEntityFramework.Entities;

namespace TPEntityFramework.Data
{
    public partial class NorthwindContext : DbContext
    {
        public NorthwindContext()
            : base("name=NorthwindConnection")
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Territories> Territories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>()
                .Property(e => e.CustomerID)
                .IsFixedLength();

            modelBuilder.Entity<Employees>()
                .HasMany(e => e.Employees1)
                .WithOptional(e => e.Employees2)
                .HasForeignKey(e => e.ReportsTo);

            modelBuilder.Entity<Employees>()
                .HasMany(e => e.Territories)
                .WithMany(e => e.Employees)
                .Map(m => m.ToTable("EmployeeTerritories").MapLeftKey("EmployeeID").MapRightKey("TerritoryID"));

            modelBuilder.Entity<Territories>()
                .Property(e => e.TerritoryDescription)
                .IsFixedLength();
        }
    }
}
