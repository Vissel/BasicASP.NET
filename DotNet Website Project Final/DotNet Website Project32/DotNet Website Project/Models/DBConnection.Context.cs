﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PartTimeJobEntitiesEntities : DbContext
    {
        public PartTimeJobEntitiesEntities()
            : base("name=PartTimeJobEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BONUS_TIME> BONUS_TIME { get; set; }
        public virtual DbSet<FEED_BACKLIST> FEED_BACKLIST { get; set; }
        public virtual DbSet<JOB> JOBs { get; set; }
        public virtual DbSet<JOB_CATEGORY> JOB_CATEGORY { get; set; }
        public virtual DbSet<JOB_RECUMENT> JOB_RECUMENT { get; set; }
        public virtual DbSet<JOB_RECUMENT_PROCESSING> JOB_RECUMENT_PROCESSING { get; set; }
        public virtual DbSet<JOB_WAGE_BILL> JOB_WAGE_BILL { get; set; }
        public virtual DbSet<PROFILE> PROFILEs { get; set; }
        public virtual DbSet<PROVINCE> PROVINCEs { get; set; }
        public virtual DbSet<REFERRAL_WAGE_BILL> REFERRAL_WAGE_BILL { get; set; }
        public virtual DbSet<ROLE> ROLEs { get; set; }
        public virtual DbSet<SHIFT_WORK_SCHEDULE> SHIFT_WORK_SCHEDULE { get; set; }
        public virtual DbSet<TOWN> TOWNs { get; set; }
        public virtual DbSet<TYPEPAYCARD> TYPEPAYCARDs { get; set; }
        public virtual DbSet<USER> USERs { get; set; }
        public virtual DbSet<USERPAYCARD> USERPAYCARDS { get; set; }
        public virtual DbSet<WORK_TIME> WORK_TIME { get; set; }
    }
}
