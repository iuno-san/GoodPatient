using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Domain.Entities
{
    public class GoodPatientService
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        public int GoodPatientId { get; set; } = default!;
        public GoodPatient GoodPatient { get; set; } = default!;


    }
}
