using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using java.sql;
namespace idental.Utils
{
    class Database
    {
        internal class OpenDental
        {
            private static MySqlConnection connection;
            private static MySqlCommand command;

            private static string host = ConfigUtils.OpenDental.DATABASE_HOST;
            private static string dbName = ConfigUtils.OpenDental.DATABASE_NAME;
            private static string port = ConfigUtils.OpenDental.DATABASE_PORT;
            private static string user = ConfigUtils.OpenDental.DATABASE_USER;
            private static string password = ConfigUtils.OpenDental.DATABASE_PASSWORD;
            private static string connectionString = "Server=" + host + ";Database=" + dbName + ";port=" + port + ";Uid=" +
                                                user + ";Pwd=" + password + ";Convert Zero Datetime=True; SslMode=none";
            public static MySqlConnection CreateConnection()
            {
                try
                {
                    if (connection == null || ConnectionState.Closed.Equals(connection.State))
                    {
                        connection = new MySqlConnection(connectionString);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: Creating Opendental connection error!\n{0}", ex.Message);
                }
                return connection;
            }
            public static DataTable GetDataTable(string sql)
            {
                command = new MySqlCommand(sql, connection);
                DataTable table = new DataTable("tableName");
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(table);
                dataAdapter.Dispose();
                command.Dispose();
                return table;
            }
            public static MySqlConnection CloseConnection()
            {
                connection.Close();
                return connection;
            }
        }
        internal class iDenalSoft
        {
            private static Connection connection;
            private static Statement stat;

            private static string url = ConfigUtils.iDentalSoft.DATABASE_URL;
            private static string user = ConfigUtils.iDentalSoft.DATABASE_USER;
            private static string password = ConfigUtils.iDentalSoft.DATABASE_PASSWORD;
            public static Connection CreateConnection()
            {
                org.h2.Driver.load();
                try
                {
                    if (connection == null || connection.isClosed())
                    {
                        connection = DriverManager.getConnection(url, user, password);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: Creating iDentalSoft connection error!\n{0}", ex.Message);
                }
                return connection;
            }
            public static ResultSet ExecuteQuery(string sqlCommandText)
            {
                stat = connection.createStatement();
                ResultSet result = stat.executeQuery(sqlCommandText);
                stat.Dispose();
                return result;
            }
            public static bool Execute(string sqlCommandText)
            {
                stat = connection.createStatement();
                bool result = stat.execute(sqlCommandText);
                stat.Dispose();
                return result;
            }
            public static Connection CloseConnection()
            {
                connection.close();
                return connection;
            }
        }
    }
}
