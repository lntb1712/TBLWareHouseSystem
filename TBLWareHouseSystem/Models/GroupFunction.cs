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
    
    public partial class GroupFunction
    {
        public string GroupID { get; set; }
        public string FunctionID { get; set; }
        public Nullable<bool> isEnable { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string UpdateBy { get; set; }
    
        public virtual Function Function { get; set; }
        public virtual GroupManagement GroupManagement { get; set; }
    }
}
