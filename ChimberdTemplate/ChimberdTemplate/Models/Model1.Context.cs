﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChimberdTemplate.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ChimperdEntities1 : DbContext
    {
        public ChimperdEntities1()
            : base("name=ChimperdEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Aboutu> Aboutus { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<FirstSlider> FirstSliders { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Testimonial> Testimonials { get; set; }
        public virtual DbSet<ServiceItem> ServiceItems { get; set; }
        public virtual DbSet<Translate> Translates { get; set; }
    }
}
