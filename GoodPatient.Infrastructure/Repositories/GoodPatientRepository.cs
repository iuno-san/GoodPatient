using Microsoft.EntityFrameworkCore;
using GoodPatient.Domain.Interfaces;
using GoodPatient.Infrastructure.Persistance;

namespace GoodPatient.Infrastructure.Repositories
{
    internal class GoodPatientRepository : IGoodPatientRepository
    {
        private readonly GoodPatientDbContext _dbContext;

        public GoodPatientRepository(GoodPatientDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task Commit()
        => _dbContext.SaveChangesAsync();

        public async Task Create(Domain.Entities.GoodPatient GoodPatient)
        {
            _dbContext.Add(GoodPatient);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Domain.Entities.GoodPatient goodPatient)
        {
            _dbContext.GoodPatients.Remove(goodPatient);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Domain.Entities.GoodPatient>> GetAll()
        => await _dbContext.GoodPatients.ToListAsync();

        public async Task<Domain.Entities.GoodPatient> GetByEncodedName(string encodedName)
        => await _dbContext.GoodPatients.FirstAsync(c => c.EncodedName == encodedName);
    }
}
