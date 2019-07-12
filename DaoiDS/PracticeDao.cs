using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using idental.Utils;
using idental.Const;
using java.sql;
namespace idental
{
    class PracticeDao
    {
        public static void InsertNewRecord(PracticeDto pr)
        {
            pr.PhotoLink = (pr.PhotoLink.Length > 0) ? pr.PhotoLink : iDentalSoftConst.DEFAULT_PHOTO_LINK;

            string sql = "INSERT INTO PRACTICE(PRACTICE_NAME,ADDRESS,PHONE,FAX,BANK_ACCOUNT,"
                        + "PHOTO_LINK, CUSTOMER_ID, ZIP_CODE_ID) VALUES ('"
                        + pr.PracticeName + "','" + pr.Address + "','" + pr.Phone + "','"
                        + pr.Fax + "','" + pr.BankAccount + "','" + pr.PhotoLink + "','"
                        + pr.CustomerID + "'," + pr.ZipCodeID + ");";
            Database.iDentalSoft.Execute(sql);
        }
        public static int GetPracticeID(string practiceName)
        {
            string sql = "SELECT PRACTICE_ID FROM PRACTICE WHERE PRACTICE_NAME='" + practiceName + "';";
            ResultSet rs = Database.iDentalSoft.ExecuteQuery(sql);
            if (rs.next())
                return rs.getInt(1);
            else
                return 0;
        }
    }
}
