using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Domain.Interfaces
{
    public interface IGoodPatientRepository
    {
        Task Create(Domain.Entities.GoodPatient GoodPatient);

        Task Delete(Domain.Entities.GoodPatient goodPatient);

        Task<IEnumerable<Domain.Entities.GoodPatient>> GetAll();

        Task<Domain.Entities.GoodPatient> GetByEncodedName(string encodedName);
        Task Commit();
    }
}