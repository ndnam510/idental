using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using idental.iDS;
using idental.DB;
using idental.Const;
namespace idental.Convertion
{
    class Practice
    {
        public static void Migrate()
        {
            var dt = PracticeDB.OpenDental.GetPractices();

            PracticeIDS t = new PracticeIDS();
            t.PracticeName = Convert.ToString(dt[OpenDentalConst.PRACTICE_NAME]);
            t.Address = Convert.ToString(dt[OpenDentalConst.PRACTICE_ADDRESS]);
            t.Fax = convertPhoneFax(Convert.ToString(dt[OpenDentalConst.PRACTICE_FAX]));
            t.Phone = convertPhoneFax(Convert.ToString(dt[OpenDentalConst.PRACTICE_PHONE]));
            t.BankAccount = Convert.ToString(dt[OpenDentalConst.PRACTICE_BANK_ACCOUNT]);
            t.CustomerID = iDentalSoftConst.DEFAULT_CUSTOMER_ID;
            t.PhotoLink = iDentalSoftConst.DEFAULT_PHOTO_LINK;
            t.ZipCodeID = iDentalSoftConst.DEFAULT_ZIP_CODE_ID;
            PracticeDB.iDentalSoft.InsertNewRecord(t);

        }
        private static string convertPhoneFax(string OpenDentalFax)
        {
            string result = OpenDentalFax;
            if (result.Length != 12)
            {
                result.Replace("-", string.Empty);
                result = result.Insert(3, "-");
                result = result.Insert(7, "-");
            }
            return result;
        }
    }
}
