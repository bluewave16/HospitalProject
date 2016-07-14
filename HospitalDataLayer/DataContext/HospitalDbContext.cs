using HospitalModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDataLayer
{
    public class HospitalDbContext : IdentityDbContext<HospitalUser>
    {

        public HospitalDbContext() : base("HospitalConnection")
        {

        }

        public DbSet<Receptionist> reception { get; set; }
        public DbSet<Pharmacist> pharmacist { get; set; }
        public DbSet<Accountant> accountant { get; set; }
        public DbSet<Invoice> invoice { get; set; }
        public DbSet<Admin> admin { get; set; }

        public DbSet<AdmitHistory> admit { get; set; }
        public DbSet<Appointment> appointment { get; set; }

        public DbSet<BedAllotment> bedAllotment { get; set; }
        public DbSet<Bloodbank> bloodBank { get; set; }

        public DbSet<Blooddoner> bloodDoner { get; set; }
        public DbSet<Department> department { get; set; }
        public DbSet<Doctor> doctor { get; set; }
        public DbSet<LaboratoryOperator> labOperator { get; set; }
        public DbSet<Nurses> nurse { get; set; }
        public DbSet<OperationHistory> OHistory { get; set; }
        public DbSet<Patient> patient { get; set; }
        public DbSet<Prescreption> prescreption { get; set; }
        public DbSet<Report> report { get; set; }

        public static HospitalDbContext Create()
        {
            return new HospitalDbContext();
        }

    }
}
