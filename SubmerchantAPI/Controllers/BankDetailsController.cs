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
    [Route("api/BankDetails")]
    [ApiController]
    [EnableCors("CorsApiPolicy")]
    public class BankDetailsController : ControllerBase
    {
        private readonly IRepository<BankDetails> _dataRepository;

        public BankDetailsController(IRepository<BankDetails> repository)
        {
            _dataRepository = repository;
        }

        // GET: api/BankDetails
        [HttpGet(Name = "GetAllBankDetails")]
        public IActionResult Get()
        {
            IEnumerable<BankDetails> details = _dataRepository.GetAll();
            return Ok(details);
        }
        // GET: api/BankDetails/5
        [HttpGet("{id}", Name = "GetBankDetails")]
        public IActionResult Get(int id)
        {
            BankDetails details = _dataRepository.GetById(id);
            if (details == null)
            {
                return NotFound("The Bank Details could not be found.");
            }
            return Ok(details);
        }
        // POST: api/BankDetails
        [HttpPost]
        public IActionResult Post([FromBody] BankDetails details)
        {
            if (ModelState.IsValid)
            {
                if (details == null)
                {
                    return BadRequest("Bank Details are null.");
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
        //PUT: api/BankDetails/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] BankDetails details)
        {
            if (ModelState.IsValid)
            {
                if (details == null)
                {
                    return BadRequest("Bank Details are null.");
                }
                BankDetails detailsToUpdate = _dataRepository.GetById(id);
                if (detailsToUpdate == null)
                {
                    return NotFound("The Bank Details could not be found.");
                }
                _dataRepository.Update(detailsToUpdate, details);
                return NoContent();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        // DELETE: api/BankDetails/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            BankDetails details = _dataRepository.GetById(id);
            if (details == null)
            {
                return NotFound("The Bank Details could not be found.");
            }
            _dataRepository.Delete(details);
            return NoContent();
        }
    }
}
