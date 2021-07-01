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
    [Route("api/MerchantAccountConfiguration")]
    [ApiController]
    [EnableCors("CorsApiPolicy")]
    public class MerchantAccountConfigurationController : ControllerBase
    {
        private readonly IRepository<MerchantAccountConfiguration> _dataRepository;

        public MerchantAccountConfigurationController(IRepository<MerchantAccountConfiguration> repository)
        {
            _dataRepository = repository;
        }

        // GET: api/<MerchantAccountConfigurationController>
        [HttpGet]
        public IActionResult  Get()
        {
            IEnumerable<MerchantAccountConfiguration> merchantAccountConfigurations = _dataRepository.GetAll();
            return Ok(merchantAccountConfigurations);
        }

        // GET api/<MerchantAccountConfigurationController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            MerchantAccountConfiguration contact = _dataRepository.GetById(id);
            if (contact == null)
            {
                return NotFound("The Primary Contact could not be found.");
            }
            return Ok(contact);
        }

        // POST api/<MerchantAccountConfigurationController>
        [HttpPost]
        public IActionResult Post([FromBody] MerchantAccountConfiguration contact)
        {
            if (ModelState.IsValid)
            {
                if (contact == null)
                {
                    return BadRequest("Primary Contact is null.");
                }
                _dataRepository.Insert(contact);
                return CreatedAtRoute(
                      new { Id = contact.PrimaryContactID },
                      contact);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // PUT api/<MerchantAccountConfigurationController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] MerchantAccountConfiguration contact)
        {
            if (contact == null)
            {
                return BadRequest("Employee is null.");
            }
            MerchantAccountConfiguration contactToUpdate = _dataRepository.GetById(id);
            if (contactToUpdate == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }
            _dataRepository.Update(contactToUpdate, contact);
            return NoContent();
        }

        // DELETE api/<MerchantAccountConfigurationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
