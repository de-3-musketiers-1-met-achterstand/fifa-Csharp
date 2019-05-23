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

        public Bet(Match match, int amount, string myteam)
        {
            this.Match = match;
            this.Amount = amount;
            this.MyTeam = myteam;
        }

        public override string ToString()
        {
            return "Je hebt gewed: " + this.Amount + " op " + this.MyTeam;
        }
    }
}
