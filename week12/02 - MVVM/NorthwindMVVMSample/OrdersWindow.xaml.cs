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
    /// Interaction logic for OrdersWindow.xaml
    /// </summary>
    public partial class OrdersWindow : Window
    {
        OrdersWindowViewModel viewModel = new OrdersWindowViewModel();

        public OrdersWindow()
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }

        ProductsWindow productsWindow;

        private void ordersGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var order = this.ordersGrid.SelectedItem as Order;
            if(order == null)
            {
                return;
            }

            if (productsWindow == null)
            {
                productsWindow = new ProductsWindow();
                productsWindow.Owner = this;
            }

            productsWindow.ViewModel = new ProductsWindowViewModel(order.OrderID);
            productsWindow.Show();
        }
    }

    public class OrdersWindowViewModel
    {
        public List<Order> Orders
        {
            get
            {
                return DataAccess.Context.Orders.ToList();
            }
        }
    }
}
