using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using GoodPatient.Application.ApplicationUser;
using GoodPatient.Application.Mappings;
using GoodPatient.Application.GoodPatient;
using GoodPatient.Application.GoodPatient.Commands.CreateGoodPatient;
using GoodPatient.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodPatient.Application.GoodPatientEarnings;
using GoodPatient.Application.GoodPatientEarnings.Commands.CreateGoodPatientEarnings;

namespace GoodPatient.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(typeof(CreateGoodPatientCommand));

            services.AddScoped(provider => new MapperConfiguration(cfg =>
            {
                var scope = provider.CreateScope();
                var userContext = scope.ServiceProvider.GetRequiredService<IUserContext>();
                cfg.AddProfile(new GoodPatientMappingProfile(userContext));
                cfg.AddProfile(new GoodPatientEarningsMappingProfile(userContext));

            }).CreateMapper()
            );

            services.AddValidatorsFromAssemblyContaining<GoodPatientDtoValidator>()
                   .AddFluentValidationAutoValidation()
                   .AddFluentValidationClientsideAdapters();

        }
    }
}
