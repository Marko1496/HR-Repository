﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hrm_v4.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AMONESTACIONES> AMONESTACIONES { get; set; }
        public virtual DbSet<ASCENSOS> ASCENSOS { get; set; }
        public virtual DbSet<DEPARTAMENTOS> DEPARTAMENTOS { get; set; }
        public virtual DbSet<EMPLEADOS> EMPLEADOS { get; set; }
        public virtual DbSet<EMPRESAS> EMPRESAS { get; set; }
        public virtual DbSet<HISTORIALES> HISTORIALES { get; set; }
        public virtual DbSet<PERMISOS> PERMISOS { get; set; }
        public virtual DbSet<PUESTOS> PUESTOS { get; set; }
        public virtual DbSet<SUSPENSIONES> SUSPENSIONES { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
        public virtual DbSet<VACACIONES> VACACIONES { get; set; }
    }
}
