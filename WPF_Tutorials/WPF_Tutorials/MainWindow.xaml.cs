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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Tutorials
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_owner_Click(object sender, RoutedEventArgs e)
        {
            Window win = new ChildWindow();
            win.Owner = this;
            win.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            win.Show();
        }

        private void btn_screen_Click(object sender, RoutedEventArgs e)
        {
            Window win = new ChildWindow();
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.Show();
        }

        private void btn_manual_Click(object sender, RoutedEventArgs e)
        {
            Window win = new ChildWindow();
            win.WindowStartupLocation = WindowStartupLocation.Manual;
            win.Show();
        }

        private void btn_top_Click(object sender, RoutedEventArgs e)
        {
            Window win = new ChildWindow();
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.Topmost = true;
            win.Background = Brushes.Cyan;
            win.Show();
        }
    }
}
