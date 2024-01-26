using MediatR;
using GoodPatient.Application.ApplicationUser;
using GoodPatient.Domain.Entities;
using GoodPatient.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatientService.Commands
{
    public class CreateGoodPatientServiceCommandHandler : IRequestHandler<CreateGoodPatientServiceCommand>
    {
        private readonly IUserContext _userContext;
        private readonly IGoodPatientRepository _emploRepository;
        private readonly IGoodPatientServiceRepository _emploServiceRepository;

        public CreateGoodPatientServiceCommandHandler(IUserContext userContext, IGoodPatientRepository emploRepository, IGoodPatientServiceRepository emploServiceRepository)
        {
            _userContext = userContext;
            _emploRepository = emploRepository;
            _emploServiceRepository = emploServiceRepository;
        }

        public async Task<Unit> Handle(CreateGoodPatientServiceCommand request, CancellationToken cancellationToken)
        {
            var GoodPatient = await _emploRepository.GetByEncodedName(request.GoodPatientEncodedName!);

            var user = _userContext.GetCurrentUser();
            var isEdibable = user != null && (GoodPatient.CreatedById == user.Id);

            if (!isEdibable)
            {
                return Unit.Value;
            }

            var GoodPatientService = new Domain.Entities.GoodPatientService()
            {
                Name = request.Name,
                Description = request.Description,
                GoodPatientId = GoodPatient.Id,
            };

            await _emploServiceRepository.Create(GoodPatientService);

            return Unit.Value;
        }
    }
}
