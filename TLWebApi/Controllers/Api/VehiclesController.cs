using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TLWebApi.Interfaces;
using TLWebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TLWebApi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class VehiclesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public VehiclesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: api/<VehicleController>
        [HttpGet]
        public IEnumerable<Vehicle> Get()
        {
            return _unitOfWork
                .Vehicles
                .GetVehicles();
        }

        // GET api/<VehicleController>/5
        [HttpGet("{id}")]
        public Vehicle Get(int id)
        {
            return _unitOfWork
                .Vehicles
                .GetVehicle(id);
        }

        // POST api/<VehicleController>
        [HttpPost]
        public void Post([FromBody] Vehicle value)
        {
            _unitOfWork
                .Vehicles
                .Add(value);
        }

        // PUT api/<VehicleController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Vehicle value)
        {
            _unitOfWork
                .Vehicles
                .Update(value);
        }

        // DELETE api/<VehicleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _unitOfWork
                .Vehicles
                .Remove(id);
        }
    }
}
