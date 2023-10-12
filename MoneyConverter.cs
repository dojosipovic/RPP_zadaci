using MoneyConverter.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyConverter
{
    public partial class MoneyConverter : Form
    {
        public MoneyConverter()
        {
            InitializeComponent();
        }

        private void MoneyConverter_Load(object sender, EventArgs e)
        {
            foreach (var curr in CurrencyRepository.currencies)
            {
                cbFirstCurr.Items.Add(curr);
                cbSecondCurr.Items.Add(curr);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var firstCurr = cbFirstCurr.SelectedItem as Currency;
            var secondCurr = cbSecondCurr.SelectedItem as Currency;
            var amount = 0;
            bool isParsed = int.TryParse(tbAmount.Text, out amount);

            if (!isParsed )
            {
                MessageBox.Show("Molimo unesite broj!");
            }
            else if (firstCurr == null || secondCurr == null)
            {
                MessageBox.Show("Odaberite sve valute!");
            }
            else if (amount < 0)
            {
                MessageBox.Show("Unijeli ste negativan broj!");
            }
            else
            {
                var converted = firstCurr.Exchange / secondCurr.Exchange * amount;
                tbConverted.Text = converted.ToString();
            }
            
        }
    }
}
