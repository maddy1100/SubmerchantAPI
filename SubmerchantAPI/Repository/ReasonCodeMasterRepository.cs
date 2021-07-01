using SubmerchantAPI.Models;
using SubmerchantAPI.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public class ReasonCodeMasterRepository : IReasonCodeMaster<ReasonCodeMaster>
    {
        readonly SubmerchantDBContext _submerchantDBContext;

        public ReasonCodeMasterRepository(SubmerchantDBContext submerchantDBContext)
        {
            _submerchantDBContext = submerchantDBContext;
        }
        public IEnumerable<ReasonCodeMaster> GetAll()
        {
            return _submerchantDBContext.ReasonCodeMaster.ToList();
        }
    }
}
