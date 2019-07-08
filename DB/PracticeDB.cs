using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using idental.Utils;
using idental.Domain;
using idental.iDS;
using idental.Const;

namespace idental.DB
{
    class PracticeDB
    {
        internal class OpenDental
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
        internal class iDentalSoft
        {
            public static void InsertNewRecord(PracticeIDS pr)
            {
                pr.PhotoLink = (pr.PhotoLink.Length > 0) ? pr.PhotoLink : iDentalSoftConst.DEFAULT_PHOTO_LINK;

                string sql = "INSERT INTO PRACTICE(PRACTICE_NAME,ADDRESS,PHONE,FAX,BANK_ACCOUNT,"
                            + "PHOTO_LINK, CUSTOMER_ID, ZIP_CODE_ID) VALUES ('"
                            + pr.PracticeName + "','" + pr.Address + "','" + pr.Phone + "','"
                            + pr.Fax + "','" + pr.BankAccount + "','" + pr.PhotoLink + "','"
                            + pr.CustomerID + "'," + pr.ZipCodeID + ")";
                Database.iDenalSoft.Execute(sql);
            }
        }
    }
}
