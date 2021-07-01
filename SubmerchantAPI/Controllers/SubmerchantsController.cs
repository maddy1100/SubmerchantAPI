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
    [Route("api/Submerchants")]
    [ApiController]
    [EnableCors("CorsApiPolicy")]
    public class SubmerchantsController : ControllerBase
    {
        private readonly ISearchRepository<SearchModel> _dataRepository;

        public SubmerchantsController(ISearchRepository<SearchModel> repository)
        {
            _dataRepository = repository;
        }

        [HttpGet(Name = "GetAllSubmerchant")]
        public IActionResult Get()
        {
            IEnumerable<SearchModel> search = _dataRepository.GetAll();
            if (search == null)
            {
                return NotFound("Submerchants result could not be found.");
            }
            return Ok(search);
        }

    }
}
