using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idental.Utils
{
    class ConfigUtils
    {
        internal class OpenDental
        {
            public static string DATABASE_HOST = "";
            public static string DATABASE_NAME = "";
            public static string DATABASE_PORT = "";
            public static string DATABASE_USER = "";
            public static string DATABASE_PASSWORD = "";
        }
        internal class iDentalSoft
        {
            public static string DATABASE_URL = "";
            public static string DATABASE_USER = "";
            public static string DATABASE_PASSWORD = "";
        }
        public static void LoadConfig()
        {
            OpenDental.DATABASE_HOST = "localhost";
            OpenDental.DATABASE_NAME = "opendental";
            OpenDental.DATABASE_PORT = "3306";
            OpenDental.DATABASE_USER = "root";
            OpenDental.DATABASE_PASSWORD = "123456";

            iDentalSoft.DATABASE_URL = "jdbc:h2:file:D:\\Intern\\iDS\\iDental";
            //"jdbc:h2:tcp://localhost/C:\\iDentalSoftData\\data\\db\\iDental"; //server mode
            //local mode = "jdbc:h2:file:C:\\iDentalSoftData\\data\\db\\iDental";
            iDentalSoft.DATABASE_USER = "SA";
            iDentalSoft.DATABASE_PASSWORD = "";
        }
    }
}
