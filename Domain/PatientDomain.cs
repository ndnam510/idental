using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace idental.Domain
{
    class PatientDomain
    {
        public PatientDomain(DataRow dr)
        {
            PatNum = Convert.ToInt64(dr["PatNum"]);
            LName = Convert.ToString(dr["LName"]);
            FName = Convert.ToString(dr["FName"]);
            MiddleI = Convert.ToString(dr["MiddleI"]);
            Preferred = Convert.ToString(dr["Preferred"]);
            PatStatus = Convert.ToUInt16(dr["PatStatus"]);
            Gender = Convert.ToUInt16(dr["Gender"]);
            BirthDate = string.Format("{0:yyyyMMdd}", Convert.ToDateTime(dr["BirthDate"]));
            Address = Convert.ToString(dr["Address"]);
            Address2 = Convert.ToString(dr["Address2"]);
            Zip = string.IsNullOrEmpty(Convert.ToString(dr["Zip"]))? "0" : Convert.ToString(dr["Zip"]);
            HmPhone = Convert.ToString(dr["HmPhone"]);
            WkPhone = Convert.ToString(dr["WkPhone"]);
            WirelessPhone = Convert.ToString(dr["WirelessPhone"]);
            Email = Convert.ToString(dr["Email"]);
            PriProv = Convert.ToInt64(dr["PriProv"]);
            MedUrgNote = Convert.ToString(dr["MedUrgNote"]);
        }
        public Int64 PatNum { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string MiddleI { get; set; }
        public string Preferred { get; set; } //othername
        public ushort PatStatus { get; set; }
        public ushort Gender { get; set; }
        public string BirthDate { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Zip { get; set; }
        public string HmPhone { get; set; }
        public string WkPhone { get; set; }
        public string WirelessPhone { get; set; }
        public string Email { get; set; }
        public Int64 PriProv { get; set; }
        public string MedUrgNote { get; set; }
    }
}
