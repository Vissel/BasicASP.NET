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
    
    public partial class JOB_WAGE_BILL
    {
        public int JOB_BILL_ID { get; set; }
        public int RECUMENT_ID { get; set; }
        public Nullable<int> EMPLOYER_ID { get; set; }
        public Nullable<int> EMPLOYEE_ID { get; set; }
        public Nullable<double> JOB_WAGE_COST { get; set; }
        public string EMLOYER_CARDNUMBER { get; set; }
        public string EMPLOYEE_CARDNUMBER { get; set; }
    
        public virtual JOB_RECUMENT JOB_RECUMENT { get; set; }
        public virtual USERPAYCARD USERPAYCARD { get; set; }
        public virtual USERPAYCARD USERPAYCARD1 { get; set; }
        public virtual PROFILE PROFILE { get; set; }
        public virtual PROFILE PROFILE1 { get; set; }
    }
}
