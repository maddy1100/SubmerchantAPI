using SubmerchantAPI.Models;
using SubmerchantAPI.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public class ScheduleOfFeesPartner_UKRepository : IRepository<ScheduleOfFeesPartner_UK>
    {
        readonly SubmerchantDBContext _submerchantDBContext;

        public ScheduleOfFeesPartner_UKRepository(SubmerchantDBContext submerchantDBContext)
        {
            _submerchantDBContext = submerchantDBContext;
        }

        public void Delete(object Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ScheduleOfFeesPartner_UK> GetAll()
        {
            return _submerchantDBContext.ScheduleOfFeesPartners.ToList();
        }

        public ScheduleOfFeesPartner_UK GetById(object Id)
        {
            return _submerchantDBContext.ScheduleOfFeesPartners.FirstOrDefault(e => e.PrimaryContactID == Convert.ToInt64(Id));
        }

        public void Insert(ScheduleOfFeesPartner_UK obj)
        {
            _submerchantDBContext.ScheduleOfFeesPartners.Add(obj);
            _submerchantDBContext.SaveChanges();
        }

        public void Update(ScheduleOfFeesPartner_UK DBobj, ScheduleOfFeesPartner_UK obj)
        {
            DBobj.DinersCardSecureRate = obj.DinersCardSecureRate;
            DBobj.InternationalMaestroCardSecureRate = obj.InternationalMaestroCardSecureRate;
            DBobj.JCBCardSecureRate = obj.JCBCardSecureRate;
            DBobj.MasterCardBusinessCardSecureRate = obj.MasterCardBusinessCardSecureRate;
            DBobj.MasterCardCorporateCardSecureRate = obj.MasterCardCorporateCardSecureRate;
            DBobj.MasterCardCreditCardSecureRate = obj.MasterCardCreditCardSecureRate;
            DBobj.MasterCardDebitCardSecureRate = obj.MasterCardDebitCardSecureRate;
            DBobj.MasterCardFleetCardSecureRate = obj.MasterCardFleetCardSecureRate;
            DBobj.MasterCardPrePaidCommercialCardSecureRate = obj.MasterCardPrePaidCommercialCardSecureRate;
            DBobj.MasterCardPurchasingCardSecureRate = obj.MasterCardPurchasingCardSecureRate;
            DBobj.NonEEAMasterCardCreditCardSecureRate = obj.NonEEAMasterCardCreditCardSecureRate;
            DBobj.NonEEAVisaCardSecureRate = obj.NonEEAVisaCardSecureRate;
            //DBobj.PartnersUKID = obj.PartnersUKID;
           // DBobj.PrimaryContactID = obj.PrimaryContactID;
            DBobj.PrimaryContacts = obj.PrimaryContacts;
            DBobj.UKMaestroCardSecureRate = obj.UKMaestroCardSecureRate;
            DBobj.UnionPay = obj.UnionPay;
            DBobj.UnionPayCardSecureRate = obj.UnionPayCardSecureRate;
            DBobj.VisaBusinessCreditCardSecureRate = obj.VisaBusinessCreditCardSecureRate;
            DBobj.VisaBusinessDebitCardSecureRate = obj.VisaBusinessDebitCardSecureRate;
            DBobj.VisaCorporateCardSecureRate = obj.VisaCorporateCardSecureRate;
            DBobj.VisaCreditCardSecureRate = obj.VisaCreditCardSecureRate;
            DBobj.VisaDebitCardSecureRate = obj.VisaDebitCardSecureRate;
            DBobj.VisaPurchasingCardSecureRate = obj.VisaPurchasingCardSecureRate;
            DBobj.VisaVPayCardSecureRate = obj.VisaVPayCardSecureRate;
            _submerchantDBContext.SaveChanges();
        }
    }
}
