using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using idental.Utils;
using java.sql;
namespace idental
{
    class UserDao
    {
        public static int InsertUser(UserDto dto)
        {
            string sql = "INSERT INTO USERS(LAST_NAME,MIDDLE_INITIAL,FIRST_NAME,PHOTO_LINK,USER_TYPE,OTHER_NAME,ZIP_CODE_ID,ADDRESS,EMAIL,HOME_PHONE,MOBILE_PHONE) VALUES (?,?,?,?,?,?,?,?,?,?,?);";
            PreparedStatement prepStat = Database.iDentalSoft.Connection().prepareStatement(sql);
            DatabaseUtils.SetParameters(ref prepStat, dto);
            return prepStat.executeUpdate();
        }
    }
}
