using PetzeyPetHealthCare.Model.Data_Access.Interface;
using PetzeyPetHealthCare.Model.Entity;

namespace PetzeyPetHealthCare.Model.Data_Access.Repository
{
    public class PatientRepository : IPatient
    { 
         private PetDbContext db = new PetDbContext();
        public void DeletePet(int patientId)
        {
            var petToDel = db.Patients.Find( patientId);
            db.Patients.Remove(petToDel);
            db.SaveChanges();
        }

        public int GetAge(DateTime dateOfBirth)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - dateOfBirth.Year;
            if (dateOfBirth > now.AddYears(-age))
                age--;
            return age;
        }

        public Patient GetById(int id)
        {
            return db.Patients.Find(id);
        }
    }
}
