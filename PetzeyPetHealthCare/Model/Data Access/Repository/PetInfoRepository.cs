using PetzeyPetHealthCare.Model.Data_Access.Interface;
using PetzeyPetHealthCare.Model.Entity;

namespace PetzeyPetHealthCare.Model.Data_Access.Repository
{
    public class PetInfoRepository : IPetInfo

    {
         private PetDbContext db = new PetDbContext();
        public void CreateAccount(PetInfo petInfo)
        {
            db.petInfos.Add(petInfo);
            db.SaveChanges();

        }

        public void EditAccount(PetInfo petInfo)
        {
            db.petInfos.Update(petInfo);
            db.SaveChanges();
        }

        public List<PetInfo> GetAllDetails(int patientId)
        {
            return (from p in db.petInfos
                   select p).ToList(); 
        }
    }
}
