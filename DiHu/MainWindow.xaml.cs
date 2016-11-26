using System;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DiHu
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (IsInint())
                new Wnd_Individual().Show();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            new SelectDataBase().ShowDialog();

            IsInint();
        }

 

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //DataAccess.Init(".\\cbdb_sqlite.db");

            if (File.Exists(@".\cbdb_sqlite.db"))
            {
                DataAccess.Init(@".\cbdb_sqlite.db");
                labelTips.Visibility = Visibility.Hidden;
            }

            else
            {
                labelTips.Visibility = Visibility.Visible;
            }


            this.button1.IsEnabled = false;
            this.button2.IsEnabled = false;
            this.button3.IsEnabled = false;
            this.button4.IsEnabled = false;
            this.button5.IsEnabled = false;
        }


        private bool IsInint()
        {
            if (!DataAccess.IsConnect())
            {
                MessageBox.Show("数据库尚未初始化，请先选择数据库文件");

                return false;
            }

            labelTips.Visibility = Visibility.Hidden;
            return true;
        }
    }
}
