using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectsReport
{
    public partial class ProjectRepotForm : Form
    {
        private ProjectCatalog catalog;
        public ProjectRepotForm()
        {
            InitializeComponent();
        }

        private void btnDisplaySelected_Click(object sender, EventArgs e)
        {
            string mentor = cmbMentors.SelectedItem.ToString();
            txtReport.Text = catalog.CreateReport(mentor);
        }

        private void ProjectRepotForm_Load(object sender, EventArgs e)
        {
            var team1 = new List<string>()
            {
                "Ana Lukić",
                "Pero Horvat",
                "Ivana Markić"
            };
            var team2 = new List<string>()
            {
                "Luka Anić",
                "Marko Horvat",
                "Marija Perić"
            };

            catalog = new ProjectCatalog(new List<IProject>()
            {
                new IndividualProject("Ivan Lukić", "Marko Mijač", "Warehouse.NET"),
                new IndividualProject("Petar Ivanović", "Zlatko Stapić", "Library.NET"),
                new TeamProject("Marko Mijač", "Fitness.NET", team1),
                new TeamProject("Zlatko Stapić", "Agro.NET", team2),
            });

            catalog.GetMentors().ForEach(m => cmbMentors.Items.Add(m));
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            txtReport.Text = catalog.CreateReport();
        }
    }
}
