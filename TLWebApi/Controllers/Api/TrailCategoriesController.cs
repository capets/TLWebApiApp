using Microsoft.AspNetCore.Mvc;
using TLWebApi.Interfaces;
using TLWebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TLWebApi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrailCategoriesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrailCategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/<VehicleCategoriesController>
        [HttpGet]
        public IEnumerable<TrailCategory> Get()
        {
            return _unitOfWork
                .TrailCategories
                .GetTrailCategories();
        }

        // GET api/<VehicleCategoriesController>/5
        [HttpGet("{id}")]
        public TrailCategory Get(int id)
        {
            return _unitOfWork
                .TrailCategories
                .GetTrailCategory(id);
        }

        // POST api/<VehicleCategoriesController>
        [HttpPost]
        public void Post([FromBody] TrailCategory value)
        {
            _unitOfWork
                .TrailCategories
                .Add(value);
        }

        // PUT api/<VehicleCategoriesController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] TrailCategory value)
        {
            _unitOfWork
                .TrailCategories
                .Update(value);
        }

        // DELETE api/<VehicleCategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _unitOfWork
                .TrailCategories
                .Remove(id);
        }
    }
}
