using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_communicatie
{
    public partial class MainForm : Form
    {
        public string bettor { get; set; }
        public int money = 100;


        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddBettor form = new AddBettor();
            form.ShowDialog();

            Bettor bettor = form.CreatedAddBettor;

            try
            {
                nameBettorLabel.Text = bettor.ToString();
            }
            catch (System.NullReferenceException)
            {
                Environment.Exit(1);
            }

            walletLabel.Text = money.ToString();

            System.Net.WebClient downloader = new System.Net.WebClient();
            string teamJson;

            teamJson = downloader.DownloadString("http://localhost/fifa-Php/PHP/jsonecho.php?key=hDMc4pFrC3");

            List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(teamJson);

            foreach(Team team in teams)
            {
                showTeamsListBox.Items.Add(team.teamname);
            }

            string matchJson;

            matchJson = downloader.DownloadString("http://localhost/fifa-Php/PHP/matchesjsonecho.php?key=hDMc4pFrC3");
            List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(matchJson);


            for (int i = 0; i < matches.Count ; i++)
            {
                machtesComboBox.Items.Add(matches[i]);
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if(machtesComboBox.Text == "")
            {
                MessageBox.Show("Selecteer een wedstrijd!");

                return;
            }


            if (team1RadioButton.Checked)
            {
                try
                {
                    string team = team1RadioButton.Text;
                    Match match = (Match)machtesComboBox.SelectedItem;
                    int betAmount = int.Parse(betAmountTextBox.Text);


                    if(betAmount < 1)
                    {
                        MessageBox.Show("Je moet minimaal 1 euro inzetten");

                        return;
                    }

                    if (money < betAmount)
                    {
                        MessageBox.Show("Je hebt niet genoeg geld!");

                        return;
                    }

                    money = money - betAmount;
                    walletLabel.Text = money.ToString();

                    Bet newBet = new Bet(match, betAmount, team);

                    MessageBox.Show(newBet.ToString());
                }
                catch (FormatException)
                {
                    MessageBox.Show("Voer een geldig geld bedrag in!");
                }
            }

            if (team2RadioButton.Checked)
            {
                try
                {
                    string team = team2RadioButton.Text;
                    Match match = (Match)machtesComboBox.SelectedItem;
                    int betAmount = int.Parse(betAmountTextBox.Text);


                    if (betAmount < 1)
                    {
                        MessageBox.Show("Je moet minimaal 1 euro inzetten");

                        return;
                    }

                    if (money < betAmount)
                    {
                        MessageBox.Show("Je hebt niet genoeg geld!");

                        return;
                    }

                    money = money - betAmount;
                    walletLabel.Text = money.ToString();

                    Bet newBet = new Bet(match, betAmount, team);

                    MessageBox.Show(newBet.ToString());
                }
                catch (FormatException)
                {
                    MessageBox.Show("Voer een geldig geld bedrag in!");
                }
            }
        }

        private void machtesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Match match = (Match)machtesComboBox.SelectedItem;
            team1RadioButton.Text = match.Team1;
            team2RadioButton.Text = match.Team2;
        }

        private void nameBettorLabel_Click(object sender, EventArgs e)
        {

        }

        private void cheatTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(cheatTextBox.Text == "Ch3atS")
                {
                    MessageBox.Show("Cheats Enabled");
                    cheatButton.Enabled = true;
                    cheatButton1.Enabled = true;
                    cheatButton2.Enabled = true;
                    cheatLabel.Text = ("Cheats Enabled");
                }
                else
                {
                    MessageBox.Show("Incorrect password");
                }
            }
        }

        private void cheatButton_Click(object sender, EventArgs e)
        {
            money += 10;
            walletLabel.Text = money.ToString();
        }

        private void cheatButton1_Click(object sender, EventArgs e)
        {
            money += 100;
            walletLabel.Text = money.ToString();
        }

        private void cheatButton2_Click(object sender, EventArgs e)
        {
            money += 1000;
            walletLabel.Text = money.ToString();
        }
    }
}
