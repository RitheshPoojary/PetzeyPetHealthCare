using PetzeyPetHealthCare.Model.Data_Access.Interface;
using PetzeyPetHealthCare.Model.Entity;

namespace PetzeyPetHealthCare.Model.Data_Access.Repository
{
    public class AppointmentHistoryRepository : IAppointmentHistory
    {
         private  PetDbContext db = new PetDbContext();

        public List<AppointmentHistory>  ViewAllAppoinments(int appointmentId)
        {
            
            return (from p in db.appointmentHistories
                    where p.AppointmentId == appointmentId  
                    select p).ToList();
             
        }

        //void IAppointmentHistory.ViewAllAppoinments()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

