using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web;
using project.Model.layer;

namespace Site.Model.layer.Context
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext()
        {
            
        }

        public HospitalDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Nurses> Nurses { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<UserPanel> UserPanels { get; set; }
        public DbSet<Reception> Receptions { get; set; }
        public DbSet<Hospitalization> Hospitalizations { get; set; }        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }    
    }
}

