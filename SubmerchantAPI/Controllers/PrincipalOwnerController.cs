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
    [Route("api/PrincipalOwner")]
    [ApiController]
    [EnableCors("CorsApiPolicy")]
    public class PrincipalOwnerController : ControllerBase
    {
        private readonly IRepository<PrincipalOwner> _dataRepository;

        public PrincipalOwnerController(IRepository<PrincipalOwner> repository)
        {
            _dataRepository = repository;
        }

        // GET: api/<PrincipalOwnerController>
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<PrincipalOwner> details = _dataRepository.GetAll();
            return Ok(details);
        }

        // GET api/<PrincipalOwnerController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            PrincipalOwner details = _dataRepository.GetById(id);
            if (details == null)
            {
                return NotFound("The Principal Owner Details could not be found.");
            }
            return Ok(details);
        }

        // POST api/<PrincipalOwnerController>
        [HttpPost]
        public IActionResult Post([FromBody] PrincipalOwner details)
        {
            if (ModelState.IsValid)
            {
                if (details == null)
                {
                    return BadRequest("Principal Owner Details is null.");
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

        // PUT api/<PrincipalOwnerController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] PrincipalOwner contact)
        {
            if (contact == null)
            {
                return BadRequest("Employee is null.");
            }
            PrincipalOwner contactToUpdate = _dataRepository.GetById(id);
            if (contactToUpdate == null)
            {
                return NotFound("The Principal Owner record couldn't be found.");
            }
            _dataRepository.Update(contactToUpdate, contact);
            return NoContent();
        }

        // DELETE api/<PrincipalOwnerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
