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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string teamJson;

            teamJson = downloader.DownloadString("http://localhost/fifa-Php/PHP/jsonecho.php");

            List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(teamJson);

            foreach(Team team in teams)
            {
                listBox1.Items.Add(team.teamname);
            }
        }
    }
}
