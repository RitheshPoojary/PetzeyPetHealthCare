using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetzeyPetHealthCare.Model.Data_Access.Interface;
using PetzeyPetHealthCare.Model.Data_Access.Repository;
using PetzeyPetHealthCare.Model.Entity;

namespace PetzeyPetHealthCare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SymptomsController : ControllerBase
    {
        private ISymptomRepsitory symptomRepo = new SymptomRepsitory();
        [HttpGet]
        public List<Symptoms> GetViewAllSymptoms(int appointmentId)

        {

            return symptomRepo.ViewAllSymptoms(appointmentId);

        }
        [Authorize]
        [HttpDelete]
        [Route("DeleteSymptomsById{id}")]
        public IActionResult DeleteSymptoms(int appointmentId)
        {
            Symptoms s = symptomRepo.GetSymptomsById(appointmentId);
            // Not found
            if (s == null)
            {
                // return http status code 404
                return NotFound();
            }
            // Found
            else
            {
                symptomRepo.DeleteSymptoms(appointmentId);

                // return http status code 200 with data
                return Ok();
            }
        }
        [HttpPost]
        public IActionResult PostAddSymptoms(Symptoms symptoms)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data");
            }
            symptomRepo.AddSymptoms(symptoms);
            //Status code -201/location/data
            return Created($"api/PetService/{symptoms.AppointmentId}", symptoms);
        }

    }
}
