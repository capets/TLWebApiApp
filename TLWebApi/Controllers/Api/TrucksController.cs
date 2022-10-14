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
    public class TrucksController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrucksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: api/<TrucksController>
        [HttpGet]
        public IEnumerable<Truck> Get()
        {
            return _unitOfWork
                .Vehicles
                .GetVehicles();
        }

        // GET api/<TrucksController>/5
        [HttpGet("{id}")]
        public Truck Get(int id)
        {
            return _unitOfWork
                .Vehicles
                .GetVehicle(id);
        }

        // POST api/<TrucksController>
        [HttpPost]
        public void Post([FromBody] Truck value)
        {
            _unitOfWork
                .Vehicles
                .Add(value);
        }
        
        [HttpPut()]
        public void Put([FromBody] Truck value)
        {
            _unitOfWork
                .Vehicles
                .Update(value);
        }

        // DELETE api/<TrucksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _unitOfWork
                .Vehicles
                .Remove(id);
        }
    }
}
