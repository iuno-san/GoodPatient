using GoodPatient.Domain.Interfaces;
using MediatR;
using GoodPatient.Application.ApplicationUser;


namespace GoodPatient.Application.GoodPatient.Commands.EditGoodPatient
{
    internal class EditGoodPatientCommandHandler : IRequestHandler<EditGoodPatientCommand>
    {
        private readonly IGoodPatientRepository _repository;
        private readonly IUserContext _userContext;

        public EditGoodPatientCommandHandler(IGoodPatientRepository repository, IUserContext userContext)
        {
            _repository = repository;
            _userContext = userContext;
        }

        public async Task<Unit> Handle(EditGoodPatientCommand request, CancellationToken cancellationToken)
        {
            var GoodPatient = await _repository.GetByEncodedName(request.EncodedName!);

            var user = _userContext.GetCurrentUser();
            var isEditable = user != null || GoodPatient.CreatedById == user.Id;

            if (!isEditable)
            {
                return Unit.Value;
            }

            GoodPatient.FullName = request.FullName;
            GoodPatient.About = request.About;
            GoodPatient.Email = request.Email;
            GoodPatient.Age = request.Age;
            GoodPatient.DiseasesAndAllergies = request.DiseasesAndAllergies;
            GoodPatient.HealthInsuranceNumber = request.HealthInsuranceNumber;
            GoodPatient.Address = request.Address;
            GoodPatient.PhoneNumber = request.PhoneNumber;
            GoodPatient.Skype = request.Skype;
            GoodPatient.Facebook = request.Facebook;

            await _repository.Commit();

            return Unit.Value;
        }
    }
}
