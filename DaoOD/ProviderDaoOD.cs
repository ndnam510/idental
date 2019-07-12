using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using idental.Domain;
using idental.Utils;
namespace idental.Dao
{
    class ProviderDaoOD
    {
        public static List<ProviderDomain> getProviders()
        {
            
            string sql = "SELECT * FROM PROVIDER";
            DataTable dt = Database.OpenDental.GetDataTable(sql);

            List <ProviderDomain> result = new List<ProviderDomain>();
            foreach (DataRow dr in dt.Rows)
            {
                ProviderDomain domain = new ProviderDomain(dr);
                result.Add(domain);
            }
            return result;
        }
    }
}
