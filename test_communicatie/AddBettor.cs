using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_communicatie
{
    public partial class AddBettor : Form
    {
        public Bettor CreatedAddBettor { get; set; }

        public AddBettor()
        {
            InitializeComponent();
        }

        private void goFurtherButton_Click(object sender, EventArgs e)
        {
            
        }

        private void newBettorButton_Click(object sender, EventArgs e)
        {
            if(newBettorTextBox.Text == (""))
            {
                MessageBox.Show("Voeg een gebruikers naam in!");

                return;
            }

            if(newBettorTextBox.Text.Length > 10)
            {
                MessageBox.Show("Je gebruikers naam mag niet langer zijn dan 10 karakters!");

                return;
            }

            if (newBettorTextBox.Text.Length <4)
            {
                MessageBox.Show("Je gebruikers naam moet langer zijn dan 3 karakters!");

                return;
            }

            string name = newBettorTextBox.Text;

            Bettor newAddBettor = new Bettor(name);

            this.CreatedAddBettor = newAddBettor;

            this.Close();
        }

        private void AddBettor_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
