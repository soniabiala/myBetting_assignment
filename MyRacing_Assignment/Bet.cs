using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRacing_Assignment
{
    class Bet
    {
        public int amount;//amount putting on bet
        public int RacerNumber;//player for bet
        public Bettor Bettor;//name of the punter who place the bet



        public Bet(int Bucks, int RacerNumber, Bettor myBettor)
        {
            amount = Bucks;
            this.RacerNumber = RacerNumber;
            Bettor = myBettor;

        }
        public string playerName()
        {
            string playerName = "";

            if (RacerNumber == 0)
            {
                playerName = "Jerry";
            }
            else if (RacerNumber == 1)
            {
                playerName = "Koala";
            }
            else if (RacerNumber == 2)
            {
                playerName = "Micky";
            }
            else if (RacerNumber == 3)
            {
                playerName = "Monkey";
            }
            return playerName;
        }

        public string betDesc()
        {
            string desc = "";

            if (amount > 0)
            {
                desc = " bet" + " " + "$" + " " + amount + " " + "on " + playerName();//+ "" + "(" + RacerNumber + ")";
            }
            else
            {
                desc = "hasn't placed bets!!";
            }
            return desc;

        }

        public int Payout(int Winner)
        {
            RacerNumber = RacerNumber + 1;
            if (RacerNumber == Winner)
            {
                return amount;
            }
            else
            {
                return -amount;
            }
        }
    }
}
