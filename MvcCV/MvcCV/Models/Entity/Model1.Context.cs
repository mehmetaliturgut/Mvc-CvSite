//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCV.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCVEntities : DbContext
    {
        public DbCVEntities()
            : base("name=DbCVEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_About> tbl_About { get; set; }
        public virtual DbSet<tbl_Admin> tbl_Admin { get; set; }
        public virtual DbSet<tbl_Awards> tbl_Awards { get; set; }
        public virtual DbSet<tbl_Contact> tbl_Contact { get; set; }
        public virtual DbSet<tbl_Education> tbl_Education { get; set; }
        public virtual DbSet<tbl_Experience> tbl_Experience { get; set; }
        public virtual DbSet<TBL_Interests> TBL_Interests { get; set; }
        public virtual DbSet<tbl_Skills> tbl_Skills { get; set; }
        public virtual DbSet<tbl_SocialMedia> tbl_SocialMedia { get; set; }
    }
}
