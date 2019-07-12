using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using java.sql;
using idental.Utils;
namespace idental
{ 
    class PatientDao
    {
        public static int insert(PatientDto dto)
        {
            string sql = DatabaseUtils.GetSqlCommandText(dto);
            PreparedStatement prepStat = Database.iDentalSoft.Connection().prepareStatement(sql);
            DatabaseUtils.SetParameters(ref prepStat, dto);
            return prepStat.executeUpdate();
        }
    }
}
