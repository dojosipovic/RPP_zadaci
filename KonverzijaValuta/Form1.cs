using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonverzijaValuta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowResult(double convertedAmount)
        {
            tbConverted.Text = convertedAmount.ToString();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var curr1 = CurrencyFactory.GetCurrency(cbFirstCurr.SelectedItem.ToString());
            var curr2 = CurrencyFactory.GetCurrency(cbSecondCurr.SelectedItem.ToString());
            double amount;
            bool isParsed = double.TryParse(tbAmount.Text, out amount);

            if (!isParsed || curr1 == null || curr2 == null) return;

            ShowResult(curr1.ConvertTo(curr2, amount));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbFirstCurr.DataSource = CurrencyFactory.GetNames();
            cbSecondCurr.DataSource = CurrencyFactory.GetNames();
        }
    }
}
