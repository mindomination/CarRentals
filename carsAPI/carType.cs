//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace carsAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class carType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public carType()
        {
            this.cars = new HashSet<car>();
        }
    
        public int id { get; set; }
        public string manufacturer { get; set; }
        public string model { get; set; }
        public double dailyCost { get; set; }
        public double dailyPenalty { get; set; }
        public System.DateTime manufacturingYear { get; set; }
        public string gearType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<car> cars { get; set; }
    }
}
