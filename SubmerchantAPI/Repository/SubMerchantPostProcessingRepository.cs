using SubmerchantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public class SubMerchantPostProcessingRepository : IRepository<SubMerchantDetails>
    {

        readonly SubmerchantDBContext _submerchantDBContext;

        public SubMerchantPostProcessingRepository(SubmerchantDBContext submerchantDBContext)
        {
            _submerchantDBContext = submerchantDBContext;
        }
        public void Delete(object Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubMerchantDetails> GetAll()
        {
            return _submerchantDBContext.SubmerchantDetails.ToList();
        }


        public SubMerchantDetails GetById(object Id)
        {
            return _submerchantDBContext.SubmerchantDetails.FirstOrDefault(p => p.PrimaryContactID == Convert.ToInt64(Id));
        }

        public void Insert(SubMerchantDetails obj)
        {
            _submerchantDBContext.SubmerchantDetails.Add(obj);
            _submerchantDBContext.SaveChanges();
        }


        public void Update(SubMerchantDetails DBobj, SubMerchantDetails obj)
        {
            DBobj.ApplicationStatus = obj.ApplicationStatus;
            DBobj.DataValidationStatus = obj.DataValidationStatus;
            DBobj.PostUnderwritingSuccess = obj.PostUnderwritingSuccess;
            DBobj.PrimaryContacts = obj.PrimaryContacts;
            DBobj.SubMerchantID = obj.SubMerchantID;
            // DBobj.TotalCreditCardSales = obj.TotalCreditCardSales;
            DBobj.ValidationFailureReason = obj.ValidationFailureReason;
            _submerchantDBContext.SaveChanges();
        }

    }
}


