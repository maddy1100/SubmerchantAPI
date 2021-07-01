using Microsoft.EntityFrameworkCore;
using SubmerchantAPI.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubmerchantAPI.Models
{
    public class SubmerchantDBContext : DbContext
    {
        public DbSet<PrimaryContact> PrimaryContacts { get; set; }
        public DbSet<SubMerchantDetails> SubmerchantDetails { get; set; }
        public DbSet<BankDetails> BankDetails { get; set; }
        public DbSet<PrincipalOwner> PrincipalOwners { get; set; }
        public DbSet<DirectDebit> DirectDebits { get; set; }
        public DbSet<ServicesSummary> ServicesSummaries { get; set; }
        public DbSet<MerchantAccountConfiguration> MerchantAccountConfigurations { get; set; }
        public DbSet<ScheduleOfFeesPartner_UK> ScheduleOfFeesPartners { get; set; }
        public DbSet<AdditionalCustomerInformation> CustomerInformation { get; set; }
        public DbSet<CustomerDeclaration> CustomerDeclarations { get; set; }
        public DbSet<AuthorisationFees> AuthorisationFees { get; set; }
        public DbSet<TerminateSubmerchant> TerminateSubmerchant { get; set; }
        public DbSet<ReasonCodeMaster> ReasonCodeMaster { get; set; }


        public SubmerchantDBContext(DbContextOptions options) : base(options)
        {
        }
        public SubmerchantDBContext()
        {
        }
    }
}
