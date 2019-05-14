using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkModel
{
    public class LegalEntity
    {
        public int Id { get; set; }

        public int INN { get; set; }

        public int OGRN { get; set; }

        public String Name { get; set; }

        public String Password { get; set; }

        public String Email { get; set; }
    }
}
