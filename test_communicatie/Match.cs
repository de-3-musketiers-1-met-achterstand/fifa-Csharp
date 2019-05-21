using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_communicatie
{
    public class Match
    {
        public string Team1 { get; set; }
        public string Team2 { get; set; }

        public Match(string team1, string team2)
        {
            this.Team1 = team1;
            this.Team2 = team2;
        }

        public override string ToString()
        {
            return this.Team1 + " - " + this.Team2;
        }
    }
}
