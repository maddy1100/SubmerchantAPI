using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SubmerchantAPI.Models;
using SubmerchantAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SubmerchantAPI.Controllers
{
    [Route("api/PostProcessingDetails")]
    [ApiController]
    [EnableCors("CorsApiPolicy")]
    public class SubMerchantPostProcessingController : ControllerBase
    {
        private readonly IRepository<SubMerchantDetails> _dataRepository;

        public SubMerchantPostProcessingController(IRepository<SubMerchantDetails> repository)
        {
            _dataRepository = repository;
        }

        // GET: api/SubMerchantPostProcessingDetails
        [HttpGet(Name = "GetAllPostProcessingDetails")]
        public IActionResult Get()
        {
            IEnumerable<SubMerchantDetails> details = _dataRepository.GetAll();
            return Ok(details);
        }


        // GET: api/SubMerchantPostProcessingDetails/5
        [HttpGet("{id}", Name = "GetPostProcessingDetailsById")]
        public IActionResult Get(int id)
        {
            SubMerchantDetails details = _dataRepository.GetById(id);
            if (details == null)
            {
                return NotFound("The Sub Merchant Post Processing Details could not be found.");
            }
            return Ok(details);
        }
        // POST: api/SubMerchantPostProcessingDetails
        [HttpPost(Name = "POSTPostProcessingDetails")]
        public IActionResult Post([FromBody] SubMerchantDetails details)
        {
            if (ModelState.IsValid)
            {
                if (details == null)
                {
                    return BadRequest("Sub Merchant Post Processing Details is null.");
                }
                _dataRepository.Insert(details);
                return CreatedAtRoute(
                      new { Id = details.SubMerchantID },
                      details);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        [HttpPut]
        public IActionResult Put(int id, [FromBody] SubMerchantDetails contact)
        {
            if (ModelState.IsValid)
            {
                if (contact == null)
                {
                    return BadRequest("Employee is null.");
                }
                SubMerchantDetails contactToUpdate = _dataRepository.GetById(id);
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
    }
}
