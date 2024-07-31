﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TBLWareHouseSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TBLWareHouseSystemEntities : DbContext
    {
        public TBLWareHouseSystemEntities()
            : base("name=TBLWareHouseSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Function> Functions { get; set; }
        public virtual DbSet<GroupFunction> GroupFunctions { get; set; }
        public virtual DbSet<GroupManagement> GroupManagements { get; set; }
        public virtual DbSet<LocationMaster> LocationMasters { get; set; }
        public virtual DbSet<MovementHistory> MovementHistories { get; set; }
        public virtual DbSet<ProductMaster> ProductMasters { get; set; }
        public virtual DbSet<StockIn> StockIns { get; set; }
        public virtual DbSet<StockInDetail> StockInDetails { get; set; }
        public virtual DbSet<StockOut> StockOuts { get; set; }
        public virtual DbSet<StockOutDetail> StockOutDetails { get; set; }
        public virtual DbSet<StockTake> StockTakes { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TransactionHistory> TransactionHistories { get; set; }
    }
}
