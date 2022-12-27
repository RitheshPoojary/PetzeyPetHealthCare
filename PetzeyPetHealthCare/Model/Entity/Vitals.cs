using System.ComponentModel.DataAnnotations;

namespace PetzeyPetHealthCare.Model.Entity
{
    public class Vitals
    {
        [Key]
        public int VitalsId { get; set; }
        public int Bpm { get; set; }
        public string Temperature { get; set; }
        public int Pulse { get; set; }
    }
}
