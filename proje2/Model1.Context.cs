﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proje2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class finalEntities : DbContext
    {
        public finalEntities()
            : base("name=finalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_DERS> TBL_DERS { get; set; }
        public virtual DbSet<TBL_NOTLAR> TBL_NOTLAR { get; set; }
        public virtual DbSet<TBL_OGR> TBL_OGR { get; set; }
        public virtual DbSet<TBL_DEVAMSİZLİK> TBL_DEVAMSİZLİK { get; set; }
    }
}
