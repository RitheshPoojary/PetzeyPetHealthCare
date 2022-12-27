using PetzeyPetHealthCare.Model.Entity;

namespace PetzeyPetHealthCare.Model.Data_Access.Interface
{
    public interface IAppointmentHistory
    {
        List<AppointmentHistory> ViewAllAppoinments(int appointmentId);
    }
}
