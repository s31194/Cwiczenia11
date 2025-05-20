using Microsoft.EntityFrameworkCore;
using Tutorial5.Models;

namespace Tutorial5.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<Medicament> Medicaments { get; set; }
    public DbSet<Prescription_Medicament> Prescription_Medicaments { get; set; }
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>().HasData(new List<Doctor>()
        {
            new Doctor() { IdDoctor = 1, FirstName = "Jane", LastName = "Doe", Email = "jane.doe@gmail.com" },
            new Doctor() { IdDoctor = 2, FirstName = "John", LastName = "Doe", Email = "john.doe@gmail.com" },
        });
        
        modelBuilder.Entity<Patient>().HasData(new List<Patient>()
        {
            new Patient() { IdPatient = 1, FirstName = "Adam", LastName = "Mickiewicz", Birthdate = new DateTime(2004, 3, 11, 0, 0, 0)},
            new Patient() { IdPatient = 2, FirstName = "Jan", LastName = "Kowalski", Birthdate = new DateTime(2005, 7, 25, 0, 0, 0)},
        });
        
        modelBuilder.Entity<Prescription>().HasData(new List<Prescription>()
        {
            new Prescription()
            {
                IdPrescription = 1, Date = new DateTime(2025, 5, 16, 0, 0, 0), 
                DueDate = new DateTime(2025, 5, 30, 23, 59, 59), IdPatient = 1, IdDoctor = 1
            },
            new Prescription()
            {
                IdPrescription = 2, Date = new DateTime(2025, 7, 10, 0, 0, 0), 
                DueDate = new DateTime(2025, 7, 24, 23, 59, 59), IdPatient = 2, IdDoctor = 2
            },
        });
        
        modelBuilder.Entity<Medicament>().HasData(new List<Medicament>()
        {
            new Medicament() { IdMedicament = 1, Name = "Medicament1", Description = "Description for Medicament 1", Type = "Type of Medicament 1" },
            new Medicament() { IdMedicament = 2, Name = "Medicament2", Description = "Description for Medicament 2", Type = "Type of Medicament 2"  },
        });
        
        modelBuilder.Entity<Prescription_Medicament>().HasData(new List<Prescription_Medicament>()
        {
            new Prescription_Medicament() { IdMedicament = 1, IdPrescription = 1, Dose = 4, Details = "Details for Prescription 1" },
            new Prescription_Medicament() { IdMedicament = 2, IdPrescription = 2, Dose = 6, Details = "Details for Prescription 2" },
        });
    }
}