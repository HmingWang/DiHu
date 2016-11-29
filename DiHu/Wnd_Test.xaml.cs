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

namespace DiHu
{
    /// <summary>
    /// Wnd_Test.xaml 的交互逻辑
    /// </summary>
    public partial class Wnd_Test : Window
    {
        public Wnd_Test()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            DiHu.CBDB_DataSet cBDB_DataSet = ((DiHu.CBDB_DataSet)(this.FindResource("cBDB_DataSet")));
            // 将数据加载到表 BIOG_MAIN 中。可以根据需要修改此代码。
            DiHu.CBDB_DataSetTableAdapters.BIOG_MAINTableAdapter cBDB_DataSetBIOG_MAINTableAdapter = new DiHu.CBDB_DataSetTableAdapters.BIOG_MAINTableAdapter();
            cBDB_DataSetBIOG_MAINTableAdapter.Fill(cBDB_DataSet.BIOG_MAIN);
            System.Windows.Data.CollectionViewSource bIOG_MAINViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("bIOG_MAINViewSource")));
            bIOG_MAINViewSource.View.MoveCurrentToFirst();
            DiHu.cbdb_sqliteDataSet cbdb_sqliteDataSet = ((DiHu.cbdb_sqliteDataSet)(this.FindResource("cbdb_sqliteDataSet")));
          
        }
    }
}
