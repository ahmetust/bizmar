﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bizmar
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mahalleMarketiEntities : DbContext
    {
        public mahalleMarketiEntities()
            : base("name=mahalleMarketiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cariSatis> cariSatis { get; set; }
        public virtual DbSet<cariSatisUrunu> cariSatisUrunu { get; set; }
        public virtual DbSet<irsaliye> irsaliye { get; set; }
        public virtual DbSet<irsaliyeUrunu> irsaliyeUrunu { get; set; }
        public virtual DbSet<musteri> musteri { get; set; }
        public virtual DbSet<odeme> odeme { get; set; }
        public virtual DbSet<pesinSatis> pesinSatis { get; set; }
        public virtual DbSet<pesinSatisUrunu> pesinSatisUrunu { get; set; }
        public virtual DbSet<sayac> sayac { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tedarikci> tedarikci { get; set; }
        public virtual DbSet<todeme> todeme { get; set; }
        public virtual DbSet<urun> urun { get; set; }
        public virtual DbSet<urunListesi> urunListesi { get; set; }
        public virtual DbSet<market> market { get; set; }
    }
}
