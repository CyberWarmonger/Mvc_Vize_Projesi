﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mvc_Vize_Projesi.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class vize_mvcEntities : DbContext
    {
        public vize_mvcEntities()
            : base("name=vize_mvcEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Idare> Tbl_Idare { get; set; }
        public virtual DbSet<Tbl_Ogrenci> Tbl_Ogrenci { get; set; }
        public virtual DbSet<Tbl_Ogretmen> Tbl_Ogretmen { get; set; }
    }
}
