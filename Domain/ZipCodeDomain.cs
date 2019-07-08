using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace idental.Domain
{
    class ZipCodeDomain
    {
        public string ZipCodeDigits { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public ZipCodeDomain(DataRow dr)
        {
            ZipCodeDigits = Convert.ToString(dr["ZipCodeDigits"]);
            City = Convert.ToString(dr["City"]);
            State = Convert.ToString(dr["State"]);
        }
    }
}
