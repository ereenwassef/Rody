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
    
    public partial class supplier
    {
        public supplier()
        {
            this.operations_store = new HashSet<operations_store>();
            this.operations_supplier = new HashSet<operations_supplier>();
            this.purchases = new HashSet<purchases>();
        }
    
        public int id { get; set; }
        public Nullable<int> tasneefId { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string responsible { get; set; }
        public string phone1 { get; set; }
        public string phone2 { get; set; }
        public string phone3 { get; set; }
        public string fax { get; set; }
        public string notes { get; set; }
        public Nullable<int> type { get; set; }
        public Nullable<int> business_type { get; set; }
        public Nullable<double> charge { get; set; }
    
        public virtual ICollection<operations_store> operations_store { get; set; }
        public virtual ICollection<operations_supplier> operations_supplier { get; set; }
        public virtual ICollection<purchases> purchases { get; set; }
        public virtual sub_category_supplier sub_category_supplier { get; set; }
    }
}
