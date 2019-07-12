using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using idental.Domain;
using idental.Utils;
namespace idental.DaoOD
{
    class PatientDaoOD
    {
        public static List<PatientDomain> GetListPatients()
        {
            string sql = "SELECT * FROM PATIENT";
            DataTable dt = Database.OpenDental.GetDataTable(sql);
            List<PatientDomain> result = new List<PatientDomain>();
            foreach (DataRow dr in dt.Rows)
            {
                PatientDomain domain = new PatientDomain(dr);
                result.Add(domain);
            }
            return result;
        }
    }
}
