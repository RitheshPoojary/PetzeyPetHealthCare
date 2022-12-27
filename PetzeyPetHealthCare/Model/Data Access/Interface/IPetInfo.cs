using PetzeyPetHealthCare.Model.Entity;

namespace PetzeyPetHealthCare.Model.Data_Access.Interface
{
    public interface IPetInfo
    {
         void CreateAccount(PetInfo petInfo);

         void EditAccount(PetInfo petInfo);
         List<PetInfo> GetAllDetails(int patientId);
    }
}
