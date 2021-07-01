using SubmerchantAPI.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Repository
{
    public class SearchRepository : ISearchRepository<SearchModel>
    {
        readonly SubmerchantDBContext _submerchantDBContext;

        public SearchRepository(SubmerchantDBContext submerchantDBContext)
        {
            _submerchantDBContext = submerchantDBContext;
        }

        public IEnumerable<SearchModel> AdvanceSearch(SearchModel serachTerm)
        {
            List<PrimaryContact> primaryContacts = _submerchantDBContext.PrimaryContacts.ToList();
            List<SubMerchantDetails> subMerchantDetails = _submerchantDBContext.SubmerchantDetails.ToList();
            var result = from p in primaryContacts
                         join sub in subMerchantDetails
                         on p.PrimaryContactID equals sub.PrimaryContactID into submercht
                         from s in submercht.DefaultIfEmpty()
                         where (s == null || (serachTerm.SubMerchantID == null) ? true :
                                ((s.SubMerchantID.ToLower() == serachTerm.SubMerchantID.ToLower()) &&
                                (serachTerm.ApplicationStatus == null) ? true : (s.ApplicationStatus == serachTerm.ApplicationStatus)))
                              && ((serachTerm.MerchantName == null) ? true :
                                 (p.MerchantName.ToLower().StartsWith(serachTerm.MerchantName.ToLower())))
                              && ((serachTerm.TaxID == null) ? true :
                                 (p.TaxID.ToString().ToLower().StartsWith(serachTerm.TaxID.ToString().ToLower())))
                              && ((serachTerm.RequestDateFrom == null || serachTerm.RequestDateTo == null) ? true :
                                 ((p.ApplicationReceivedDate.Date >= serachTerm.RequestDateFrom.Value.Date) || (p.ApplicationReceivedDate.Date <= serachTerm.RequestDateTo.Value.Date)))
                              && ((serachTerm.BusinessStartDateFrom == null || serachTerm.BusinessStartDateTo == null) ? true :
                                 ((p.BusinessStartDate.Value.Date >= serachTerm.BusinessStartDateFrom.Value.Date) || (p.BusinessStartDate.Value.Date <= serachTerm.BusinessStartDateTo.Value.Date)))
                         select new SearchModel
                         {
                             TaxID = p.TaxID,
                             PrimaryContactID = p.PrimaryContactID,
                             LegalName = p.LegalName,
                             MerchantName = p.MerchantName,
                             ApplicationReceivedDate = p.ApplicationReceivedDate,



                             SubMerchantID = s == null ? null : s.SubMerchantID,
                             ApplicationStatus = s == null ? 0 : s.ApplicationStatus
                         };



            result = serachTerm.SubMerchantID != null ? result.Where(s => s.SubMerchantID == serachTerm.SubMerchantID) : result;
            result = serachTerm.ApplicationStatus > 0 ? result.Where(s => s.ApplicationStatus == serachTerm.ApplicationStatus) : result;



            return result;

        }

        public IEnumerable<SearchModel> GetAll()
        {
            List<PrimaryContact> primaryContacts = _submerchantDBContext.PrimaryContacts.ToList();
            List<SubMerchantDetails> subMerchantDetails = _submerchantDBContext.SubmerchantDetails.ToList();
            var result = from p in primaryContacts
                         join s in subMerchantDetails
                         on p.PrimaryContactID equals s.PrimaryContactID into pGroup
                         from s in pGroup.DefaultIfEmpty()
                         select new SearchModel
                         {
                             PrimaryContactID = p.PrimaryContactID,
                             LegalName = p.LegalName,
                             MerchantName = p.MerchantName,
                             ApplicationReceivedDate = p.ApplicationReceivedDate,
                             SubMerchantID = s == null ? null : s.SubMerchantID,
                             ApplicationStatus = s == null ? 0 : s.ApplicationStatus
                         };

            return result;
        }

        public IEnumerable<SearchModel> Serach(string serachTerm)
        {

            List<PrimaryContact> primaryContacts = _submerchantDBContext.PrimaryContacts.ToList();
            List<SubMerchantDetails> subMerchantDetails = _submerchantDBContext.SubmerchantDetails.ToList();

            var result = from p in primaryContacts
                         join s in subMerchantDetails
                         on p.PrimaryContactID equals s.PrimaryContactID
                         //into pGroup
                         //from s in pGroup.DefaultIfEmpty()
                         where p.LegalName.ToLower().Contains(serachTerm.ToLower())
                         || p.MerchantName.ToLower().Contains(serachTerm.ToLower())
                         || p.ApplicationReceivedDate.ToString().Contains(serachTerm)
                         || s.SubMerchantID.ToLower().Contains(serachTerm.ToLower())
                         || s.ApplicationStatus.ToString().Contains(serachTerm)
                         select new SearchModel
                         {
                             PrimaryContactID = p.PrimaryContactID,
                             LegalName = p.LegalName,
                             MerchantName = p.MerchantName,
                             ApplicationReceivedDate = p.ApplicationReceivedDate,
                             SubMerchantID = s == null ? null : s.SubMerchantID,
                             ApplicationStatus = s == null ? 0 : s.ApplicationStatus
                         };

            return result;
        }

    }
}
