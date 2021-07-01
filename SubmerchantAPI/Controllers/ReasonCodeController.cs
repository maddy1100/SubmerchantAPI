using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SubmerchantAPI.Models.DbModels;
using SubmerchantAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Controllers
{
    [Route("api/ReasonCode")]
    [ApiController]
    [EnableCors("CorsApiPolicy")]
    public class ReasonCodeController : ControllerBase
    {
        private readonly IReasonCodeMaster<ReasonCodeMaster> _dataRepository;

        public ReasonCodeController(IReasonCodeMaster<ReasonCodeMaster> repository)
        {
            _dataRepository = repository;
        }


        [HttpGet(Name = "GetAllReasonCode")]
        public IActionResult Get()
        {
            IEnumerable<ReasonCodeMaster> responseCode = _dataRepository.GetAll();
            return Ok(responseCode);
        }

    }




}
