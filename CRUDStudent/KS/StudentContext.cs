using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using CRUDStudent.Models;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace CRUDStudent.KS
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentContext")
        {
        }


        public virtual DbSet<Student> Students { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}