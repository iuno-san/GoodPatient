using Microsoft.EntityFrameworkCore;
using GoodPatient.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Infrastructure.Seeders
{
    public class GoodPatientSeeder
    {
        private readonly GoodPatientDbContext _dbContext;

        public GoodPatientSeeder(GoodPatientDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.GoodPatients.Any())
                {
                    var Jan = new Domain.Entities.GoodPatient()
                    {
                        FullName = "Jan Kowalski",
                        Email = "jankowalski10@gmail.com",
                        PhoneNumber = "+1 (416) 555-7890",
                        About = "Miły starszy pan",
                        Age = "54 lata",
                        Address = "456 radom",
                        DiseasesAndAllergies = "None",
                        HealthInsuranceNumber = "ABC123",
                        Skype = "Jan.kowalski",
                        Facebook = "Jan.kowalski.9"
                    };
                    Jan.EncodeName();

                    _dbContext.Add(Jan);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
