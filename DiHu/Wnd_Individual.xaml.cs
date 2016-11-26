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
            DataAccess.ConnectionString = @"data source=C:\Users\whaim\Desktop\cbdb_sqlite.db";
            DataAccess.Init();

            SQLiteCommand com = new SQLiteCommand("select * from biog_main where c_name_chn like '%李世民%' ",DataAccess.Connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(com);
            CBDB_DataSet.BIOG_MAINDataTable dt = new CBDB_DataSet.BIOG_MAINDataTable();
            da.Fill(dt);

            this.dataGrid.ItemsSource = dt;


        }
    }
}
