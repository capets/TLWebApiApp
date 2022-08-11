using Microsoft.AspNetCore.Mvc;
using TLWebApi.Interfaces;
using TLWebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TLWebApi.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoTypesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AutoTypesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: api/<AutoTypesController>
        [HttpGet]
        public IEnumerable<AutoType> Get()
        {
            return _unitOfWork
                .AutoTypes
                .GetAutoTypes();
        }

        // GET api/<AutoTypesController>/5
        [HttpGet("{id}")]
        public AutoType Get(int id)
        {
            return _unitOfWork
                .AutoTypes
                .GetAutoType(id);
        }

        // POST api/<AutoTypesController>
        [HttpPost]
        public void Post([FromBody] AutoType value)
        {
            _unitOfWork
                .AutoTypes
                .Add(value);
        }

        // PUT api/<AutoTypesController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] AutoType value)
        {
            _unitOfWork
                .AutoTypes
                .Update(value);
        }

        // DELETE api/<AutoTypesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _unitOfWork
                .AutoTypes
                .Remove(id);
        }
    }
}
