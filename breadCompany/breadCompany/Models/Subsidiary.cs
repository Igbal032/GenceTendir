//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace breadCompany.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subsidiary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subsidiary()
        {
            this.CountForDays = new HashSet<CountForDays>();
        }
    
        public int Id { get; set; }
        public string Subsidiary1 { get; set; }
        public int MarketId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CountForDays> CountForDays { get; set; }
        public virtual MarketList MarketList { get; set; }
    }
}
