using Microsoft.EntityFrameworkCore;
using SubmerchantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SubmerchantAPI.Models.DbModels;

namespace SubmerchantAPI.Repository
{
    public class PrimaryContactRepository : IRepository<PrimaryContact>
    {

        readonly SubmerchantDBContext _submerchantDBContext;

        public PrimaryContactRepository(SubmerchantDBContext submerchantDBContext)
        {
            _submerchantDBContext = submerchantDBContext;
        }
        public void Delete(object Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PrimaryContact> GetAll()
        {
            return _submerchantDBContext.PrimaryContacts.ToList();
        }


        public PrimaryContact GetById(object Id)
        {
            return _submerchantDBContext.PrimaryContacts.FirstOrDefault(p => p.PrimaryContactID ==Convert.ToInt64( Id));
        }

        public void Insert(PrimaryContact obj)
        {
            _submerchantDBContext.PrimaryContacts.Add(obj);
            _submerchantDBContext.SaveChanges();
        }

        //public void Save()
        //{
        //    throw new NotImplementedException();
        //}

        public void Update(PrimaryContact DBobj, PrimaryContact obj)
        {
            // DBobj.PrimaryContactID = obj.PrimaryContactID;
            DBobj.ApplicationReceivedDate = obj.ApplicationReceivedDate;
            DBobj.BillToAddressLine1 = obj.BillToAddressLine1;
            DBobj.BillToCity = obj.BillToCity;
            DBobj.BillToCountry = obj.BillToCountry;
            DBobj.BillToProvince = obj.BillToProvince;
            DBobj.BillToState = obj.BillToState;
            DBobj.BillToZip = obj.BillToZip;
            DBobj.BusinessEmail = obj.BusinessEmail;
            DBobj.BusinessStartDate = obj.BusinessStartDate;
            DBobj.CompanyRegistrationNumber = obj.CompanyRegistrationNumber;
            DBobj.ContractType = obj.ContractType;
            DBobj.DateOfBirth = obj.DateOfBirth;
            DBobj.Emailaddress = obj.Emailaddress;
            DBobj.FullName = obj.FullName;
            DBobj.LegalForm = obj.LegalForm;
            DBobj.LegalName = obj.LegalName;
            DBobj.Nationality = obj.Nationality;
            DBobj.PercentageShare = obj.PercentageShare;
            DBobj.TaxID = obj.TaxID;
            DBobj.TradingAddressLine1 = obj.TradingAddressLine1;
            DBobj.TradingCity = obj.TradingCity;
            DBobj.TradingCountryCode = obj.TradingCountryCode;
            DBobj.TradingCounty = obj.TradingCounty;
            DBobj.TradingPostalCode = obj.TradingPostalCode;
            DBobj.TradingProvince = obj.TradingProvince;
            DBobj.TradingState = obj.TradingState;
            DBobj.TypeOfBusiness = obj.TypeOfBusiness;
            DBobj.UKTDAccountHandler = obj.UKTDAccountHandler;

            DBobj.PersonalEmail = obj.PersonalEmail;
            DBobj.PercentageShare = obj.PercentageShare;
            DBobj.Nationality = obj.Nationality;

            DBobj.NationalInsuranceNumber = obj.NationalInsuranceNumber;
            DBobj.MobileTelephone = obj.MobileTelephone;
            DBobj.MerchantName = obj.MerchantName;
           
            DBobj.HomeTelephone = obj.HomeTelephone;
            DBobj.FullName = obj.FullName;
            _submerchantDBContext.SaveChanges();
        }

    }
}
