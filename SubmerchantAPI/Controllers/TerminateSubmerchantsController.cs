using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SubmerchantAPI.Models;
using SubmerchantAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsApiPolicy")]
    public class TerminateSubmerchantsController : ControllerBase
    {
        private readonly ITerminateSubmerchant<TerminateSubmerchant> _dataRepository;

        public TerminateSubmerchantsController(ITerminateSubmerchant<TerminateSubmerchant> repository)
        {
            _dataRepository = repository;
        }

        [HttpPost]
        public IActionResult Delete([FromBody] TerminateSubmerchant terminateSubmerchant)
        {
            if (ModelState.IsValid)
            {
                if (terminateSubmerchant == null)
                {
                    return BadRequest("TerminateSubmerchant details is null.");
                }
                _dataRepository.Insert(terminateSubmerchant);
                var Id = terminateSubmerchant.SubMerchantID;
                _dataRepository.Delete(Id);
            }
            else
            {
                return BadRequest(ModelState);
            }
            return NoContent();
        }
    }
}
