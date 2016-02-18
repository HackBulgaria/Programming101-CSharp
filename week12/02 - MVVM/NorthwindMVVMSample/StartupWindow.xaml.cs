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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for StartupWindow.xaml
    /// </summary>
    public partial class StartupWindow : Window
    {
        public StartupWindow()
        {
            InitializeComponent();
        }

        private void buttonEmployees_Click(object sender, RoutedEventArgs e)
        {
            var wnd = new EmployeesWindow();
            wnd.Owner = this;
            wnd.Show();
        }

        private void buttonOrders_Click(object sender, RoutedEventArgs e)
        {
            var wnd = new OrdersWindow();
            wnd.Owner = this;
            wnd.Show();
        }
    }
}
