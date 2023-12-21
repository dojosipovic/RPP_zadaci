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

namespace Employees
{
    /// <summary>
    /// Interaction logic for UcShowEmployees.xaml
    /// </summary>
    public partial class UcShowEmployees : UserControl
    {
        public UcShowEmployees()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            using(var context = new NorthwindEntities())
            {
                dgEmployees.ItemsSource = context.Employees.ToList();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var employee = dgEmployees.SelectedItem as Employee;
            using(var context = new NorthwindEntities())
            {
                context.Employees.Attach(employee);
                context.Employees.Remove(employee);
                context.SaveChanges();
                dgEmployees.ItemsSource = context.Employees.ToList();
            }
        }
    }
}
