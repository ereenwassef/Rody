//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rody_sys.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class adminOperations
    {
        public int id { get; set; }
        public Nullable<int> adminId { get; set; }
        public string opType { get; set; }
        public Nullable<int> opId { get; set; }
        public string tblName { get; set; }
        public string shortString { get; set; }
        public string time { get; set; }
    
        public virtual admins admins { get; set; }
    }
}
