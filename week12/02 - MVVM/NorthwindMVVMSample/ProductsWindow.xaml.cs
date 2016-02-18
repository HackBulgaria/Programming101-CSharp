using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for ProductsWindow.xaml
    /// </summary>
    public partial class ProductsWindow : Window
    {
        private ProductsWindowViewModel viewModel;

        public ProductsWindow()
        {
            InitializeComponent();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            e.Cancel = true;
            this.Hide();
        }

        public ProductsWindowViewModel ViewModel
        {
            get
            {
                return viewModel;
            }

            set
            {
                viewModel = value;
                this.DataContext = viewModel;
            }
        }
    }

    public class ProductsWindowViewModel
    {
        List<Product> list;

        public ProductsWindowViewModel(int orderId)
        {
            list = DataAccess.GetProductsForOrder(orderId);
        }

        public List<Product> Products
        {
            get { return list; }
        }
    }
}
