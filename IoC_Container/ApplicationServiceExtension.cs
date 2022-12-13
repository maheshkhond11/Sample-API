using ExtraEdgeAssignmentAPIs.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Models.DBContext;
using Repository;
using Repository.IRepo;
using Services.Services.CRUD;
using Services.Services.CRUD.Interface;
using Services.Services.Report;
using Services.Services.Report.Interface;
using Services.Services.Token;

namespace ExtraEdgeAssignmentAPIs.IoC
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection  AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ICRUDService, CRUDService>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<IRecordsRepo, RecordsRepo>();
            services.AddScoped<IBrandsRepo, BrandsRepo>();
            services.AddScoped<IPhonesRepo, PhonesRepo>();
            services.AddScoped<ISalesRepo, SalesRepo>();
            services.AddScoped<IReportRepo, ReportRepo>();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}
