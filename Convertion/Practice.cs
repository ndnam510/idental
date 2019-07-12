using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using idental.Dao;
using idental.Const;
using idental.Utils;
namespace idental.Convertion
{
    class Practice
    {
        public static string s_PracticeName = "";
        public static void Migrate()
        {
            Logger.start("Practice");
            var dt = PracticeDaoOD.GetPractices();
            int count = 0;
            PracticeDto t = new PracticeDto();
            t.PracticeName = Convert.ToString(dt[OpenDentalConst.PRACTICE_NAME]);
            t.Address = Convert.ToString(dt[OpenDentalConst.PRACTICE_ADDRESS]);
            t.Fax = ConvertionUtils.convertPhoneFax(Convert.ToString(dt[OpenDentalConst.PRACTICE_FAX]));
            t.Phone = ConvertionUtils.convertPhoneFax(Convert.ToString(dt[OpenDentalConst.PRACTICE_PHONE]));
            t.BankAccount = Convert.ToString(dt[OpenDentalConst.PRACTICE_BANK_ACCOUNT]);
            t.CustomerID = iDentalSoftConst.DEFAULT_CUSTOMER_ID;
            t.PhotoLink = iDentalSoftConst.DEFAULT_PHOTO_LINK;
            t.ZipCodeID = ConvertionUtils.FormatZip(Convert.ToString(dt[OpenDentalConst.PRACTICE_ZIPCODE]));
            PracticeDao.InsertNewRecord(t);
            s_PracticeName = t.PracticeName;
            Logger.log(++count, "Insert Practice");
            Logger.end("Practice");
        }
    }
}
