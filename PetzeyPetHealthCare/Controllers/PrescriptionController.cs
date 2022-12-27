using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetzeyPetHealthCare.Model.Data_Access.Interface;
using PetzeyPetHealthCare.Model.Data_Access.Repository;
using PetzeyPetHealthCare.Model.Entity;

namespace PetzeyPetHealthCare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {
        private IPrescription prescriptionRepo = new PrescriptionRepository();
        [HttpGet]
        public List<Prescription> GetViewAllPrescription(int appointmentId)
        {
            return prescriptionRepo.ViewAllPrescription(appointmentId);
        }
    }
}
