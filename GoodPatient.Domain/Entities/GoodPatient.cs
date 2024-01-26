using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Domain.Entities
{
    public class GoodPatient
    {
        public int Id { get; set; }
        public string FullName { get; set; } = default!;
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? About { get; set; }
        public string? Age { get; set; }
        public string? Address { get; set; }
        public string? DiseasesAndAllergies { get; set; }
        public string? HealthInsuranceNumber { get; set; }
        public string? Skype { get; set; }
        public string? Facebook { get; set; }
        public string EncodedName { get; set; } = default!;
        public string? CreatedById { get; set; }
        public IdentityUser? CreatedBy { get; set; }
        public List<GoodPatientService> Services { get; set; } = new();
        public void EncodeName() => EncodedName = FullName.ToLower().Replace(" ", "-");
    }
}
