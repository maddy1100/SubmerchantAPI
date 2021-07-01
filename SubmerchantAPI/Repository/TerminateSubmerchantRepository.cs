using SubmerchantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public class TerminateSubmerchantRepository : ITerminateSubmerchant<TerminateSubmerchant>
    {


        readonly SubmerchantDBContext _submerchantDBContext;

        public TerminateSubmerchantRepository(SubmerchantDBContext submerchantDBContext)
        {
            _submerchantDBContext = submerchantDBContext;
        }
        public void Delete(string Id)
        {

            SubMerchantDetails getObjById = _submerchantDBContext.SubmerchantDetails.Where(x => x.SubMerchantID == Id).FirstOrDefault();
            getObjById.ApplicationStatus = 4;
            _submerchantDBContext.SaveChanges();

        }

        public void Insert(TerminateSubmerchant terminateSubmerchant)
        {
            _submerchantDBContext.TerminateSubmerchant.Add(terminateSubmerchant);
            _submerchantDBContext.SaveChanges();

        }

    }


}
