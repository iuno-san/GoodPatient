using AutoMapper;
using GoodPatient.Application.ApplicationUser;
using GoodPatient.Application.GoodPatient.Commands.EditGoodPatient;
using GoodPatient.Application.GoodPatient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodPatient.Application.GoodPatientEarnings;
using GoodPatient.Application.GoodPatientEarnings.Commands.EditGoodPatientEarnings;

namespace GoodPatient.Application.Mappings
{
    public class GoodPatientEarningsMappingProfile : Profile
    {
        public GoodPatientEarningsMappingProfile(IUserContext userContext)
        {
            var user = userContext.GetCurrentUser();

            CreateMap<GoodPatientEarningsDto, Domain.Entities.GoodPatientEarnings>();

            CreateMap<Domain.Entities.GoodPatientEarnings, GoodPatientEarningsDto>()
                .ForMember(dto => dto.IsEditable, opt =>
                opt.MapFrom(src => user != null && src.CreatedById == user.Id));

            CreateMap<GoodPatientEarningsDto, EditGoodPatientEarningsCommand>();
        }
    }
}
