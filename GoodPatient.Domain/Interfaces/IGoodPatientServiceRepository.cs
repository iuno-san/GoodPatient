using GoodPatient.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Domain.Interfaces
{
    public interface IGoodPatientServiceRepository
    {
        Task Create(GoodPatientService service);

        Task<IEnumerable<GoodPatientService>> GetAllByEncodedName(string encodedName);
    }
}
