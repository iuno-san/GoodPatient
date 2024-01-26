using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Domain.Entities
{
    public class GoodPatientEarnings
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Amount { get; set; }
        public string? PatientName { get; set; }
        public string? DateOfVisit { get; set; }
        public string? VisitDescription { get; set; }
        public string? AdditionalNotes { get; set; }
        public string? PaymentMethod { get; set; }

        public string EncodedName { get; set; } = default!;
        public string? CreatedById { get; set; }
        public IdentityUser? CreatedBy { get; set; }
        public void EncodeName() => EncodedName = Name.ToLower().Replace(" ", "-");

    }
}
