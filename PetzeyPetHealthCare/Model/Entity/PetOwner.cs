using System.ComponentModel.DataAnnotations;

namespace PetzeyPetHealthCare.Model.Entity
{
    public class PetOwner 
    {
        [Key]
        public string Name { get; set; }
        public string EmailID { get; set; }
        public long PhoneNumber { get; set; }   
        public string Address { get; set; } 

       public List<Patient> Pets { get;set; }  

    }
}
