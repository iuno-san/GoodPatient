using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GoodPatient.Application.GoodPatient
{
    public class GoodPatientDto
    {
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
        public string? EncodedName { get; set; }
        public bool IsEditable { get; set; }
    }
}
