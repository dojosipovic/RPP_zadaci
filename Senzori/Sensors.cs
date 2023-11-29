using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senzori
{
    public partial class Sensors : Form
    {
        public Sensors()
        {
            InitializeComponent();
        }

        private void Sensors_Load(object sender, EventArgs e)
        {
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            dgvSensors.DataSource = GetSeonsors();
            dgvSensors.Columns["SensorType"].Visible = false;
            dgvSensors.Columns["MeasurementUnit"].Visible = false;
        }

        private object GetSeonsors()
        {
            using(var context = new DB_EntityEntities())
            {
                return context.Sensors.ToList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Sensor sensor = dgvSensors.CurrentRow.DataBoundItem as Sensor;
            using(var context = new DB_EntityEntities())
            {
                context.Sensors.Attach(sensor);
                context.Sensors.Remove(sensor);
                context.SaveChanges();
            }
            RefreshGUI();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form addSensor = new AddSensor();
            addSensor.ShowDialog();
            RefreshGUI();
        }
    }
}
