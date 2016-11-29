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

using System.Data;
using System.Data.SQLite;

namespace DiHu
{
    /// <summary>
    /// Wnd_Detail.xaml 的交互逻辑
    /// </summary>
    public partial class Wnd_Detail : Window
    {
        public Wnd_Detail()
        {
            InitializeComponent();
        }

        public void ShowAddressRelation(long addrcode)
        {
            string sqltext = "select a.c_name_chn, t.c_firstyear,t.c_lastyear from ADDR_BELONGS_DATA t left join addr_codes a on(t.c_addr_id = a.c_addr_id) where t.c_belongs_to= @addrcode ";
            SQLiteParameter[] parms = null;
            
            parms = new SQLiteParameter[1];
            parms[0] = new SQLiteParameter("@addrcode", addrcode);
 
            DataTable dt = DataAccess.DBHelper.ExecuteDataTable(sqltext, parms);
            this.dataGrid.ItemsSource = dt.DefaultView;
        }
    }
}
