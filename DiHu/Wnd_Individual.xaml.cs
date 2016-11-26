using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Data.SQLite;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Data;

namespace DiHu
{
    /// <summary>
    /// Wnd_Individual.xaml 的交互逻辑
    /// </summary>
    public partial class Wnd_Individual : Window
    {
        public Wnd_Individual()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string sqltext = "select * from biog_main";
            SQLiteParameter[] parms = null;
            if (!String.IsNullOrEmpty(this.textBox.Text))
            {
                sqltext += " where c_name_chn like @name";

                parms = new SQLiteParameter[1];
                parms[0] = new SQLiteParameter("@name", "%" + this.textBox.Text.Trim() + "%");
            }
           
            DataTable dt = DataAccess.DBHelper.ExecuteDataTable(sqltext, parms);
            
            this.dataGrid.ItemsSource = dt.DefaultView;
        }
    }
}
