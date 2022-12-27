using Microsoft.EntityFrameworkCore;
using PetzeyPetHealthCare.Model.Entity;
using static System.Net.Mime.MediaTypeNames;

namespace PetzeyPetHealthCare.Model.Data_Access
{
    public class PetDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configre db
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PetzeyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
         
         // Configure table
        public DbSet<Vitals> vitals { get; set; }
        public DbSet<AppointmentHistory> appointmentHistories { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PetOwner> petOwner { get; set; }
        public DbSet<PetInfo> petInfos { get; set; }
        public DbSet<Symptoms> symptoms { get; set; }
        public DbSet<Prescription> prescription { get; set; }



    }
}
