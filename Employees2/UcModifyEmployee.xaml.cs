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

namespace Employees2
{
    /// <summary>
    /// Interaction logic for UcModifyEmployee.xaml
    /// </summary>
    public partial class UcModifyEmployee : UserControl
    {
        private Employee employee;
        public UcModifyEmployee(Employee em)
        {
            InitializeComponent();
            employee = em;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txtFirstname.Text = employee.FirstName;
            txtLastname.Text = employee.LastName;
            txtCity.Text = employee.City;
            txtCountry.Text = employee.Country;

            using(var context = new NorthwindEntities())
            {
                cbReports.ItemsSource = context.Employees.ToList();
            }

            for(int i=0; i<cbReports.Items.Count; i++)
            {
                if ((cbReports.Items[i] as Employee).EmployeeID == employee.EmployeeID)
                {
                    cbReports.SelectedIndex = i;
                }
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            UcShowEmployees ucShowEmployees = new UcShowEmployees();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.contentControl.Content = ucShowEmployees;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            using(var context = new NorthwindEntities())
            {
                context.Employees.Attach(employee);

                employee.FirstName = txtFirstname.Text;
                employee.LastName = txtLastname.Text;
                employee.City = txtCity.Text;
                employee.Country = txtCountry.Text;
                employee.ReportsTo = (cbReports.SelectedItem as Employee).EmployeeID;

                context.SaveChanges();
            }

            UcShowEmployees ucShowEmployees = new UcShowEmployees();
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow.contentControl.Content = ucShowEmployees;
        }
    }
}
