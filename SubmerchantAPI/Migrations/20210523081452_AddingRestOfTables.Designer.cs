﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SubmerchantAPI.Models;

namespace SubmerchantAPI.Migrations
{
    [DbContext(typeof(SubmerchantDBContext))]
    [Migration("20210523081452_AddingRestOfTables")]
    partial class AddingRestOfTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SubmerchantAPI.Models.DbModels.AdditionalCustomerInformation", b =>
                {
                    b.Property<string>("CustomerInfoID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("AverageTransactionValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CurrentProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("NoticePeriod")
                        .HasColumnType("int");

                    b.Property<string>("PrimaryContactID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("ProjectedAnnualCardTurnover")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProjectedAnnualTurnover")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RealisticMaxTransactionValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RealisticMinTransactionValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SettlementAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CustomerInfoID");

                    b.HasIndex("PrimaryContactID");

                    b.ToTable("CustomerInformation");
                });

            modelBuilder.Entity("SubmerchantAPI.Models.DbModels.BankDetails", b =>
                {
                    b.Property<string>("BankDetailsID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccountNumber")
                        .HasColumnType("int");

                    b.Property<string>("ApplicationCurrency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillToAddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillToCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillToCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillToCounty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillToProvince")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillToState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillToZip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BranchPostCode")
                        .HasColumnType("int");

                    b.Property<string>("BusinessOrPersonal")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("NameOfAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameOfBank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NatureOfBusiness")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryContactID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SortCode")
                        .HasColumnType("int");

                    b.Property<string>("TradingAddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TradingCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TradingCountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TradingCounty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TradingPostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TradingProvince")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TradingState")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BankDetailsID");

                    b.HasIndex("PrimaryContactID");

                    b.ToTable("BankDetails");
                });

            modelBuilder.Entity("SubmerchantAPI.Models.DbModels.CustomerDeclaration", b =>
                {
                    b.Property<string>("CustomerDeclarationID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateOfSignature")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MandatoryProofOfIdentity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryContactID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UKTDAccountHandler")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerDeclarationID");

                    b.HasIndex("PrimaryContactID");

                    b.ToTable("CustomerDeclarations");
                });

            modelBuilder.Entity("SubmerchantAPI.Models.DbModels.DirectDebit", b =>
                {
                    b.Property<string>("DirectDebitID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountHolderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BankOrBuildingSocietyAccountNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryContactID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ReferenceNumber")
                        .HasColumnType("int");

                    b.Property<int>("SortCode")
                        .HasColumnType("int");

                    b.HasKey("DirectDebitID");

                    b.HasIndex("PrimaryContactID");

                    b.ToTable("DirectDebits");
                });

            modelBuilder.Entity("SubmerchantAPI.Models.DbModels.MerchantAccountConfiguration", b =>
                {
                    b.Property<string>("AccConfigID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AmericanExpressID")
                        .HasColumnType("int");

                    b.Property<int>("AreaCode")
                        .HasColumnType("int");

                    b.Property<int>("Landline")
                        .HasColumnType("int");

                    b.Property<int>("MerchantAccountNumber")
                        .HasColumnType("int");

                    b.Property<int>("MerchantBankAcquirer")
                        .HasColumnType("int");

                    b.Property<string>("OutgoingCall")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("PrimaryContactID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TillReceipts")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccConfigID");

                    b.HasIndex("PrimaryContactID");

                    b.ToTable("MerchantAccountConfigurations");
                });

            modelBuilder.Entity("SubmerchantAPI.Models.DbModels.PrincipalOwner", b =>
                {
                    b.Property<string>("PrincipalOwnerID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HomeTelephone")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LengthOfTimeAsPartner")
                        .HasColumnType("int");

                    b.Property<string>("NationalIdType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalIdValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalInsuranceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryContactID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Principal1Ownership")
                        .HasColumnType("int");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrincipalOwnerID");

                    b.HasIndex("PrimaryContactID");

                    b.ToTable("PrincipalOwners");
                });

            modelBuilder.Entity("SubmerchantAPI.Models.DbModels.ScheduleOfFeesPartner_UK", b =>
                {
                    b.Property<string>("PartnersUKID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("DinersCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InternationalMaestroCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("JCBCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MasterCardBusinessCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MasterCardCorporateCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MasterCardCreditCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MasterCardDebitCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MasterCardFleetCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MasterCardPrePaidCommercialCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MasterCardPurchasingCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NonEEAMasterCardCreditCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NonEEAVisaCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PrimaryContactID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("UKMaestroCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnionPay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnionPayCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("VisaBusinessCreditCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("VisaBusinessDebitCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("VisaCorporateCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VisaCreditCardSecureRate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("VisaDebitCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("VisaPurchasingCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("VisaVPayCardSecureRate")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PartnersUKID");

                    b.HasIndex("PrimaryContactID");

                    b.ToTable("ScheduleOfFeesPartners");
                });

            modelBuilder.Entity("SubmerchantAPI.Models.DbModels.ServicesSummary", b =>
                {
                    b.Property<string>("ServicesSummaryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date1")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date2")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MerchantRates_AuthorisationFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MerchantRates_CreditCard")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MerchantRates_DebitCard")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MerchantRates_MinimumMonthlyServiceFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PrimaryContactID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("SetUpFee_AmexFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SetUpFee_FeeAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Terminal_ContractPeriod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Terminal_Model")
                        .HasColumnType("int");

                    b.Property<decimal>("Terminal_MonthlyRental")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UKTDAdvisorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServicesSummaryID");

                    b.HasIndex("PrimaryContactID");

                    b.ToTable("ServicesSummaries");
                });

            modelBuilder.Entity("SubmerchantAPI.Models.PrimaryContact", b =>
                {
                    b.Property<string>("PrimaryContactID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ApplicationReceivedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BusinessEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BusinessStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContractType")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HomeTelephone")
                        .HasColumnType("int");

                    b.Property<string>("LegalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MobileTelephone")
                        .HasColumnType("int");

                    b.Property<int>("NationalInsuranceNumber")
                        .HasColumnType("int");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PercentageShare")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PersonalEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeOfBusiness")
                        .HasColumnType("int");

                    b.HasKey("PrimaryContactID");

                    b.ToTable("PrimaryContacts");
                });

            modelBuilder.Entity("SubmerchantAPI.Models.SubMerchantPostProcessingDetails", b =>
                {
                    b.Property<string>("ProcessingDetailsID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ApplicationStatus")
                        .HasColumnType("int");

                    b.Property<int>("DataValidationStatus")
                        .HasColumnType("int");

                    b.Property<int>("PostUnderwritingSuccess")
                        .HasColumnType("int");

                    b.Property<string>("PrimaryContactID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubMerchantID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalCreditCardSales")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ValidationFailureReason")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProcessingDetailsID");

                    b.HasIndex("PrimaryContactID");

                    b.ToTable("SubmerchantDetails");
                });

            modelBuilder.Entity("SubmerchantAPI.Models.DbModels.AdditionalCustomerInformation", b =>
                {
                    b.HasOne("SubmerchantAPI.Models.PrimaryContact", "PrimaryContacts")
                        .WithMany()
                        .HasForeignKey("PrimaryContactID");

                    b.Navigation("PrimaryContacts");
                });

            modelBuilder.Entity("SubmerchantAPI.Models.DbModels.BankDetails", b =>
                {
                    b.HasOne("SubmerchantAPI.Models.PrimaryContact", "PrimaryContacts")
                        .WithMany()
                        .HasForeignKey("PrimaryContactID");

                    b.Navigation("PrimaryContacts");
                });

            modelBuilder.Entity("SubmerchantAPI.Models.DbModels.CustomerDeclaration", b =>
                {
                    b.HasOne("SubmerchantAPI.Models.PrimaryContact", "PrimaryContacts")
                        .WithMany()
                        .HasForeignKey("PrimaryContactID");

                    b.Navigation("PrimaryContacts");
                });

            modelBuilder.Entity("SubmerchantAPI.Models.DbModels.DirectDebit", b =>
                {
                    b.HasOne("SubmerchantAPI.Models.PrimaryContact", "PrimaryContacts")
                        .WithMany()
                        .HasForeignKey("PrimaryContactID");

                    b.Navigation("PrimaryContacts");
                });

            modelBuilder.Entity("SubmerchantAPI.Models.DbModels.MerchantAccountConfiguration", b =>
                {
                    b.HasOne("SubmerchantAPI.Models.PrimaryContact", "PrimaryContacts")
                        .WithMany()
                        .HasForeignKey("PrimaryContactID");

                    b.Navigation("PrimaryContacts");
                });

            modelBuilder.Entity("SubmerchantAPI.Models.DbModels.PrincipalOwner", b =>
                {
                    b.HasOne("SubmerchantAPI.Models.PrimaryContact", "PrimaryContacts")
                        .WithMany()
                        .HasForeignKey("PrimaryContactID");

                    b.Navigation("PrimaryContacts");
                });

            modelBuilder.Entity("SubmerchantAPI.Models.DbModels.ScheduleOfFeesPartner_UK", b =>
                {
                    b.HasOne("SubmerchantAPI.Models.PrimaryContact", "PrimaryContacts")
                        .WithMany()
                        .HasForeignKey("PrimaryContactID");

                    b.Navigation("PrimaryContacts");
                });

            modelBuilder.Entity("SubmerchantAPI.Models.DbModels.ServicesSummary", b =>
                {
                    b.HasOne("SubmerchantAPI.Models.PrimaryContact", "PrimaryContacts")
                        .WithMany()
                        .HasForeignKey("PrimaryContactID");

                    b.Navigation("PrimaryContacts");
                });

            modelBuilder.Entity("SubmerchantAPI.Models.SubMerchantPostProcessingDetails", b =>
                {
                    b.HasOne("SubmerchantAPI.Models.PrimaryContact", "PrimaryContacts")
                        .WithMany()
                        .HasForeignKey("PrimaryContactID");

                    b.Navigation("PrimaryContacts");
                });
#pragma warning restore 612, 618
        }
    }
}