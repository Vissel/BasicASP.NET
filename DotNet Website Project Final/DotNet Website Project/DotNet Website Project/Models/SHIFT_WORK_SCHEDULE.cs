//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNet_Website_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SHIFT_WORK_SCHEDULE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SHIFT_WORK_SCHEDULE()
        {
            this.JOBs = new HashSet<JOB>();
        }
    
        public int SHIFT_ID { get; set; }
        public Nullable<int> MON_WORK_TIME { get; set; }
        public Nullable<int> TUES_WORK_TIME { get; set; }
        public Nullable<int> WED_WORK_TIME { get; set; }
        public Nullable<int> THURS_WORK_TIME { get; set; }
        public Nullable<int> FRI_WORK_TIME { get; set; }
        public Nullable<int> SAT_WORK_TIME { get; set; }
        public Nullable<int> SUN_WORK_TIME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JOB> JOBs { get; set; }
        public virtual WORK_TIME WORK_TIME { get; set; }
        public virtual WORK_TIME WORK_TIME1 { get; set; }
        public virtual WORK_TIME WORK_TIME2 { get; set; }
        public virtual WORK_TIME WORK_TIME3 { get; set; }
        public virtual WORK_TIME WORK_TIME4 { get; set; }
        public virtual WORK_TIME WORK_TIME5 { get; set; }
        public virtual WORK_TIME WORK_TIME6 { get; set; }
    }
}
