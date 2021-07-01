using SubmerchantAPI.Models;
using SubmerchantAPI.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public class MerchantAccountConfigurationRepository : IRepository<MerchantAccountConfiguration>
    {
        readonly SubmerchantDBContext _submerchantDBContext;

        public MerchantAccountConfigurationRepository(SubmerchantDBContext submerchantDBContext)
        {
            _submerchantDBContext = submerchantDBContext;
        }

        public void Delete(object Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MerchantAccountConfiguration> GetAll()
        {
            return _submerchantDBContext.MerchantAccountConfigurations.ToList();
        }

        public MerchantAccountConfiguration GetById(object Id)
        {
            return _submerchantDBContext.MerchantAccountConfigurations.FirstOrDefault(e => e.PrimaryContactID == Convert.ToInt64(Id));
        }

        public void Insert(MerchantAccountConfiguration obj)
        {
            _submerchantDBContext.MerchantAccountConfigurations.Add(obj);
            _submerchantDBContext.SaveChanges();
        }

        public void Update(MerchantAccountConfiguration DBobj, MerchantAccountConfiguration obj)
        {
            DBobj.PrimaryContacts = obj.PrimaryContacts;
            DBobj.TillReceipts = obj.TillReceipts;
            DBobj.AmericanExpressID = obj.AmericanExpressID;
            DBobj.AreaCode = obj.AreaCode;
            DBobj.Landline = obj.Landline;
            DBobj.MerchantAccountNumber = obj.MerchantAccountNumber;
            DBobj.MerchantBankAcquirer = obj.MerchantBankAcquirer;
            DBobj.OutgoingCall = obj.OutgoingCall;
            _submerchantDBContext.SaveChanges();
        }
    }
}
