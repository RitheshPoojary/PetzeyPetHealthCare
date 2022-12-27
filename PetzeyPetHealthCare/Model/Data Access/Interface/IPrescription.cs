using PetzeyPetHealthCare.Model.Entity;

namespace PetzeyPetHealthCare.Model.Data_Access.Interface
{
    public interface IPrescription
    {
        public List<Prescription> ViewAllPrescription(int appointmentId);
    }
}
