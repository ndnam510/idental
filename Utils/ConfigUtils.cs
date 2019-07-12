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
            public static string DEFAULT_DATABASE_URL = "";
            public static string DATABASE_URL = "";
            public static string DATABASE_USER = "";
            public static string DATABASE_PASSWORD = "";
            public static string CONNECTION_TYPE = "";
        }
        public static void LoadConfig()
        {
            OpenDental.DATABASE_HOST = "localhost";
            OpenDental.DATABASE_NAME = "opendental";
            OpenDental.DATABASE_PORT = "3306";
            OpenDental.DATABASE_USER = "root";
            OpenDental.DATABASE_PASSWORD = "123456";

            iDentalSoft.CONNECTION_TYPE = "jdbc:h2:file:";
            //"jdbc:h2:tcp://localhost/C:\\iDentalSoftData\\data\\db\\iDental"; //server mode
            //local mode = "jdbc:h2:file:C:\\iDentalSoftData\\data\\db\\iDental";
            iDentalSoft.DEFAULT_DATABASE_URL = "D:\\Intern\\iDS\\iDental";
            
            iDentalSoft.DATABASE_URL = iDentalSoft.DEFAULT_DATABASE_URL + DateTime.Now.ToString("_yyyyMMdd-HHmmss");
            iDentalSoft.DATABASE_USER = "SA";
            iDentalSoft.DATABASE_PASSWORD = "";
        }
    }
}
