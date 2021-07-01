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
    [Route("api/ResponseCode")]
    [ApiController]
    [EnableCors("CorsApiPolicy")]
    public class ResponseCodeController : ControllerBase
    {
        private readonly IResponseCodeMaster<ResponseCodeMaster> _dataRepository;

        public ResponseCodeController(IResponseCodeMaster<ResponseCodeMaster> repository)
        {
            _dataRepository = repository;
        }


        [HttpGet(Name = "GetAllResponseCode")]
        public IActionResult Get()
        {
            IEnumerable<ResponseCodeMaster> responseCode = _dataRepository.GetAll();
            return Ok(responseCode);
        }

    }




}
