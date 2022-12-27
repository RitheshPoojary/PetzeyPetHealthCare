using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetzeyPetHealthCare.Model.Data_Access.Interface;
using PetzeyPetHealthCare.Model.Data_Access.Repository;
using PetzeyPetHealthCare.Model.Entity;

namespace PetzeyPetHealthCare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentHistoryController : ControllerBase
    {
        private IAppointmentHistory appointmentRepo = new AppointmentHistoryRepository();
        [HttpGet]
        public List<AppointmentHistory> GetAppointmentHistories(int appointmentId)

        {

            return appointmentRepo.ViewAllAppoinments(appointmentId);

        }


    }
}
