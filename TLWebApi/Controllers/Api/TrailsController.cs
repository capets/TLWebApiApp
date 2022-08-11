using Microsoft.AspNetCore.Mvc;
using TLWebApi.Interfaces;
using TLWebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TLWebApi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrailsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TrailsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: api/<TrailsController>
        [HttpGet]
        public IEnumerable<Trail> Get()
        {
            return _unitOfWork
                .Trails
                .GetTrails();
        }

        // GET api/<TrailsController>/5
        [HttpGet("{id}")]
        public Trail Get(int id)
        {
            return _unitOfWork
                .Trails
                .GetTrail(id);
        }

        // POST api/<TrailsController>
        [HttpPost]
        public void Post([FromBody] Trail value)
        {
            _unitOfWork
                .Trails
                .Add(value);
        }

        // PUT api/<TrailsController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Trail value)
        {
            _unitOfWork
                .Trails
                .Update(value);
        }

        // DELETE api/<TrailsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _unitOfWork
                .Trails
                .Remove(id);
        }
    }
}
