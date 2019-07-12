using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idental.Utils
{
    class Logger
    {
        private static string fileName = idental.Utils.ConfigUtils.iDentalSoft.DATABASE_URL + ".txt";
        private static System.IO.StreamWriter logFile;

        public static void CreateLogFile()
        {
            logFile = new System.IO.StreamWriter(fileName);
        }
        public static void CloseLogFile()
        {
            logFile.Close();
        }

        public static void log(string str)
        {
            string time = DateTime.Now.ToString("dd:MM:yyyy-HH:mm:ss");
            string value = "[" + time + "] " + str;
            Console.WriteLine(value);
            logFile.WriteLine(value);
        }
        public static void log(int count, string str)
        {
            log(count + ". " + str);
        }
        public static void log(int count, int total, string str)
        {
            log("["+count+"/"+total+"]. "+str);
        }

        public static void start(string currentTool)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Logger.log("-----------------------------------");
            Logger.log("Migrate " + currentTool);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void end(string currentTool)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Logger.log("-----------------------------------");
            Logger.log("Migrate " + currentTool + " end");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
