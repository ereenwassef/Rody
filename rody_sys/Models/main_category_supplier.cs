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
    
    public partial class main_category_supplier
    {
        public main_category_supplier()
        {
            this.sub_category_supplier = new HashSet<sub_category_supplier>();
        }
    
        public int id { get; set; }
        public string tasneef_name { get; set; }
    
        public virtual ICollection<sub_category_supplier> sub_category_supplier { get; set; }
    }
}
