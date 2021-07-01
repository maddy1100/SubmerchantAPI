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
    public class SearchController : ControllerBase
    {
        private readonly ISearchRepository<SearchModel> _dataRepository;

        public SearchController(ISearchRepository<SearchModel> repository)
        {
            _dataRepository = repository;
        }


        [HttpGet("{searchTerm}", Name = "GetSearch")]
        public IActionResult Get(string searchTerm)
        {
            IEnumerable<SearchModel> search = _dataRepository.Serach(searchTerm);
            if (search == null || search.Count() == 0)
            {
                return NotFound("Search result could not be found.");
            }
            return Ok(search);
        }

        [HttpGet(Name = "GetAll")]
        public IActionResult Get()
        {
            IEnumerable<SearchModel> search = _dataRepository.GetAll();
            if (search == null)
            {
                return NotFound("Search result could not be found.");
            }
            return Ok(search);
        }

        [HttpPost(Name = "PostAdvanceSearch")]
        public IActionResult Post([FromBody] SearchModel contact)
        {
            if (ModelState.IsValid)
            {
                if (contact == null)
                {
                    return BadRequest("Search model is null.");
                }
                IEnumerable<SearchModel> search = _dataRepository.AdvanceSearch(contact);
                return CreatedAtRoute(
                      new { Id = contact.PrimaryContactID },
                      search);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}
