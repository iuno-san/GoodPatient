using GoodPatient.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodPatient.Infrastructure.Seeders;
using GoodPatient.Infrastructure.Repositories;
using GoodPatient.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Security.Principal;
using GoodPatient.Application.ApplicationUser;

namespace GoodPatient.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserContext, UserContext>();

            services.AddDbContext<GoodPatientDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("GoodPatientConection")));

            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<GoodPatientDbContext>();

            services.AddScoped<GoodPatientSeeder>();

            services.AddScoped<IGoodPatientRepository, GoodPatientRepository>();

            services.AddScoped<IGoodPatientEarningsRepository, GoodPatientEarningsRepository>();

            services.AddScoped<IGoodPatientServiceRepository, GoodPatientServiceRepository>();
        }
    }
}
