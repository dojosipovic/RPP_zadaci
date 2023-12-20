using System;
using System.Collections;
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

namespace AssignmensStudents
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            dgStudents.ItemsSource = GetStudents();
            //dgStudents.Columns[5].Visibility = Visibility.Collapsed;
        }

        private List<Assignment> GetStudents()
        {
            using(var context = new EF_DBEntities())
            {
                return context.Assignments.Include("AssignmentStatus").ToList();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var assignment = dgStudents.SelectedItem as Assignment;
            if (assignment != null)
            {
                using(var context = new EF_DBEntities())
                {
                    context.Assignments.Attach(assignment);
                    context.Assignments.Remove(assignment);
                    context.SaveChanges();
                }
                RefreshGUI();
            }
        }

        private void btnAddNew_Click(object sender, RoutedEventArgs e)
        {
            var window = new AddNew();
            window.ShowDialog();
            RefreshGUI();
        }
    }
}
