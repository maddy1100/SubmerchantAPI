using SubmerchantAPI.Models;
using SubmerchantAPI.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public class AuthorisationFeesRepository : IRepository<AuthorisationFees>
    {

        readonly SubmerchantDBContext _submerchantDBContext;

        public AuthorisationFeesRepository(SubmerchantDBContext submerchantDBContext)
        {
            _submerchantDBContext = submerchantDBContext;
        }
        public void Delete(object Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AuthorisationFees> GetAll()
        {
            return _submerchantDBContext.AuthorisationFees.ToList();
        }

        public AuthorisationFees GetById(object Id)
        {
            return _submerchantDBContext.AuthorisationFees.FirstOrDefault(e => e.PrimaryContactID == Convert.ToInt64(Id));

        }

        public void Insert(AuthorisationFees obj)
        {
            _submerchantDBContext.AuthorisationFees.Add(obj);
            _submerchantDBContext.SaveChanges();
        }

        public void Update(AuthorisationFees DBobj, AuthorisationFees obj)
        {

            DBobj.AdministrationFee = obj.AdministrationFee;
            DBobj.AuthorisationfeePerTrasaction = obj.AuthorisationfeePerTrasaction;
            DBobj.AuthorisationPP = obj.AuthorisationPP;
            DBobj.ChargebackFee = obj.ChargebackFee;
            DBobj.FasterPaymentsFee = obj.FasterPaymentsFee;
            DBobj.LatePaymentORReturnedDirectDebitFee = obj.LatePaymentORReturnedDirectDebitFee;
            DBobj.MinimumMerchantServiceCharge = obj.MinimumMerchantServiceCharge;
            DBobj.MonthlyPaperStatementFee = obj.MonthlyPaperStatementFee;
            DBobj.PCINonComplianceFee4 = obj.PCINonComplianceFee4;
            DBobj.PCIServiceFee3 = obj.PCIServiceFee3;
            DBobj.PrimaryContacts = obj.PrimaryContacts;
            DBobj.TerminalRecoveryFee = obj.TerminalRecoveryFee;
            _submerchantDBContext.SaveChanges();
        }
    }
}
