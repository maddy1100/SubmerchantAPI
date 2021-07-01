using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Models
{
    public class TransactionHistory
    {
        public long PrimaryContactID { get; set; }
        public string SubMerchantID { get; set; }
        public string SubMerchantName { get; set; }
        public long ? AccountNumber { get; set; }
        public string Currency { get; set; }
        public DateTime ? SattlementDay { get; set; }
        public long ? PaymentID { get; set; }
        public string FundTransferID { get; set; }
        public decimal ? Amount { get; set; }
        public string FundingInstructionType { get; set; }
    }
}
