using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace idental.Domain
{
    class ProviderDomain
    {
        public ProviderDomain(DataRow dr)
        {
            ProvNum = Convert.ToInt64(dr["ProvNum"]);
            Abbr = Convert.ToString(dr["Abbr"]);
            FName = Convert.ToString(dr["FName"]);
            LName = Convert.ToString(dr["LName"]);
            MI = Convert.ToString(dr["MI"]);
            ProvColor = Convert.ToString(dr["ProvColor"]);
        }
        public Int64 ProvNum { get; set; }
        public string Abbr { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string MI { get; set; }
        public string ProvColor { get; set; }
    }
}
