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
        string team;

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

            teamJson = downloader.DownloadString("https://3513658495623.000webhostapp.com/jsonecho.php?key=71abae66b0d3a4eb39aee4281228eec4");

            List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(teamJson);

            foreach(Team team in teams)
            {
                showTeamsListBox.Items.Add(team.teamname);
            }

            string matchJson;

            matchJson = downloader.DownloadString("https://3513658495623.000webhostapp.com/matchesjsonecho.php?key=71abae66b0d3a4eb39aee4281228eec4");
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
                    team = team1RadioButton.Text;
                    Match match = (Match)machtesComboBox.SelectedItem;
                    int betAmount = int.Parse(betAmountTextBox.Text);
                    int myResultTeam1 = (int)team1NumericUpDown.Value;
                    int myResultTeam2 = (int)team2NumericUpDown.Value;


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

                    Bet newBet = new Bet(match, betAmount, team, myResultTeam1, myResultTeam2);

                    showBetListBox.Items.Add(newBet);
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
                    team = team2RadioButton.Text;
                    Match match = (Match)machtesComboBox.SelectedItem;
                    int betAmount = int.Parse(betAmountTextBox.Text);
                    int myResultTeam1 = (int)team1NumericUpDown.Value;
                    int myResultTeam2 = (int)team2NumericUpDown.Value;

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

                    Bet newBet = new Bet(match, betAmount, team, myResultTeam1, myResultTeam2);

                    showBetListBox.Items.Add(newBet);
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
                    MessageBox.Show("Cheats ingeschakeld");
                    cheatButton.Enabled = true;
                    cheatButton1.Enabled = true;
                    cheatButton2.Enabled = true;
                    cheatLabel.Text = ("Cheats ingeschakeld");
                }
                else
                {
                    MessageBox.Show("Incorrect cheatcode");
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

        private void checkResultButton_Click(object sender, EventArgs e)
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string resultJson;
            resultJson = downloader.DownloadString("https://3513658495623.000webhostapp.com/matchesjsonecho.php?key=71abae66b0d3a4eb39aee4281228eec4");
            List<Match> result = JsonConvert.DeserializeObject<List<Match>>(resultJson);

            if (showBetListBox.SelectedIndex == -1)
            {
                return;
            }

            Bet bet = (Bet)showBetListBox.SelectedItem;

            for (int i = 0; i < result.Count; i++)
            {
                if (bet.Match.Team1 == result[i].Team1 && bet.Match.Team2 == result[i].Team2)
                {
                    if (bet.Match.result1 > bet.Match.result2)
                    {
                        if (bet.MyTeam == result[i].Team1)
                        {
                            if (bet.Match.result1 == bet.myResultTeam1 && bet.Match.result2 == bet.myResultTeam2)
                            {
                                money = money + bet.Amount * 3;
                                walletLabel.Text = money.ToString();
                                MessageBox.Show("Je hebt de precieze uitslag goed, je krijgt het drie dubbele van je ingezetten bedrag!");
                                showBetListBox.Items.Remove(showBetListBox.SelectedItem);
                                return;
                            }

                            money = money + bet.Amount * 2;
                            walletLabel.Text = money.ToString();
                            MessageBox.Show("Je hebt gewonnen, Je krijgt het dubbele van je ingezetten bedrag");
                            showBetListBox.Items.Remove(showBetListBox.SelectedItem);
                            return;

                        }
                    }
                                        
                    if (bet.Match.result2 > bet.Match.result1)
                    {
                        if (bet.MyTeam == result[i].Team2)
                        {
                            if (bet.Match.result1 == bet.myResultTeam1 && bet.Match.result2 == bet.myResultTeam2)
                            {
                                money = money + bet.Amount * 3;
                                walletLabel.Text = money.ToString();
                                MessageBox.Show("Je hebt de precieze uitslag goed, je krijgt het drie dubbele van je ingezetten bedrag!");
                                showBetListBox.Items.Remove(showBetListBox.SelectedItem);
                                return;
                            }

                            money = money + bet.Amount * 2;
                            walletLabel.Text = money.ToString();
                            MessageBox.Show("Je hebt gewonnen, Je krijgt het dubbele van je ingezetten bedrag");
                            showBetListBox.Items.Remove(showBetListBox.SelectedItem);
                            return;
                        }
                    }
                    
                    
                        MessageBox.Show("Je hebt verloren, Je bent je ingezetten bedrag kwijt");
                        showBetListBox.Items.Remove(showBetListBox.SelectedItem);
                        return;
                    
                }
            }
        }
    }
}
