﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DovizProje
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DovizOtomasyonDBEntities : DbContext
    {
        public DovizOtomasyonDBEntities()
            : base("name=DovizOtomasyonDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AlisSatislars> AlisSatislars { get; set; }
        public virtual DbSet<Dovizlers> Dovizlers { get; set; }
        public virtual DbSet<Envanters> Envanters { get; set; }
        public virtual DbSet<GelirGiderTipleris> GelirGiderTipleris { get; set; }
        public virtual DbSet<IslemTipleris> IslemTipleris { get; set; }
        public virtual DbSet<Muhasebelers> Muhasebelers { get; set; }
        public virtual DbSet<Musterilers> Musterilers { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Veznelers> Veznelers { get; set; }
    }
}