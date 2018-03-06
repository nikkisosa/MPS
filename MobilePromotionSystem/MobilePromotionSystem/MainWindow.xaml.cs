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

namespace MobilePromotionSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnContact_Click(object sender, RoutedEventArgs e)
        {
            Contacts contactPage = new Contacts();
            pageShow.Children.Add(contactPage);
        }

        private void btnDash_Click(object sender, RoutedEventArgs e)
        {
            Dashboard DashboardPage = new Dashboard();
            pageShow.Children.Add(DashboardPage);
        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            Productpromotion ProductPage = new Productpromotion();
            pageShow.Children.Add(ProductPage);
        }
    }
}
