using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkModel
{
    public class Case
    {
        public int Id { get; set; }

        public int CaseNumber { get; set; }

        public int AmountOfClaim { get; set; }

        public string PlaintiffFIO { get; set; }

        public string RespondentFIO { get; set; }

        public string LegalObject { get; set; }
    }
}
