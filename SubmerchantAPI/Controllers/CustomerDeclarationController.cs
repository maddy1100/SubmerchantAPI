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
    [Route("api/CustomerDeclaration")]
    [ApiController]
    [EnableCors("CorsApiPolicy")]
    public class CustomerDeclarationController : ControllerBase
    {

        private readonly IRepository<CustomerDeclaration> _dataRepository;

        public CustomerDeclarationController(IRepository<CustomerDeclaration> repository)
        {
            _dataRepository = repository;
        }

        // GET: api/<CustomerDeclarationController>
        [HttpGet(Name = "GetAllCustomerDeclaration")]
        public IActionResult Get()
        {
            IEnumerable<CustomerDeclaration> customerDeclaration = _dataRepository.GetAll();
            return Ok(customerDeclaration);
        }

        // GET api/<CustomerDeclarationController>/5
        [HttpGet("{id}", Name = "GetCustomerDeclarationById")]
        public IActionResult Get(int id)
        {
            CustomerDeclaration declaration = _dataRepository.GetById(id);
            if (declaration == null)
            {
                return NotFound("The Primary Contact could not be found.");
            }
            return Ok(declaration);
        }

        // POST api/<CustomerDeclarationController>
        [HttpPost(Name = "PostCustomerDeclaration")]
        public IActionResult Post([FromBody] CustomerDeclaration declaration)
        {
            if (ModelState.IsValid)
            {
                if (declaration == null)
                {
                    return BadRequest("Primary Contact is null.");
                }
                _dataRepository.Insert(declaration);
                return CreatedAtRoute(
                      new { Id = declaration.PrimaryContactID },
                      declaration);

            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // PUT api/<CustomerDeclarationController>/5
        [HttpPut("{id}", Name = "PutCustomerDeclaration")]
        public IActionResult Put(int id, [FromBody] CustomerDeclaration declaration)
        {
            if (ModelState.IsValid)
            {
                if (declaration == null)
                {
                    return BadRequest("Employee is null.");
                }
                CustomerDeclaration declarationToUpdate = _dataRepository.GetById(id);
                if (declarationToUpdate == null)
                {
                    return NotFound("The Employee record couldn't be found.");
                }
                _dataRepository.Update(declarationToUpdate, declaration);
                return NoContent();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // DELETE api/<CustomerDeclarationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
