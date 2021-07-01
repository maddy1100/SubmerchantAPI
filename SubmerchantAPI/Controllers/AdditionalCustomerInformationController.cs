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
    [Route("api/AdditionalCustomerInformation")]
    [ApiController]
    [EnableCors("CorsApiPolicy")]
    public class AdditionalCustomerInformationController : ControllerBase
    {
        private readonly IRepository<AdditionalCustomerInformation> _dataRepository;

        public AdditionalCustomerInformationController(IRepository<AdditionalCustomerInformation> repository)
        {
            _dataRepository = repository;
        }

        // GET: api/<AdditionalCustomerInformationController>
        [HttpGet(Name = "GetAllAdditionalCustomerInformation")]
        // [EnableCors("ApiCorsPolicy")]
        public IActionResult Get()
        {
            IEnumerable<AdditionalCustomerInformation> primaryContacts = _dataRepository.GetAll();
            return Ok(primaryContacts);
        }

        // GET api/<AdditionalCustomerInformationController>/5
        [HttpGet("{id}", Name = "GetAdditionalCustomerInformationById")]
        // [EnableCors("ApiCorsPolicy")]
        public IActionResult Get(int id)
        {
            AdditionalCustomerInformation contact = _dataRepository.GetById(id);
            if (contact == null)
            {
                return NotFound("The Primary Contact could not be found.");
            }
            return Ok(contact);
        }

        // POST api/<AdditionalCustomerInformationController>
        [HttpPost(Name = "PostAdditionalCustomerInformation")]
        // [EnableCors("ApiCorsPolicy")]
        public IActionResult Post([FromBody] AdditionalCustomerInformation contact)
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

        // PUT api/<AdditionalCustomerInformationController>/5
        [HttpPut("{id}", Name = ("PutAdditionalCustomerInformation"))]
        // [EnableCors("ApiCorsPolicy")]
        public IActionResult Put(int id, [FromBody] AdditionalCustomerInformation additionalCustomer)
        {
            if (ModelState.IsValid)
            {
                if (additionalCustomer == null)
                {
                    return BadRequest("Employee is null.");
                }
                AdditionalCustomerInformation customerInformationToUpdate = _dataRepository.GetById(id);
                if (customerInformationToUpdate == null)
                {
                    return NotFound("The Employee record couldn't be found.");
                }
                _dataRepository.Update(customerInformationToUpdate, additionalCustomer);
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
