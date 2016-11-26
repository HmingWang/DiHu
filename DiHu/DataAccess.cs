using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;

namespace DiHu
{
    class DataAccess
    {
        private static SQLiteConnection sqliteConnection;
        private static string connectionString;

        public static string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public static SQLiteConnection Connection
        {
            get { return sqliteConnection; }
        }

        public static void Init()
        {
            sqliteConnection = new SQLiteConnection(connectionString);
            sqliteConnection.Open();
        }
    }
}
