using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherProjects
{
    public partial class ProjectForm : Form
    {
        public ProjectForm()
        {
            InitializeComponent();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            var teacher = cmbTeachers.SelectedItem;
            if (teacher != null)
            {
                txtReport.Text = ProjectReporter.GenerateReport(teacher.ToString());
            }
        }
    }
}
