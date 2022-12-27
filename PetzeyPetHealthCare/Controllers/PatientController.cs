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
    public class PatientController : ControllerBase
    {
      private IPatient patientRepo = new PatientRepository();

        // delete
        // Only for the registered user
        [Authorize]
     [HttpDelete]
     [Route("DeletePatientById/{id}")]

        public IActionResult DeletePet(int patientId)
        {
            Patient p = patientRepo.GetById(patientId);
            // Not found
            if(p == null)
            {
                // return http status code 404
                return NotFound();
            }
            // Found
            else
            {
             patientRepo.DeletePet(patientId);
                
             // return http status code 200 with data
                return Ok();
            }

        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            Patient p = patientRepo.GetById(id);
           
            if(p == null) // Not Found
            {
                // return http status code 404
                return NotFound();
            }
            else // Found
            {
                // return http status code 200 with data
                return Ok(p);
            }
            

        }
     
    }
}
