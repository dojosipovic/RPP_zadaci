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
    public partial class AddSensor : Form
    {
        public AddSensor()
        {
            InitializeComponent();
        }

        private void AddSensor_Load(object sender, EventArgs e)
        {
            FillTypes();
            FillUnits();
        }

        private void FillUnits()
        {
            cbUnit.DataSource = GetUnits();
        }

        private object GetUnits()
        {
            using(var context = new DB_EntityEntities())
            {
                return context.MeasurementUnits.ToList();
            }
        }

        private void FillTypes()
        {
            cbType.DataSource = GetTypes();
        }

        private object GetTypes()
        {
            using(var context = new DB_EntityEntities())
            {
                return context.SensorTypes.ToList();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            SensorType sensorType = cbType.SelectedItem as SensorType;
            MeasurementUnit unit = cbUnit.SelectedItem as MeasurementUnit;

            Sensor sensor = new Sensor
            {
                Name = name,
                IdSensorTypes = sensorType.Id,
                IdMeasurementUnits = unit.Id
            };

            using(var context = new DB_EntityEntities())
            {
                context.Sensors.Attach(sensor);
                context.Sensors.Add(sensor);
                context.SaveChanges();
            }

            Close();
        }
    }
}
