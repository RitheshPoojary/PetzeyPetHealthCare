using PetzeyPetHealthCare.Model.Entity;

namespace PetzeyPetHealthCare.Model.Data_Access.Interface
{
    public interface ISymptomRepsitory
    {
        List<Symptoms> ViewAllSymptoms(int appointmentId);
        void AddSymptoms(Symptoms symptoms);
        void DeleteSymptoms(int appointmentId);
        Symptoms GetSymptomsById(int appointmentId);


    }
}
