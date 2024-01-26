using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GoodPatient.Application.GoodPatientEarnings
{
    public class GoodPatientEarningsDto
    {
        public string Name { get; set; } = default!;
        public string? Amount { get; set; }
        public string? PatientName { get; set; }
        public string? DateOfVisit { get; set; }
        public string? VisitDescription { get; set; }
        public string? AdditionalNotes { get; set; }
        public string? PaymentMethod { get; set; }
        public string? EncodedName { get; set; }
        public bool IsEditable { get; set; }
    }
}
