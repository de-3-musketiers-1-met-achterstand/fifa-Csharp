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

            MessageBox.Show("Hello " + bettor);

            System.Net.WebClient downloader = new System.Net.WebClient();
            string teamJson;

            teamJson = downloader.DownloadString("http://localhost/fifa-Php/PHP/jsonecho.php");

            List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(teamJson);

            foreach(Team team in teams)
            {
                showTeamsListBox.Items.Add(team.teamname);
            }

            string matchJson;

            matchJson = downloader.DownloadString("http://localhost/fifa-Php/PHP/matchesjsonecho.php?");
            List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(matchJson);
            
            for (int i = 0; i < matches.Count ; i++)
            {
                machtesComboBox.Items.Add(matches[i]);
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                MessageBox.Show("Hello ");

                money += 20;

                walletLabel.Text = money.ToString();
            }
        }
    }
}
