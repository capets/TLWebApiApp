using Microsoft.AspNetCore.Mvc;
using TLWebApi.Interfaces;
using TLWebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TLWebApi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleCategoriesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public VehicleCategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: api/<VehicleCategoriesController>
        [HttpGet]
        public IEnumerable<VehicleCategory> Get()
        {
            return _unitOfWork
                .VehicleCategories
                .VehicleCategories();
        }

        // GET api/<VehicleCategoriesController>/5
        [HttpGet("{id}")]
        public VehicleCategory Get(int id)
        {
            return _unitOfWork
                .VehicleCategories
                .VehicleCategory(id);
        }

        // POST api/<VehicleCategoriesController>
        [HttpPost]
        public void Post([FromBody] VehicleCategory value)
        {
            _unitOfWork
                .VehicleCategories
                .Add(value);
        }

        // PUT api/<VehicleCategoriesController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] VehicleCategory value)
        {
            _unitOfWork
                .VehicleCategories
                .Update(value);
        }

        // DELETE api/<VehicleCategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _unitOfWork
                .VehicleCategories
                .Remove(id);
        }
    }
}
