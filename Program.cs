using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using java.sql;
using idental.Utils;
using idental.iDS;

namespace idental
{
    class Program
    {
        static void Main(string[] args)
        {

            ConfigUtils.LoadConfig();
            Initial();

            idental.Convertion.Practice.Migrate();
            idental.Convertion.Provider.Migrate();
            idental.Convertion.Patient.Migrate();

            Closing();

            Console.ReadKey();
        }
        private static void Initial()
        {
            Logger.CreateLogFile();
            Database.iDentalSoft.CloneH2();
            Database.OpenDental.CreateConnection();
            Database.iDentalSoft.CreateConnection();
        }
        private static void Closing()
        {
            Database.OpenDental.CloseConnection();
            Database.iDentalSoft.CloseConnection();
            Logger.CloseLogFile();
        }
    }
}
