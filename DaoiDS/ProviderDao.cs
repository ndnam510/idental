using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using idental.Utils;
using java.sql;
namespace idental
{
    class ProviderDao
    {
        public static int InsertStaffPractice(ProviderDto dto)
        {
            string sql = "INSERT INTO STAFF_PRACTICE(USER_ID,PRACTICE_ID,PROVIDER_COLOR,STAFF_KEY,DISPLAY_ID,PAY_RATE) VALUES (?,?,?,?,?,0);";
            PreparedStatement prepStat = Database.iDentalSoft.Connection().prepareStatement(sql);
            DatabaseUtils.SetParameters(ref prepStat, dto);
            return prepStat.executeUpdate();
        }
        public static Int64 GetProviderIDbyProviderKey(string providerKey)
        {
            string sql = "SELECT STAFF_ID FROM STAFF_PRACTICE WHERE STAFF_KEY='" + providerKey + "'";
            ResultSet rs = Database.iDentalSoft.ExecuteQuery(sql);
            if (rs.next())
                return rs.getInt(1);
            else
                return 0;
        }
    }
}
