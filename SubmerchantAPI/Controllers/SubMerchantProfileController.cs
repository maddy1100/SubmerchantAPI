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
    public class SubMerchantProfileController : ControllerBase
    {
        private readonly ISubMerchantProfile<SubMerchantProfile> _dataRepository;

        public SubMerchantProfileController(ISubMerchantProfile<SubMerchantProfile> repository)
        {
            _dataRepository = repository;
        }

        [HttpGet("{id}", Name = "GetDeleteSubMerchantProfileById")]
        // [EnableCors("ApiCorsPolicy")]
        public IActionResult Get(long id)
        {
            IEnumerable<SubMerchantProfile> contact = _dataRepository.GetDataById(id);
            if (contact == null)
            {
                return NotFound("The DeleteSubMerchantProfile could not be found.");
            }
            return Ok(contact);

        }
    }
}
