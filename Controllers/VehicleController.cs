using TireApi.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TireApi.Services;

namespace TireApi.Controllers 
{    
    [ApiController]
    [Route("api/vehicles")]
    public class VehicleController: ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }
        [Route("years")]
        [HttpGet]
        public ActionResult <IEnumerable<int>> GetYears()
        {

            return Ok(_vehicleRepository.GetYears());
        }

        [Route("makes")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetMakes(int year)
        {
            return Ok(_vehicleRepository.GetMakesByYear(year));
        }
        
        [Route("models")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetModels(int year, string make)
        {
            return Ok(_vehicleRepository.GetModelsByYearAndMake(year, make));
        }
        
        [Route("bodies")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetBodies(int year, string make, string model)
        {
            return Ok(_vehicleRepository.GetBodiesByYearAndMakeAndModel(year, make, model));
        }
        
        [Route("trims")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetTrims(int year, string make, string model, string body)
        {
            return Ok(_vehicleRepository.GetTrimsByYearAndMakeAndModelAndBody(year, make, model, body));
        }

    }
}