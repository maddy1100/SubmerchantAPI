using SubmerchantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SubmerchantAPI.Models.DbModels;

namespace SubmerchantAPI.Repository
{
    public class AdditionalCustomerInformationRepository : IRepository<AdditionalCustomerInformation>
    {

        readonly SubmerchantDBContext _submerchantDBContext;

        public AdditionalCustomerInformationRepository(SubmerchantDBContext submerchantDBContext)
        {
            _submerchantDBContext = submerchantDBContext;
        }

        public void Delete(object Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(AdditionalCustomerInformation obj)
        {
            _submerchantDBContext.CustomerInformation.Add(obj);
            _submerchantDBContext.SaveChanges();
        }

        public void Update(AdditionalCustomerInformation DBobj, AdditionalCustomerInformation obj)
        {
            DBobj.AverageTransactionValue = obj.AverageTransactionValue;
            DBobj.CurrentProvider = obj.CurrentProvider;
            DBobj.TotalCreditCardSales = obj.TotalCreditCardSales;
            DBobj.NoticePeriod = obj.NoticePeriod;
            DBobj.NA = obj.NA;
            DBobj.PrimaryContacts = obj.PrimaryContacts;
            DBobj.ProjectedAnnualCardTurnover = obj.ProjectedAnnualCardTurnover;
            DBobj.ProjectedAnnualTurnover = obj.ProjectedAnnualTurnover;
            DBobj.RealisticMaxTransactionValue = obj.RealisticMaxTransactionValue;
            DBobj.RealisticMinTransactionValue = obj.RealisticMinTransactionValue;
            DBobj.SettlementAmount = obj.SettlementAmount;
            _submerchantDBContext.SaveChanges();
        }

        IEnumerable<AdditionalCustomerInformation> IRepository<AdditionalCustomerInformation>.GetAll()
        {
            return _submerchantDBContext.CustomerInformation.ToList();
        }

        AdditionalCustomerInformation IRepository<AdditionalCustomerInformation>.GetById(object Id)
        {
            return _submerchantDBContext.CustomerInformation.FirstOrDefault(e => e.PrimaryContactID == Convert.ToInt64(Id));
        }
    }
}
