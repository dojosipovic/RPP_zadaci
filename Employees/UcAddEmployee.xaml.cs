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
    /// Interaction logic for UcAddEmployee.xaml
    /// </summary>
    public partial class UcAddEmployee : UserControl
    {
        public UcAddEmployee()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            using(var context = new NorthwindEntities())
            {
                cbReports.ItemsSource = context.Employees.ToList();
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var employee = new Employee
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                City = txtCity.Text,
                Title = txtTitle.Text,
                ReportsTo = (cbReports.SelectedItem as Employee).EmployeeID
            };

            using(var context = new NorthwindEntities())
            {
                context.Employees.Add(employee);
                context.SaveChanges();
            }

            UcShowEmployees showEmployees = new UcShowEmployees();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.contentControl.Content = showEmployees;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Content = null;
        }
    }
}
