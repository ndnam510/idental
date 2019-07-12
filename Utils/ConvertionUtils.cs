using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using idental.Const;
namespace idental.Utils
{
    class ConvertionUtils
    {
        public static Int64 FormatZip(string zip)
        {
            int index = zip.IndexOf("-");
            string zipString = (index > 0 && zip.Length > index) ? zip.Remove(index) : zip;
            Int64 result;
            try
            {
                result = Convert.ToInt64(zipString);
            }
            catch (Exception ex)
            {
                result = 0;
            }
            return result;
        }
        public static string convertPhoneFax(string OpenDentalFax)
        {
            string result = OpenDentalFax;
            if (result.Length > 10)
            {
                result = result.Replace("-", string.Empty);
                result = result.Replace("(", string.Empty);
                result = result.Replace(")", string.Empty);
            }
            if (result.Length > 7)
            {
                result = result.Insert(3, "-");
                result = result.Insert(7, "-");
            }
            if (result.Length > 12)
                result = result.Remove(12);
            return result;
        }
        internal class Patient
        {
            public static string convertDate(string dateString)
            {
                if (dateString.Equals(""))
                    return DateTime.Now.ToString("yyyyMMdd");

                string result = dateString;
                if (result.Length > 8)
                    result.Replace("-", string.Empty);
                return result;
            }
            public static string convertGender(ushort gender)
            {
                if (gender == OpenDentalConst.GENDER_MALE)
                    return iDentalSoftConst.GENDER_MALE;
                else
                    return iDentalSoftConst.GENDER_FEMALE;
            }
            public static string convertTitle(ushort gender)
            {
                if (gender == OpenDentalConst.GENDER_MALE)
                    return iDentalSoftConst.TITLE_MR;
                else
                    return iDentalSoftConst.TITLE_MS;
            }
            public static bool convertActiceStatus(int patStatus)
            {
                switch (patStatus)
                {
                    case 0:
                    case 1:
                        return iDentalSoftConst.Patient.STATUS_ACTIVE;
                    default:
                        return iDentalSoftConst.Patient.STATUS_INACTICE;
                }
            }
        }
    }
}
