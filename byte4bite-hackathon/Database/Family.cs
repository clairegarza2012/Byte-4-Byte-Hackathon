//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace byte4bite_hackathon.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Family
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Family()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int ID { get; set; }
        public int FamilySize { get; set; }
        public bool ChildrenHaveCheckoutConsent { get; set; }
        public string FamilyID { get; set; }
        public int MaxPointTotal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
