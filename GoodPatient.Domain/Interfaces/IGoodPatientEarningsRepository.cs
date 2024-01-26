using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Domain.Interfaces
{
    public interface IGoodPatientEarningsRepository
    {
        Task CreateEarnings(Domain.Entities.GoodPatientEarnings GoodPatientEarnings);

        Task DeleteEarnings(Domain.Entities.GoodPatientEarnings GoodPatientEarnings);

        Task<IEnumerable<Domain.Entities.GoodPatientEarnings>> GetAllEarnings();

        Task<Domain.Entities.GoodPatientEarnings> GetByEncodedNameEarnings(string encodedName);
        Task Commit();
    }
}