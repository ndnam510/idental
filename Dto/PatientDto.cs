using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idental
{
    class PatientDto
    {
        public Int64 UserID { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string MedicalAlert { get; set; }
        public string TimeZone { get; set; }
        public string OfficePhone { get; set; }
        public Int64 ProviderID { get; set; }
        public string ResponsibleParty { get; set; }
        public string Coverage { get; set; }
        public string DOB { get; set; } //Date Of Birth
        public string ActiveDate { get; set; }
        public string Note { get; set; }
        public Int64 PracticeID { get; set; }
        public bool Active { get; set; }
        public string PatientKey { get; set; }
        public string PatientID { get; set; }
        public Int64 PatientIDNumeric { get; set; }
    }
}
