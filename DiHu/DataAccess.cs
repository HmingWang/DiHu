using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiHu
{
    class DataAccess
    {
        private static SQLiteHelper dbHelper;

        public static SQLiteHelper DBHelper
        {
            get { return dbHelper; }
        }

        public static void Init(String dbPath)
        {
            dbHelper = new SQLiteHelper(dbPath);
        }


        public static bool IsConnect()
        {
            if (dbHelper == null) return false;
            return dbHelper.IsConnect();
        }
    }


    class DAException : ApplicationException
    {
        public DAException(string message) : base(message) { }
    }
}
