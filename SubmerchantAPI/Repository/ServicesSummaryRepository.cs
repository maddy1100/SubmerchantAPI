using SubmerchantAPI.Models;
using SubmerchantAPI.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public class ServicesSummaryRepository : IRepository<ServicesSummary>
    {
        readonly SubmerchantDBContext _submerchantDBContext;

        public ServicesSummaryRepository(SubmerchantDBContext submerchantDBContext)
        {
            _submerchantDBContext = submerchantDBContext;
        }

        public void Delete(object Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ServicesSummary> GetAll()
        {
            return _submerchantDBContext.ServicesSummaries.ToList();
        }

        public ServicesSummary GetById(object Id)
        {
            return _submerchantDBContext.ServicesSummaries.FirstOrDefault(e => e.PrimaryContactID == Convert.ToInt64(Id));
        }

        public void Insert(ServicesSummary obj)
        {
            _submerchantDBContext.ServicesSummaries.Add(obj);
            _submerchantDBContext.SaveChanges();
        }

        public void Update(ServicesSummary DBobj, ServicesSummary obj)
        {
            DBobj.MerchantRates_AuthorisationFee = obj.MerchantRates_AuthorisationFee;
            DBobj.MerchantRates_CreditCard = obj.MerchantRates_CreditCard;
            DBobj.MerchantRates_DebitCard = obj.MerchantRates_DebitCard;
            DBobj.MerchantRates_MinimumMonthlyServiceFee = obj.MerchantRates_MinimumMonthlyServiceFee;
            DBobj.PrimaryContacts = obj.PrimaryContacts;
            DBobj.SetUpFee_AmexFee = obj.SetUpFee_AmexFee;
            DBobj.SetUpFee_FeeAmount = obj.SetUpFee_FeeAmount;
            DBobj.Terminal_ContractPeriod = obj.Terminal_ContractPeriod;
            DBobj.Terminal_Model = obj.Terminal_Model;
            DBobj.Terminal_MonthlyRental = obj.Terminal_MonthlyRental;

            _submerchantDBContext.SaveChanges();
        }
    }
}
