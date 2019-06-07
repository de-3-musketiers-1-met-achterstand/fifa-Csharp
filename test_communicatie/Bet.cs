using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_communicatie
{
    class Bet
    {
        public int Amount { get; set; }
        public Match Match { get; set; }
        public string MyTeam { get; set; }
        public int myResultTeam1 { get; set; }
        public int myResultTeam2 { get; set; }

        public Bet(Match match, int amount, string myteam, int myresultteam1, int myresultteam2)
        {
            this.Match = match;
            this.Amount = amount;
            this.MyTeam = myteam;
            this.myResultTeam1 = myresultteam1;
            this.myResultTeam2 = myresultteam2;
        }

        public override string ToString()
        {
            return "Je hebt gewed: € " + this.Amount + " op " + this.MyTeam + ", Uitslag: " + this.myResultTeam1 + " - " + this.myResultTeam2;
        }
    }
}
