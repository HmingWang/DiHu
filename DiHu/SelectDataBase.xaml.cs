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

namespace DiHu
{
    /// <summary>
    /// SelectDataBase.xaml 的交互逻辑
    /// </summary>
    public partial class SelectDataBase : Window
    {
        public SelectDataBase()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBox.Text))
            {
                MessageBox.Show("请选择SQLite数据库文件");
                return;
            }

            try
            {
                DataAccess.ConnectionString = "data source=" + this.textBox.Text;
                DataAccess.Init();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }

            Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "SQLite数据库文件|*.db";

            if (dialog.ShowDialog() == true)
            {
                this.textBox.Text = dialog.FileName;
            }
        }
    }
}
