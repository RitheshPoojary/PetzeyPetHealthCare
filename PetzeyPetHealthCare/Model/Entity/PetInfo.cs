using System.ComponentModel.DataAnnotations;

namespace PetzeyPetHealthCare.Model.Entity
{
    public class PetInfo
    {
        [Key]
        public int PatientID { get;set; }
        public PetOwner PetOwner { get; set; }
       

    }
}
