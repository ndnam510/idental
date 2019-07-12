using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idental.Const
{
    class OpenDentalConst
    {
        public static string PRACTICE_NAME = "PracticeTitle";
        public static string PRACTICE_ADDRESS = "PracticeAddress";
        public static string PRACTICE_ZIPCODE = "PracticeZip";
        public static string PRACTICE_PHONE = "PracticePhone";
        public static string PRACTICE_FAX = "PracticeFax";
        public static string PRACTICE_BANK_ACCOUNT = "PracticeBankNumber";
        public static string PRACTICE_CITY = "PracticeCity";
        public static string PRACTICE_ST = "PracticeST";

        public static ushort GENDER_MALE = 0;
        public static ushort GENDER_FEMALE = 1;
        internal class Patient
        {
            public static ushort STATUS_INACTIVE = 2;
            public static ushort STATUS_PATIENT = 0;
            public static ushort STATUS_NONPATIENT = 4;
        }
    }
}
