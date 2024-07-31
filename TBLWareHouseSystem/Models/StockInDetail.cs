//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class StockInDetail
    {
        public string StockInID { get; set; }
        public string ProductID { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public Nullable<double> UnitSum { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string UpdateBy { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Account Account1 { get; set; }
        public virtual StockIn StockIn { get; set; }
        public virtual StockIn StockIn1 { get; set; }
        public virtual StockIn StockIn2 { get; set; }
    }
}
