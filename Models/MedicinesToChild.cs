//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedicinesToChild
    {
        public long Id { get; set; }
        public Nullable<long> medicineId { get; set; }
        public Nullable<long> childId { get; set; }
        public Nullable<int> Dosage { get; set; }
        public Nullable<long> kindOfDosage { get; set; }
        public Nullable<int> numCountADay { get; set; }
        public Nullable<int> timeOfDay { get; set; }
    
        public virtual KingOfDosage KingOfDosage { get; set; }
        public virtual Medicine Medicine { get; set; }
        public virtual User User { get; set; }
    }
}
