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
    [Route("api/DirectDebit")]
    [ApiController]
    [EnableCors("CorsApiPolicy")]
    public class DirectDebitController : ControllerBase
    {
        private readonly IRepository<DirectDebit> _dataRepository;

        public DirectDebitController(IRepository<DirectDebit> repository)
        {
            _dataRepository = repository;
        }

        // GET: api/<DirectDebitController>
        [HttpGet(Name = "GetAllDirectDebit")]
        public IActionResult Get()
        {
            IEnumerable<DirectDebit> directDebits = _dataRepository.GetAll();
            return Ok(directDebits);
        }

        // GET api/<DirectDebitController>/5
        [HttpGet("{id}", Name = "GetDirectDebitById")]
        public IActionResult Get(int id)
        {
            DirectDebit directDebit = _dataRepository.GetById(id);
            if (directDebit == null)
            {
                return NotFound("The Primary Contact could not be found.");
            }
            return Ok(directDebit);
        }

        // POST api/<DirectDebitController>
        [HttpPost(Name = "PostDirectDebit")]
        public IActionResult Post([FromBody] DirectDebit directDebit)
        {
            if (ModelState.IsValid)
            {
                if (directDebit == null)
                {
                    return BadRequest("Primary Contact is null.");
                }
                _dataRepository.Insert(directDebit);
                return CreatedAtRoute(
                      new { Id = directDebit.PrimaryContactID },
                      directDebit);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // PUT api/<DirectDebitController>/5
        [HttpPut("{id}", Name = "PutDirectDebit")]
        public IActionResult Put(int id, [FromBody] DirectDebit directDebit)
        {
            if (ModelState.IsValid)
            {
                if (directDebit == null)
                {
                    return BadRequest("Employee is null.");
                }
                DirectDebit directDebitToUpdate = _dataRepository.GetById(id);
                if (directDebitToUpdate == null)
                {
                    return NotFound("The Employee record couldn't be found.");
                }
                _dataRepository.Update(directDebitToUpdate, directDebit);
                return NoContent();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // DELETE api/<DirectDebitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
