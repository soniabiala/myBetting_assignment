using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRacing_Assignment
{
    class Bettor
    {
        public string punterName;//nmae of the punter;
        public Bet myBet;
        public int cash;//how much cash punter got 

        public RadioButton myRadioButton;
        public Label myLabel;
        public NumericUpDown newAmount;

        public Bettor(string Name, int Cash, RadioButton radioButton, Label Label)
        {
            punterName = Name;
            cash = Cash;
            myRadioButton = radioButton;
            myLabel = Label;
        }
        public void updateLabel()
        {
            if (myBet != null)
            {
                myLabel.Text = myBet.betDesc();

            }
            else
            {
                myLabel.Text = "no bet placesd !!!";
            }
            myRadioButton.Text = punterName + " " + "have" + " " + "$" + cash;
        }


        public bool placeBet(int betAmount, int RacerNum)
        {


            if (betAmount <= cash)
            {
                myBet = new Bet(betAmount, RacerNum, this);
                return true;
            }
            return false;
        }

        public void clerBet()
        {
            myBet.amount = 0;
        }

        public void Collect(int Winner)
        {

            cash += myBet.Payout(Winner);


        }
        public int UpdateBetAmount()
        {
            int newCash = cash;
            return newCash;
        }
    }
}
