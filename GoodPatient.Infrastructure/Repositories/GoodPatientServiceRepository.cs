using Microsoft.EntityFrameworkCore;
using GoodPatient.Domain.Entities;
using GoodPatient.Domain.Interfaces;
using GoodPatient.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Infrastructure.Repositories
{
    internal class GoodPatientServiceRepository : IGoodPatientServiceRepository
    {
        private GoodPatientDbContext _dbContext { get; }
        public GoodPatientServiceRepository(GoodPatientDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task Create(GoodPatientService service)
        {
            _dbContext.Services.Add(service);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<GoodPatientService>> GetAllByEncodedName(string encodedName) =>
            await _dbContext.Services
            .Where(s => s.GoodPatient.EncodedName == encodedName)
            .ToListAsync();
    }
}
