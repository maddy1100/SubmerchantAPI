using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Models
{
    public class SearchModel
    {
        public long PrimaryContactID { get; set; }
        public string LegalName { get; set; }
        public string MerchantName { get; set; }
        public DateTime? ApplicationReceivedDate { get; set; }
        public string SubMerchantID { get; set; }
        public int? ApplicationStatus { get; set; }


        // Advance search        
        public string TaxID { get; set; }
        //public DateTime? RequestDateRange { get; set; }
        public DateTime? RequestDateTo { get; set; }
        public DateTime? RequestDateFrom { get; set; }
        public DateTime? BusinessStartDate { get; set; }
        // public DateTime? BusinessStartDateRange { get; set; }
        public DateTime? BusinessStartDateTo { get; set; }
        public DateTime? BusinessStartDateFrom { get; set; }
    }
}
