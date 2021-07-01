using SubmerchantAPI.Models;
using SubmerchantAPI.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public class ResponseCodeMasterRepository : IResponseCodeMaster<ResponseCodeMaster>
    {
        readonly SubmerchantDBContext _submerchantDBContext;

        public ResponseCodeMasterRepository(SubmerchantDBContext submerchantDBContext)
        {
            _submerchantDBContext = submerchantDBContext;
        }
        public IEnumerable<ResponseCodeMaster> GetAll()
        {
            return _submerchantDBContext.ResponseCodeMaster.ToList();
        }
    }
}
