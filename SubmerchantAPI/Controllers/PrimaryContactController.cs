using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SubmerchantAPI.Filters;
using SubmerchantAPI.Models;
using SubmerchantAPI.Models.DbModels;
using SubmerchantAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SubmerchantAPI.Controllers
{
    [Route("api/PrimaryContact")]
    [ApiController]
    [EnableCors("CorsApiPolicy")]
    public class PrimaryContactController : ControllerBase
    {
        private readonly IRepository<PrimaryContact> _dataRepository;

        public PrimaryContactController(IRepository<PrimaryContact> repository)
        {
            _dataRepository = repository;
        }


        // GET: api/Employee
        [HttpGet(Name = "GetAllPrimaryContacts")]
        //[CustomAuthorization]
        //[EnableCors("ApiCorsPolicy")]
        public IActionResult Get()
        {
            IEnumerable<PrimaryContact> primaryContacts = _dataRepository.GetAll();
            return Ok(primaryContacts);
        }


        // GET: api/PrimaryContact/5
        [HttpGet("{id}", Name = "GetPrimaryContactsById")]
        // [EnableCors("ApiCorsPolicy")]
        public IActionResult Get(int id)
        {
            PrimaryContact contact = _dataRepository.GetById(id);
            if (contact == null)
            {
                return NotFound("The Primary Contact could not be found.");
            }
            return Ok(contact);
        }
        // POST: api/PrimaryContact
        [HttpPost(Name = "PostPrimaryContact")]
        //[EnableCors("ApiCorsPolicy")]
        public IActionResult Post([FromBody] PrimaryContact contact)
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

        [HttpPut("{id}")]
        // [EnableCors("ApiCorsPolicy")]
        public IActionResult Put(int id, [FromBody] PrimaryContact contact)
        {
            if (ModelState.IsValid)
            {
                if (contact == null)
                {
                    return BadRequest("Employee is null.");
                }
                PrimaryContact contactToUpdate = _dataRepository.GetById(id);
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

        // DELETE api/<AdditionalCustomerInformationController>/5
        [HttpDelete("{id}")]
        //[EnableCors("ApiCorsPolicy")]
        public void Delete(int id)
        {
        }

    }
}
