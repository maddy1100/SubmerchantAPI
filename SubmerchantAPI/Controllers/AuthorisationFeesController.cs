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
    [Route("api/AuthorisationFees")]
    [ApiController]
    [EnableCors("CorsApiPolicy")]
    public class AuthorisationFeesController : ControllerBase
    {
        private readonly IRepository<AuthorisationFees> _dataRepository;

        public AuthorisationFeesController(IRepository<AuthorisationFees> repository)
        {
            _dataRepository = repository;
        }


        // GET: api/<AuthorisationFeesController>
       
        [HttpGet(Name = "GetAllAuthorisationFees")]
        //[CustomAuthorization]
        //[EnableCors("ApiCorsPolicy")]
        public IActionResult Get()
        {
            IEnumerable<AuthorisationFees> primaryContacts = _dataRepository.GetAll();
            return Ok(primaryContacts);
        }

        // GET api/<AuthorisationFeesController>/5
        [HttpGet("{id}", Name = "GetAuthorisationFeesById")]
        // [EnableCors("ApiCorsPolicy")]
        public IActionResult Get(int id)
        {
            AuthorisationFees contact = _dataRepository.GetById(id);
            if (contact == null)
            {
                return NotFound("The AuthorisationFees could not be found.");
            }
            return Ok(contact);
        }

        // POST api/<AuthorisationFeesController>
        [HttpPost(Name = "PostAuthorisationFees")]
        //[EnableCors("ApiCorsPolicy")]
        public IActionResult Post([FromBody] AuthorisationFees contact)
        {
            if (ModelState.IsValid)
            {
                if (contact == null)
                {
                    return BadRequest("AuthorisationFees is null.");
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

        // PUT api/<AuthorisationFeesController>/5
        [HttpPut("{id}")]
        // [EnableCors("ApiCorsPolicy")]
        public IActionResult Put(int id, [FromBody] AuthorisationFees contact)
        {
            if (ModelState.IsValid)
            {
                if (contact == null)
                {
                    return BadRequest("Employee is null.");
                }
                AuthorisationFees contactToUpdate = _dataRepository.GetById(id);
                if (contactToUpdate == null)
                {
                    return NotFound("The AuthorisationFees couldn't be found.");
                }
                _dataRepository.Update(contactToUpdate, contact);
                return NoContent();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // DELETE api/<AuthorisationFeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
