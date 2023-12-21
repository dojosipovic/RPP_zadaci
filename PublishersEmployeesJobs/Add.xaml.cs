using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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

namespace PublishersEmployeesJobs
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : UserControl
    {
        private DataGrid dataGrid;
        public Add(DataGrid dg)
        {
            InitializeComponent();
            dataGrid = dg;
        }

        private void btnCalcel_Click(object sender, RoutedEventArgs e)
        {
            Content = null;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            cbJobs.ItemsSource = GetJobs();
            cbPublisher.ItemsSource = GetPublishers();
        }

        private List<publisher> GetPublishers()
        {
            using(var context = new pubsEntities())
            {
                return context.publishers.ToList();
            }
        }

        private List<job> GetJobs()
        {
            using(var context = new pubsEntities())
            {
                return context.jobs.ToList();
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            /*DateTime date = calHireDate.SelectedDate.Value;
            var _job = cbJobs.SelectedItem as job;
            var pub = cbPublisher.SelectedItem as publisher;
            var employee = new employee
            {
                emp_id = "EAL44273G",
                fname = txtFirstname.Text,
                lname = txtLastName.Text,
                minit = txtMinit.Text,
                job_id = _job.job_id,
                pub_id = pub.pub_id,
                job = _job,
                publisher = pub,
                hire_date = date
            };

            using(var context = new pubsEntities())
            {
                context.jobs.Attach(_job);
                context.publishers.Attach(pub);
                context.employees.Add(employee);
                context.SaveChanges();
            }*/

            RefreshDG();
            Content = null;
        }

        private void RefreshDG()
        {
            dataGrid.ItemsSource = GetEmployees();
        }

        private IEnumerable GetEmployees()
        {
            using(var context = new pubsEntities())
            {
                return context.employees.Include("job").Include("publisher").ToList();
            }
        }
    }
}
