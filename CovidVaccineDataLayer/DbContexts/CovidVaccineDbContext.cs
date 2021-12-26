using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CovidVaccineDataLayer.EntityModels;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CovidVaccineDataLayer.DbContexts
{
    public partial class CovidVaccineDbContext : DbContext
    {
        public CovidVaccineDbContext()
        {
        }

        public CovidVaccineDbContext(DbContextOptions<CovidVaccineDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Vaersdata> Vaersdata { get; set; }
        public virtual DbSet<Vaerssymptoms> Vaerssymptoms { get; set; }
        public virtual DbSet<Vaersvax> Vaersvax { get; set; }
        public virtual DbSet<VwCovidVaccineData> VwCovidVaccineData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=VaccineResearch;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vaersdata>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VAERSData");

                entity.Property(e => e.AgeInYears).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BirthDefects)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CalculatedAgeInMonths).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClinicOrDoctorVisit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiedBecauseOfVaccine).HasMaxLength(1);

                entity.Property(e => e.EmergencyRoomOrDoctorVisit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmergencyRoomVisit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HasRecovered)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hospitalized)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsDisabled)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OtherMedications).HasMaxLength(240);

                entity.Property(e => e.PriorVaccinationInfo).HasMaxLength(128);

                entity.Property(e => e.ProlongationOfExitingHospitalization)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VaccineAdministeredBy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VaccineFundedBy)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VaersId).HasColumnName("VAERS_ID");
            });

            modelBuilder.Entity<Vaerssymptoms>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VAERSSymptoms");

                entity.Property(e => e.Symptom1).IsRequired();

                entity.Property(e => e.SymptomVersion1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SymptomVersion2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SymptomVersion3).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SymptomVersion4).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SymptomVersion5).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VaersId).HasColumnName("VAERS_ID");
            });

            modelBuilder.Entity<Vaersvax>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VAERSVax");

                entity.Property(e => e.AdministeredVaccineType)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.NumberOfDosesAdministered)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.VaccinationName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VaccinationSite).HasMaxLength(6);

                entity.Property(e => e.VaccineManufactured)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.VaccineManufacturerLot).HasMaxLength(15);

                entity.Property(e => e.VaccineRoute).HasMaxLength(6);

                entity.Property(e => e.VaersId).HasColumnName("VAERS_ID");
            });

            modelBuilder.Entity<VwCovidVaccineData>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCovidVaccineData");

                entity.Property(e => e.ClinicOrDoctorVisit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiedBecauseOfVaccine).HasMaxLength(1);

                entity.Property(e => e.EmergencyRoomOrDoctorVisit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmergencyRoomVisit)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hospitalized)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IsDisabled)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumberOfDosesAdministered)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.OtherMedications).HasMaxLength(240);

                entity.Property(e => e.PriorVaccinationInfo).HasMaxLength(128);

                entity.Property(e => e.VaccinationName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VaccineManufactured)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
