﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TaskEntities : DbContext
    {
        public TaskEntities()
            : base("name=TaskEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<classEnrolment> classEnrolments { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    }
}