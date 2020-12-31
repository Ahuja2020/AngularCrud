using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AngularCRUD.Models.EF
{
    public class AngularMvcDbContext:DbContext
    {
        public AngularMvcDbContext():base("name=CyberDBEntities")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove < PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
    }
}