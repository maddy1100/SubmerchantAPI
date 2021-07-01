using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SubmerchantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SubmerchantAPI.Repository;
using Microsoft.OpenApi.Models;
using SubmerchantAPI.Models.DbModels;
using PAM;
using Microsoft.AspNetCore.Http;
using SubmerchantAPI.Middlewares;

namespace SubmerchantAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsApiPolicy",
                builder =>
                {
                    builder.AllowAnyOrigin()
                    .WithHeaders(new[] { "authorization", "content-type", "accept" })
                    .WithMethods(new[] { "GET", "POST", "PUT", "DELETE", "OPTIONS" });
                });
            });
            services.AddControllers();
            services.AddDbContext<SubmerchantDBContext>(item => item.UseSqlServer(Configuration.GetConnectionString("UKTDConn")));
            services.AddScoped<IRepository<PrimaryContact>, PrimaryContactRepository>();
            services.AddScoped<IRepository<AdditionalCustomerInformation>, AdditionalCustomerInformationRepository>();
            services.AddScoped<IRepository<SubMerchantDetails>, SubMerchantPostProcessingRepository>();
            services.AddScoped<IRepository<BankDetails>, BankDetailsRepository>();
            services.AddScoped<IRepository<CustomerDeclaration>, CustomerDeclarationRepository>();
            services.AddScoped<IRepository<DirectDebit>, DirectDebitRepository>();
            services.AddScoped<IRepository<MerchantAccountConfiguration>, MerchantAccountConfigurationRepository>();
            services.AddScoped<IRepository<PrincipalOwner>, PrincipalOwnerRepository>();
            services.AddScoped<IRepository<ScheduleOfFeesPartner_UK>, ScheduleOfFeesPartner_UKRepository>();
            services.AddScoped<IRepository<ServicesSummary>, ServicesSummaryRepository>();
            services.AddScoped<IRepository<AuthorisationFees>, AuthorisationFeesRepository>();
            services.AddScoped<ISearchRepository<SearchModel>, SearchRepository>();
            services.AddScoped<ITransactionHistoryRepository<TransactionHistory>, TransactionHistoryRepository>();
            services.AddScoped<IReasonCodeMaster<ReasonCodeMaster>, ReasonCodeMasterRepository>();
            services.AddScoped<ITerminateSubmerchant<TerminateSubmerchant>, TerminateSubmerchantRepository>();
            services.AddScoped<ISubMerchantProfile<SubMerchantProfile>, SubMerchantProfileRepository>();



            //registering the pam service for Login controller
            services.AddSingleton<IdentityService, IdentityServiceClient>();

            services.AddTransient<TokenManagerMiddleware>();
            services.AddTransient<ITokenManager, TokenManager>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDistributedRedisCache(r => { r.Configuration = Configuration["redis:connectionString"]; });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Submerchant API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                // For Debug in Kestrel : using exe
                // c.SwaggerEndpoint("/swagger/v1/swagger.json", "Submerchant API V1");
                // To deploy on IIS
                c.SwaggerEndpoint("./swagger/v1/swagger.json", "Submerchant API V1");

                c.RoutePrefix = string.Empty;
            });

            app.UseMiddleware<TokenManagerMiddleware>();
            app.UseRouting();
            app.UseCors("CorsApiPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
