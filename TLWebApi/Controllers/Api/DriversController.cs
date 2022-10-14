using Microsoft.AspNetCore.Mvc;
using TLWebApi.Data;
using TLWebApi.Interfaces;
using TLWebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TLWebApi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DriversController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/<DriversController>
        [HttpGet]
        public IEnumerable<Driver> Get()
        {
            return _unitOfWork.Drivers
                .GetDrivers().ToList();
        }

        // GET api/<DriversController>/5
        [HttpGet("{id}")]
        public Driver Get(int id)
        {
            return _unitOfWork.Drivers
                .GetDriver(id);              
        }

        // POST api/<DriversController>
        [HttpPost]
        public void Post([FromBody] Driver value)
        {
            _unitOfWork.Drivers.Add(value);            
        }

        // PUT api/<DriversController>/5
        [HttpPut]
        public void Put([FromBody] Driver value)
        {
            _unitOfWork.Drivers
                .Update(value);
        }

        // DELETE api/<DriversController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _unitOfWork.Drivers
               .Remove(id);
        }
    }
}
