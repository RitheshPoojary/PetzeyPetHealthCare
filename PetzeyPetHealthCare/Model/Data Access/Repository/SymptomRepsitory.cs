using PetzeyPetHealthCare.Model.Data_Access.Interface;
using PetzeyPetHealthCare.Model.Entity;

namespace PetzeyPetHealthCare.Model.Data_Access.Repository
{
    public class SymptomRepsitory : ISymptomRepsitory
    {
        private   PetDbContext db = new PetDbContext();


        public void AddSymptoms(Symptoms symptoms)
        {
            db.symptoms.Add(symptoms);
            db.SaveChanges();
        }

        public void DeleteSymptoms(int appointmentId)
        {
            var symptomsToDel = db.symptoms.Find(appointmentId);
            db.symptoms.Remove(symptomsToDel);
            db.SaveChanges();
        }

        public List<Symptoms> ViewAllSymptoms(int  appointmentId)
        {
            return (from s in db.symptoms
                   where s.AppointmentId == appointmentId
                   select s).ToList();

        }
        public Symptoms GetSymptomsById (int appointmentId)
        {
            return db.symptoms.Find(appointmentId);
           
        }
    }
}
