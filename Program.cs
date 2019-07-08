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
            Database.OpenDental.CreateConnection();
            Database.iDenalSoft.CreateConnection();

            idental.Convertion.Practice.Migrate();
            Console.WriteLine("Practice migrate completed");

            Database.OpenDental.CloseConnection();
            Database.iDenalSoft.CloseConnection();
            Console.ReadKey();
        }
    }
}
