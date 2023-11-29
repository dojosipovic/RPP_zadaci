using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            FillStatuses();
            AssignmentStatus status = dgvStatuses.CurrentRow.DataBoundItem as AssignmentStatus;
            FillAssignments(status);
        }

        private void FillAssignments(AssignmentStatus status)
        {
            dgvAssignments.DataSource = GetAssignments(status);
            dgvAssignments.Columns["AssignmentStatus"].Visible = false;
        }

        private object GetAssignments(AssignmentStatus status)
        {
            List<Assignment> assignments = new List<Assignment>();
            using(var context = new EF_DBEntities())
            {
                assignments = context.Assignments.ToList();
                return assignments.FindAll(x => x.IdAssignmentStatuses == status.Id);
            }
        }

        private void FillStatuses()
        {
            dgvStatuses.DataSource = GetStatuses();
            dgvStatuses.Columns["Assignments"].Visible = false;
        }

        private object GetStatuses()
        {
            using(var context = new EF_DBEntities())
            {
                return context.AssignmentStatuses.ToList();
            }
        }

        private void dgvStatuses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AssignmentStatus status = dgvStatuses.CurrentRow.DataBoundItem as AssignmentStatus;
            FillAssignments(status);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string student = txtStudent.Text;
            string description = txtDescription.Text;
            int points;
            bool success = int.TryParse(txtPoints.Text, out points);
            AssignmentStatus status = dgvStatuses.CurrentRow.DataBoundItem as AssignmentStatus;

            if (!success) return;

            Assignment assignment = new Assignment
            {
                Student = student,
                Description = description,
                Points = points,
                IdAssignmentStatuses = status.Id
            };

            using(var context = new EF_DBEntities())
            {
                context.Assignments.Attach(assignment);
                context.Assignments.Add(assignment);
                context.SaveChanges();
            }
            RefreshGUI();
            txtStudent.Text = "";
            txtDescription.Text = "";
            txtPoints.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Assignment assignment = dgvAssignments.CurrentRow.DataBoundItem as Assignment;
            using(var context = new EF_DBEntities())
            {
                context.Assignments.Attach(assignment);
                context.Assignments.Remove(assignment);
                context.SaveChanges();
            }
            RefreshGUI();
        }
    }
}
