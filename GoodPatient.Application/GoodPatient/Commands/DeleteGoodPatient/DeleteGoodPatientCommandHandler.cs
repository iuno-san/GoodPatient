using AutoMapper;
using GoodPatient.Application.ApplicationUser;
using GoodPatient.Application.GoodPatient.Commands.CreateGoodPatient;
using GoodPatient.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Application.GoodPatient.Commands.DeleteGoodPatient
{
    public class DeleteGoodPatientCommandHandler : IRequestHandler<DeleteGoodPatientCommand>
    {

        private readonly IMapper _mapper;
        private readonly IGoodPatientRepository _GoodPatientRepository;
        private readonly IUserContext _userContext;

        public DeleteGoodPatientCommandHandler(IMapper mapper, IGoodPatientRepository GoodPatientRepository, IUserContext userContext)
        {
            _mapper = mapper;
            _GoodPatientRepository = GoodPatientRepository;
            _userContext = userContext;
        }

        public async Task<Unit> Handle(DeleteGoodPatientCommand request, CancellationToken cancellationToken)
        {
            var GoodPatient = await _GoodPatientRepository.GetByEncodedName(request.EncodedName);

            var user = _userContext.GetCurrentUser();
            var isEditable = user != null || GoodPatient.CreatedById == user.Id;

            if (!isEditable)
            {
                return Unit.Value;
            }

            await _GoodPatientRepository.Delete(GoodPatient);

            return Unit.Value;
        }
    }
}
