using GoodPatient.Application.GoodPatient.Commands.EditGoodPatient;
using AutoMapper;
using GoodPatient.Application.GoodPatient;
using GoodPatient.Application.ApplicationUser;

namespace GoodPatient.Application.Mappings
{
    public class GoodPatientMappingProfile : Profile
    {
        public GoodPatientMappingProfile(IUserContext userContext)
        {
            var user = userContext.GetCurrentUser();

            CreateMap<GoodPatientDto, Domain.Entities.GoodPatient>();

            CreateMap<Domain.Entities.GoodPatient, GoodPatientDto>()
                .ForMember(dto => dto.IsEditable, opt => 
                opt.MapFrom(src => user != null && src.CreatedById == user.Id));

            CreateMap<GoodPatientDto, EditGoodPatientCommand>();

            CreateMap<GoodPatientDto, Domain.Entities.GoodPatientService>()
                .ReverseMap();
        }
    }
}
