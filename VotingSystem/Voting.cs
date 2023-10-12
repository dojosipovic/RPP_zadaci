using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class Voting : Form
    {
        public Voting()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoadVotes()
        {
            lblAbstained.Text = VoteRepository.options["ABSTAINED"].ToString();
            lblAgainst.Text = VoteRepository.options["AGAINST"].ToString();
            lblFor.Text = VoteRepository.options["FOR"].ToString();
        }

        private void Voting_Load(object sender, EventArgs e)
        {
            foreach (string option in VoteRepository.options.Keys)
            {
                cbOption.Items.Add(option);
            }

            LoadVotes();
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"/^\d{11}$/g");
            var oib = tbOIB.Text.Trim();
            var key = cbOption.SelectedItem as string;

            if (oib == null || key == null)
            {
                MessageBox.Show("Unesite sve podatke!"); return;
            }

            if (oib.Length != 11)
            {
                MessageBox.Show("OIB mora imati 11 znamenaka!"); return;
            }

            if (reg.IsMatch(oib))
            {
                MessageBox.Show("OIB mora sadržavati samo znamke!"); return;
            }

            if (!VoteRepository.isVoted(oib))
            {
                VoteRepository.addOIB(oib);
                VoteRepository.options[key]++;
                LoadVotes();
            }
            else { MessageBox.Show("Već ste glasali!"); }
            
        }
    }
}
