using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SubmerchantAPI.Migrations
{
    public partial class AddingRestOfTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankDetails",
                columns: table => new
                {
                    BankDetailsID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NatureOfBusiness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameOfBank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameOfAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortCode = table.Column<int>(type: "int", nullable: false),
                    BranchPostCode = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    BusinessOrPersonal = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    ApplicationCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradingAddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradingCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradingCounty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradingState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradingPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradingProvince = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradingCountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillToAddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillToCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillToCounty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillToState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillToZip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillToProvince = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillToCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryContactID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankDetails", x => x.BankDetailsID);
                    table.ForeignKey(
                        name: "FK_BankDetails_PrimaryContacts_PrimaryContactID",
                        column: x => x.PrimaryContactID,
                        principalTable: "PrimaryContacts",
                        principalColumn: "PrimaryContactID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerDeclarations",
                columns: table => new
                {
                    CustomerDeclarationID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfSignature = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MandatoryProofOfIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UKTDAccountHandler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryContactID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDeclarations", x => x.CustomerDeclarationID);
                    table.ForeignKey(
                        name: "FK_CustomerDeclarations_PrimaryContacts_PrimaryContactID",
                        column: x => x.PrimaryContactID,
                        principalTable: "PrimaryContacts",
                        principalColumn: "PrimaryContactID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerInformation",
                columns: table => new
                {
                    CustomerInfoID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CurrentProvider = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    SettlementAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoticePeriod = table.Column<int>(type: "int", nullable: false),
                    ProjectedAnnualTurnover = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProjectedAnnualCardTurnover = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AverageTransactionValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RealisticMinTransactionValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RealisticMaxTransactionValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrimaryContactID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInformation", x => x.CustomerInfoID);
                    table.ForeignKey(
                        name: "FK_CustomerInformation_PrimaryContacts_PrimaryContactID",
                        column: x => x.PrimaryContactID,
                        principalTable: "PrimaryContacts",
                        principalColumn: "PrimaryContactID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DirectDebits",
                columns: table => new
                {
                    DirectDebitID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BankOrBuildingSocietyAccountNumber = table.Column<int>(type: "int", nullable: false),
                    SortCode = table.Column<int>(type: "int", nullable: false),
                    ReferenceNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountHolderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryContactID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectDebits", x => x.DirectDebitID);
                    table.ForeignKey(
                        name: "FK_DirectDebits_PrimaryContacts_PrimaryContactID",
                        column: x => x.PrimaryContactID,
                        principalTable: "PrimaryContacts",
                        principalColumn: "PrimaryContactID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MerchantAccountConfigurations",
                columns: table => new
                {
                    AccConfigID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MerchantBankAcquirer = table.Column<int>(type: "int", nullable: false),
                    MerchantAccountNumber = table.Column<int>(type: "int", nullable: false),
                    AmericanExpressID = table.Column<int>(type: "int", nullable: false),
                    TillReceipts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutgoingCall = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    AreaCode = table.Column<int>(type: "int", nullable: false),
                    Landline = table.Column<int>(type: "int", nullable: false),
                    PrimaryContactID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantAccountConfigurations", x => x.AccConfigID);
                    table.ForeignKey(
                        name: "FK_MerchantAccountConfigurations_PrimaryContacts_PrimaryContactID",
                        column: x => x.PrimaryContactID,
                        principalTable: "PrimaryContacts",
                        principalColumn: "PrimaryContactID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrincipalOwners",
                columns: table => new
                {
                    PrincipalOwnerID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LengthOfTimeAsPartner = table.Column<int>(type: "int", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalInsuranceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Principal1Ownership = table.Column<int>(type: "int", nullable: false),
                    NationalIdType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalIdValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeTelephone = table.Column<int>(type: "int", nullable: false),
                    PrimaryContactID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrincipalOwners", x => x.PrincipalOwnerID);
                    table.ForeignKey(
                        name: "FK_PrincipalOwners_PrimaryContacts_PrimaryContactID",
                        column: x => x.PrimaryContactID,
                        principalTable: "PrimaryContacts",
                        principalColumn: "PrimaryContactID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleOfFeesPartners",
                columns: table => new
                {
                    PartnersUKID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VisaCreditCardSecureRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterCardCreditCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VisaDebitCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MasterCardDebitCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VisaVPayCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UKMaestroCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InternationalMaestroCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VisaBusinessCreditCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VisaBusinessDebitCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VisaPurchasingCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VisaCorporateCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MasterCardBusinessCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MasterCardPurchasingCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MasterCardFleetCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MasterCardCorporateCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MasterCardPrePaidCommercialCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonEEAVisaCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonEEAMasterCardCreditCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DinersCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JCBCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnionPayCardSecureRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnionPay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrimaryContactID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleOfFeesPartners", x => x.PartnersUKID);
                    table.ForeignKey(
                        name: "FK_ScheduleOfFeesPartners_PrimaryContacts_PrimaryContactID",
                        column: x => x.PrimaryContactID,
                        principalTable: "PrimaryContacts",
                        principalColumn: "PrimaryContactID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServicesSummaries",
                columns: table => new
                {
                    ServicesSummaryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Terminal_Model = table.Column<int>(type: "int", nullable: false),
                    Terminal_ContractPeriod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Terminal_MonthlyRental = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MerchantRates_CreditCard = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MerchantRates_DebitCard = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MerchantRates_AuthorisationFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MerchantRates_MinimumMonthlyServiceFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SetUpFee_FeeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SetUpFee_AmexFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UKTDAdvisorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date2 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrimaryContactID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicesSummaries", x => x.ServicesSummaryID);
                    table.ForeignKey(
                        name: "FK_ServicesSummaries_PrimaryContacts_PrimaryContactID",
                        column: x => x.PrimaryContactID,
                        principalTable: "PrimaryContacts",
                        principalColumn: "PrimaryContactID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubmerchantDetails",
                columns: table => new
                {
                    ProcessingDetailsID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubMerchantID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationStatus = table.Column<int>(type: "int", nullable: false),
                    PostUnderwritingSuccess = table.Column<int>(type: "int", nullable: false),
                    DataValidationStatus = table.Column<int>(type: "int", nullable: false),
                    ValidationFailureReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalCreditCardSales = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrimaryContactID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubmerchantDetails", x => x.ProcessingDetailsID);
                    table.ForeignKey(
                        name: "FK_SubmerchantDetails_PrimaryContacts_PrimaryContactID",
                        column: x => x.PrimaryContactID,
                        principalTable: "PrimaryContacts",
                        principalColumn: "PrimaryContactID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankDetails_PrimaryContactID",
                table: "BankDetails",
                column: "PrimaryContactID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDeclarations_PrimaryContactID",
                table: "CustomerDeclarations",
                column: "PrimaryContactID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInformation_PrimaryContactID",
                table: "CustomerInformation",
                column: "PrimaryContactID");

            migrationBuilder.CreateIndex(
                name: "IX_DirectDebits_PrimaryContactID",
                table: "DirectDebits",
                column: "PrimaryContactID");

            migrationBuilder.CreateIndex(
                name: "IX_MerchantAccountConfigurations_PrimaryContactID",
                table: "MerchantAccountConfigurations",
                column: "PrimaryContactID");

            migrationBuilder.CreateIndex(
                name: "IX_PrincipalOwners_PrimaryContactID",
                table: "PrincipalOwners",
                column: "PrimaryContactID");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleOfFeesPartners_PrimaryContactID",
                table: "ScheduleOfFeesPartners",
                column: "PrimaryContactID");

            migrationBuilder.CreateIndex(
                name: "IX_ServicesSummaries_PrimaryContactID",
                table: "ServicesSummaries",
                column: "PrimaryContactID");

            migrationBuilder.CreateIndex(
                name: "IX_SubmerchantDetails_PrimaryContactID",
                table: "SubmerchantDetails",
                column: "PrimaryContactID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankDetails");

            migrationBuilder.DropTable(
                name: "CustomerDeclarations");

            migrationBuilder.DropTable(
                name: "CustomerInformation");

            migrationBuilder.DropTable(
                name: "DirectDebits");

            migrationBuilder.DropTable(
                name: "MerchantAccountConfigurations");

            migrationBuilder.DropTable(
                name: "PrincipalOwners");

            migrationBuilder.DropTable(
                name: "ScheduleOfFeesPartners");

            migrationBuilder.DropTable(
                name: "ServicesSummaries");

            migrationBuilder.DropTable(
                name: "SubmerchantDetails");
        }
    }
}
