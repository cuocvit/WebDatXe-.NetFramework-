//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vehicle()
        {
            this.trips = new HashSet<trip>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string license_plate { get; set; }
        public string type { get; set; }
        public string avatar { get; set; }
        public Nullable<int> status_confirm { get; set; }
        public Nullable<int> status_update { get; set; }
        public Nullable<int> status_delete { get; set; }
        public Nullable<int> id_buses { get; set; }
    
        public virtual bus bus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trip> trips { get; set; }
    }
}
