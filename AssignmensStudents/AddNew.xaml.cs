﻿using System;
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
using System.Windows.Shapes;

namespace AssignmensStudents
{
    /// <summary>
    /// Interaction logic for AddNew.xaml
    /// </summary>
    public partial class AddNew : Window
    {
        public AddNew()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbStatus.ItemsSource = GetStatuses();
        }

        private List<AssignmentStatus> GetStatuses()
        {
            using(var context = new EF_DBEntities())
            {
                return context.AssignmentStatuses.ToList();
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var status = cbStatus.SelectedItem as AssignmentStatus;
            var assignment = new Assignment
            {
                Student = txtStudent.Text,
                Description = txtDescription.Text,
                Points = int.Parse(txtPoints.Text),
                AssignmentStatus = status,
            };

            using (var context = new EF_DBEntities())
            {
                context.Assignments.Add(assignment);
                context.SaveChanges();
            }

            Close();
        }
    }
}
