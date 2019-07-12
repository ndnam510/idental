using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idental.Const
{
    class iDentalSoftConst
    {
        public static string DEFAULT_PHOTO_LINK = "images/photo/practice_photo.jpg";
        public static Int64 DEFAULT_ZIP_CODE_ID = 12345;
        public static string DEFAULT_CUSTOMER_ID = "30003350";

        public static string DEFAULT_ZIP_CLASS = "STANDARD";

        public static string USER_PROVIDER_TYPE = "STAFF";

        public static string GENDER_MALE = "MALE";
        public static string GENDER_FEMALE = "FEMALE";
        public static string TITLE_MR = "Mr";
        public static string TITLE_MS = "Ms";
        internal class Patient
        {
            public static string MARITAL_STATUS = "NOT_SPECIFY";
            public static string MEDICAL_ALERT = "None";
            public static string TIME_ZONE = "Pacific";
            public static string RESPONSIBLE_PARTY = "GUARANTOR";
            public static string COVERAGE = "NONE";
            public static bool STATUS_ACTIVE = true;
            public static bool STATUS_INACTICE = false;
            public static string USER_TYPE = "PATIENT";
        }
    }
}
