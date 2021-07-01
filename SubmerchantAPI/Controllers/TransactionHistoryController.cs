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
    [Route("api/TransactionHistory")]
    [ApiController]
    [EnableCors("CorsApiPolicy")]
    public class TransactionHistoryController : ControllerBase
    {
        private readonly ITransactionHistoryRepository<TransactionHistory> _dataRepository;

        public TransactionHistoryController(ITransactionHistoryRepository<TransactionHistory> repository)
        {
            _dataRepository = repository;
        }

        [HttpGet(Name = "GetAllTransactionHistory")]
        public IActionResult Get()
        {
            IEnumerable<TransactionHistory> search = _dataRepository.GetAllTransactionHistory();
            if (search == null)
            {
                return NotFound("Submerchants result could not be found.");
            }
            return Ok(search);
        }

        [HttpGet("{id}", Name = "GetTransactionHistoryById")]
        public IActionResult Get(int id)
        {
            IEnumerable<TransactionHistory> details = _dataRepository.GetById(id);
            if (details == null)
            {
                return NotFound("The Sub Merchant Post Processing Details could not be found.");
            }
            return Ok(details);
        }

    }
}
