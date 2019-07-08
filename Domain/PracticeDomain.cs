using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace idental.Domain
{
    class PracticeDomain
    {
        public string PrefName { get; set; }
        public string ValueString { get; set; }

        public PracticeDomain(DataRow practice)
        {
            PrefName = Convert.ToString(practice["PrefName"]);
            ValueString = Convert.ToString(practice["ValueString"]);
        }
    }
}
