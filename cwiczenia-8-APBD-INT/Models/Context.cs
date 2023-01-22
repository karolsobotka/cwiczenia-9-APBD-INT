﻿using cwiczenia_8_APBD_INT.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace cwiczenia_8_APBD_INT.Models
{
        public class Context : DbContext
        {
            public Context() { }
            public Context(DbContextOptions<Context> options) : base(options) { }


            public virtual DbSet<Medicament> Medicament { get; set; }
            public virtual DbSet<PrescriptionMedicament> PrescriptionMedicament { get; set; }
            public virtual DbSet<Prescription> Prescription { get; set; }
            public virtual DbSet<Doctor> Doctor { get; set; }
            public virtual DbSet<Patient> Patient { get; set; }
            public virtual DbSet<User> User { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfiguration(new DoctorConfig());
                modelBuilder.ApplyConfiguration(new MedicamentConfig());
                modelBuilder.ApplyConfiguration(new PatientConfig());
                modelBuilder.ApplyConfiguration(new PrescriptionConfig());
                modelBuilder.ApplyConfiguration(new PrescriptionMedicamentConfig());
                modelBuilder.ApplyConfiguration(new UserConfig());
            }
        }
    }
