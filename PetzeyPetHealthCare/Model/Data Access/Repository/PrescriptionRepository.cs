using PetzeyPetHealthCare.Model.Data_Access.Interface;
using PetzeyPetHealthCare.Model.Entity;

namespace PetzeyPetHealthCare.Model.Data_Access.Repository
{
    public class PrescriptionRepository : IPrescription
    {
        private PetDbContext db = new PetDbContext();
        public List<Prescription> ViewAllPrescription(int appointmentId)
        {
           return (from p in db.prescription
                   where p.AppointmentId== appointmentId
                   select p).ToList();
        }
    }
}
