using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System;
using WebApiOracleEFCore7.Application.Interfaces;
using WebApiOracleEFCore7.Application.Interfaces.Repositories;
using WebApiOracleEFCore7.Infrastructure.Persistence.Contexts;
using WebApiOracleEFCore7.Infrastructure.Persistence.Repositories;
using WebApiOracleEFCore7.Infrastructure.Persistence.Repository;

namespace WebApiOracleEFCore7.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseInMemoryDatabase("ApplicationDb"));
            }
            else
            {
                // Directory where you unzipped your cloud credentials
                OracleConfiguration.TnsAdmin = configuration.GetConnectionString("TnsAdmin");
                OracleConfiguration.WalletLocation = OracleConfiguration.TnsAdmin;

                services.AddDbContext<ApplicationDbContext>(options =>
                options.UseOracle(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext)
                    .Assembly.FullName)
                    ));
            }

            #region Repositories

            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            services.AddTransient<IPositionRepositoryAsync, PositionRepositoryAsync>();
            services.AddTransient<IEmployeeRepositoryAsync, EmployeeRepositoryAsync>();

            #endregion Repositories
        }
    }
}