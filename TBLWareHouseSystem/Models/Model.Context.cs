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
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
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
    
        public virtual ObjectResult<AccountLogin_Result> AccountLogin(string userID, string userPassword)
        {
            var userIDParameter = userID != null ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(string));
    
            var userPasswordParameter = userPassword != null ?
                new ObjectParameter("userPassword", userPassword) :
                new ObjectParameter("userPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AccountLogin_Result>("AccountLogin", userIDParameter, userPasswordParameter);
        }
    
        public virtual ObjectResult<GetGroupFunctionsList_Result> GetGroupFunctionsList(string groupID)
        {
            var groupIDParameter = groupID != null ?
                new ObjectParameter("groupID", groupID) :
                new ObjectParameter("groupID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetGroupFunctionsList_Result>("GetGroupFunctionsList", groupIDParameter);
        }
    
        public virtual ObjectResult<GetGroupManagementList_Result> GetGroupManagementList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetGroupManagementList_Result>("GetGroupManagementList");
        }
    
        public virtual ObjectResult<GetAccountList_Result> GetAccountList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAccountList_Result>("GetAccountList");
        }
    }
}
