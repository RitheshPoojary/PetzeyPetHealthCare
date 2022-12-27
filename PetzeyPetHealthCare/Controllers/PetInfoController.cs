using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetzeyPetHealthCare.Model.Data_Access.Interface;
using PetzeyPetHealthCare.Model.Data_Access.Repository;
using PetzeyPetHealthCare.Model.Entity;

namespace PetzeyPetHealthCare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetInfoController : ControllerBase
    {
        private IPetInfo repo = new PetInfoRepository();
        // Design the end Point - uri

        // all details
        // GET......(domain Name)/api/PetServiceController
        [HttpGet]
        public List<PetInfo> GetDetails(int patientId)
        {
            return repo.GetAllDetails(patientId);
        }
        // create Account
        [HttpPost]

        public IActionResult PostCreateAccout(PetInfo petInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data");
            }
            repo.CreateAccount(petInfo);
            //Status code -201/location/data
            return Created($"api/PetService/{petInfo.PatientID}", petInfo);
        }
        // Edit Account
        [HttpPut]
        //Add rounting
        public IActionResult PutEditAccount(PetInfo petInfo)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid data");
            }
            repo.EditAccount(petInfo);
            return Ok();
        }
    }
}
