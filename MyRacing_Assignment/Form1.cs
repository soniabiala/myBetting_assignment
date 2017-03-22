using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRacing_Assignment
{
    public partial class Form1 : Form
    {

        List<player> myPlayer = new List<player>();
        List<Bettor> myBettor = new List<Bettor>();
        Timer myTimer = new Timer();
        Random random = new Random();



        public Form1()
        {
            InitializeComponent();
            timerSetup();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadcbxPlayer();
            LoadRacer();
            LoadBettorInfo();
            UpdateText();
        }
        // 

        private void rbSonia_CheckedChanged(object sender, EventArgs e)
        {

            rbSonia.Text = myBettor[0].punterName + " " + "have" + " " + "$" + myBettor[0].cash.ToString();
            betAmount.Maximum = myBettor[0].cash;

        }
        private void rbPeter_CheckedChanged(object sender, EventArgs e)
        {

            rbPeter.Text = myBettor[1].punterName + " " + "have" + " " + "$" + myBettor[1].cash.ToString();
            betAmount.Maximum = myBettor[1].cash;
        }
        private void rbDavid_CheckedChanged(object sender, EventArgs e)
        {
            rbDavid.Text = myBettor[2].punterName + " " + "have" + " " + "$" + myBettor[2].cash.ToString();
            betAmount.Maximum = myBettor[2].cash;
        }

        private void LoadcbxPlayer()
        {
            cbxPlayer.Items.Add("Jerry");
            cbxPlayer.Items.Add("Koala");
            cbxPlayer.Items.Add("Micky");
            cbxPlayer.Items.Add("Monkey");
            cbxPlayer.SelectedIndex = 0;//choose one to strart with

        }
        private void LoadRacer()
        {
            int trackLength = pbxRaceTrack.Size.Width;
            int startPosition = 56;
            myPlayer.Add(new player("Jerry", imgJerry, startPosition, trackLength));
            myPlayer.Add(new player("Koala", imgKoala, startPosition, trackLength));
            myPlayer.Add(new player("Micky", imgMicky, startPosition, trackLength));
            myPlayer.Add(new player("Monkey", imgMonkey, startPosition, trackLength));

        }

        private void LoadBettorInfo()
        {
            int cash = 50;
            myBettor.Add(new Bettor("Sonia", cash, rbSonia, lblSonia));
            myBettor.Add(new Bettor("Peter", cash, rbPeter, lblPeter));
            myBettor.Add(new Bettor("David", cash, rbDavid, lblDavid));

        }
        private void UpdateText()
        {
            rbSonia.Text = myBettor[0].punterName + " " + "have" + " " + "$" + myBettor[0].cash.ToString();
            rbPeter.Text = myBettor[1].punterName + " " + "have" + " " + "$" + myBettor[1].cash.ToString();
            rbDavid.Text = myBettor[2].punterName + " " + "have" + " " + "$" + myBettor[2].cash.ToString();

            lblSonia.Text = "no bet placed !!";
            lblPeter.Text = "no bet placed !!";
            lblDavid.Text = "no bet placed !!";
        }

        public void timerSetup()
        {
            myTimer.Tick += myTimer_tick;
            myTimer.Interval = 50; // =Convert.ToInt32( TimeSpan.FromMilliseconds(10));

        }

        private void myTimer_tick(object sender, EventArgs e)
        {
            int WinningRacer;
            for (int i = 0; i < 4; i++)
            {

                myPlayer[i].Run(random.Next(1, 15));

                WinningRacer = i + 1;
                if (myPlayer[i].MyPictureBox.Location.X >= 920)
                {
                    //stop the timer
                    myTimer.Stop();

                    myPlayer[i].RaceWinner = true;
                    MessageBox.Show(myPlayer[i].name + " " + "Win the race");
                    foreach (player player in myPlayer)
                    {
                        player.TakeStartingPosition();
                    }

                    foreach (Bettor bettor in myBettor)
                    {
                        if (bettor.myBet != null)
                        {
                            bettor.Collect(WinningRacer);
                            bettor.myBet = null;
                            bettor.updateLabel();
                            bettor.myRadioButton.Text = bettor.punterName + " " + "have" + " " + "$" + bettor.cash.ToString();
                            betAmount.Maximum = bettor.UpdateBetAmount();

                        }
                    }
                }

            }

            OutOfMoney();
            GameOver();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            myTimer.Start();
            ////loop through the racers and find the one that won
            //for (int i = 0; i < myPlayer.Count; i++)
            //{

            //    //when you hit the one that has won
            //    if (myPlayer[i].RaceWinner == true)
            //    {  //extract out teh winner and do the clculations for bet

            //        //    get the race winners id
            //        int RaceWinnerNumber = i;

            //        //loop through the bets and find the one with the winning number

            //        for (int j = 0; j < 3; j++)
            //        {
            //            //this is the winning number
            //            if (myBettor[j].myBet.RacerNumber == RaceWinnerNumber)
            //            {
            //                //add winning to bet

            //            }
            //            else
            //            { //subtract winnings from bet

            //            }

            //        }
            //    }

            //}


        }


        private void btnBet_Click(object sender, EventArgs e)
        {
            int bettor = 0;
            if (rbSonia.Checked)
            {
                bettor = 0;
            }
            else if (rbPeter.Checked)
            {
                bettor = 1;
            }
            else if (rbDavid.Checked)
            {
                bettor = 2;
            }

            if (myBettor[bettor].cash < betAmount.Value)
            {
                MessageBox.Show("Don't have" + " " + "$" + betAmount.Value + " " + " to bet");
            }
            else
            {
                myBettor[bettor].placeBet((int)betAmount.Value, cbxPlayer.SelectedIndex);
                myBettor[bettor].updateLabel();
            }




        }

        private void OutOfMoney()
        {
            foreach (Bettor bettor in myBettor)
            {
                if (bettor.cash == 0)
                {
                    bettor.myRadioButton.Enabled = false;
                    bettor.myLabel.Text = "Busted !! No money left !!";

                }
            }
        }

        //reset everything for new game
        private void btnReset_Click(object sender, EventArgs e)
        {
            int cash = 50;
            myBettor[0].cash = cash;
            myBettor[1].cash = cash;
            myBettor[2].cash = cash;
            //stop the timer
            myTimer.Stop();
            LoadRacer();
            btnEnable();
            UpdateText();

        }
        private void GameOver()
        {
            if (rbSonia.Enabled == false && rbPeter.Enabled == false && rbDavid.Enabled == false)
            {
                btnBet.Enabled = false;
                btnStart.Enabled = false;
                MessageBox.Show("GAME OVER");

            }
        }
        private void btnEnable()
        {
            rbSonia.Enabled = true;
            rbPeter.Enabled = true;
            rbDavid.Enabled = true;
            btnBet.Enabled = true;
            btnStart.Enabled = true;
        }
    }
}
