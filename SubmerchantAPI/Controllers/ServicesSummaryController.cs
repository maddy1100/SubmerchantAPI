using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SubmerchantAPI.Models.DbModels;
using SubmerchantAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SubmerchantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsApiPolicy")]
    public class ServicesSummaryController : ControllerBase
    {
        private readonly IRepository<ServicesSummary> _dataRepository;

        public ServicesSummaryController(IRepository<ServicesSummary> repository)
        {
            _dataRepository = repository;
        }

        // GET: api/<ServicesSummaryController>
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<ServicesSummary> details = _dataRepository.GetAll();
            return Ok(details);
        }

        // GET api/<ServicesSummaryController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ServicesSummary details = _dataRepository.GetById(id);
            if (details == null)
            {
                return NotFound("The Sub Merchant Post Processing Details could not be found.");
            }
            return Ok(details);
        }

        // POST api/<ServicesSummaryController>
        [HttpPost]
        public IActionResult Post([FromBody] ServicesSummary details)
        {
            if (ModelState.IsValid)
            {
                if (details == null)
                {
                    return BadRequest("Sub Merchant Post Processing Details is null.");
                }
                _dataRepository.Insert(details);
                return CreatedAtRoute(
                      new { Id = details.PrimaryContactID },
                      details);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // PUT api/<ServicesSummaryController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ServicesSummary contact)
        {
            if (ModelState.IsValid)
            {
                if (contact == null)
                {
                    return BadRequest("Employee is null.");
                }
                ServicesSummary contactToUpdate = _dataRepository.GetById(id);
                if (contactToUpdate == null)
                {
                    return NotFound("The Employee record couldn't be found.");
                }
                _dataRepository.Update(contactToUpdate, contact);
                return NoContent();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // DELETE api/<ServicesSummaryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
