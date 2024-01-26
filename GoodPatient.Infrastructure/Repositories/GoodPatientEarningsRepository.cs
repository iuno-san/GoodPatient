using Microsoft.EntityFrameworkCore;
using GoodPatient.Domain.Interfaces;
using GoodPatient.Infrastructure.Persistance;

namespace GoodPatient.Infrastructure.Repositories
{
    internal class GoodPatientEarningsRepository : IGoodPatientEarningsRepository
    {
        private readonly GoodPatientDbContext _dbContext;

        public GoodPatientEarningsRepository(GoodPatientDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task Commit()
        => _dbContext.SaveChangesAsync();

        public async Task CreateEarnings(Domain.Entities.GoodPatientEarnings GoodPatientEarnings)
        {
            _dbContext.Add(GoodPatientEarnings);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteEarnings(Domain.Entities.GoodPatientEarnings GoodPatientEarnings)
        {
            _dbContext.GoodPatientEarnings.Remove(GoodPatientEarnings);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Domain.Entities.GoodPatientEarnings>> GetAllEarnings()
        => await _dbContext.GoodPatientEarnings.ToListAsync();

        public async Task<Domain.Entities.GoodPatientEarnings> GetByEncodedNameEarnings(string encodedName)
        => await _dbContext.GoodPatientEarnings.FirstAsync(c => c.EncodedName == encodedName);
    }
}
