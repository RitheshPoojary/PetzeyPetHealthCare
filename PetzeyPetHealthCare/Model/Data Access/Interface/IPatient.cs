using PetzeyPetHealthCare.Model.Entity;

namespace PetzeyPetHealthCare.Model.Data_Access.Interface
{
    public interface IPatient
    {
        int GetAge(DateTime dateOfBirth);
        Patient GetById(int id);
        void DeletePet(int patientId);

    }
}
