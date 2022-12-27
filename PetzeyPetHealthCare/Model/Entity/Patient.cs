using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace PetzeyPetHealthCare.Model.Entity
{
    public class Patient 
    {
        [Key]
        public int PatientId { get; set; }
        public string PetSpecies { get; set; }
        public string PetName { get; set;}
        public string BreedName { get; set;}
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set;}
        public string Allergy { get; set;}  

       // public double Age { get; set; }

        // Class Propeties
        public PetOwner petOwner { get; set; }  
        public PetInfo PetInfo { get; set; }    
        public List<Vitals> vitals { get; set; }  
        public List<AppointmentHistory> appointmentHistories { get; set; }
        public List<Prescription> prescriptions { get; set; }   
        public List<Symptoms> symptoms { get; set; }
       
    }
}
