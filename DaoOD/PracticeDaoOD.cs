using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using idental.Utils;
using idental.Domain;
using idental.Const;

namespace idental.Dao
{
    class PracticeDaoOD
    {
        public static Dictionary<string, string> GetPractices()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            string sql = "SELECT * FROM PREFERENCE";
            DataTable dt = Database.OpenDental.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                PracticeDomain pr = new PracticeDomain(dr);
                result.Add(pr.PrefName, pr.ValueString);
            }
            return result;
        }
    }
}
