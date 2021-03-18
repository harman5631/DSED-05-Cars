using DSED_05_Cars.Business;
using System;
using System.Threading;
using System.Windows.Forms;

namespace DSED_05_Cars
{
    public partial class GameForm : Form
    {
        Car[] car = new Car[4]; // All Car Racers inside array
        Punter[] myPunter = new Punter[3]; // All Punters inside array

        //stores the winner of the race here
        private string Winner;

        public GameForm()
        {
            InitializeComponent();
            //Car[] car = myGameplay.LoadCars(pictureBox1, pictureBox2, pictureBox3, pictureBox4); Note: Using this for when I finish my Gameplay Class
            //Punter[] myPunter = myGameplay.LoadPunters(lblWinner); Note: Using this for when I finish my Gameplay Class
            LoadCars();
            LoadPunters();
            LoadMoney();
        }

        public void LoadCars() 
        {
            car[0] = new Car { Length = 0, myPB = pictureBox1, Name = "McQueen" }; // identifies which array/picture box to put the car image into
            car[0].myPB.BackgroundImage = Resource1.McQueen; // puts the image in the resource file into the Picture Box
            car[1] = new Car { Length = 0, myPB = pictureBox2, Name = "Guido" };
            car[1].myPB.BackgroundImage = Resource1.Guido;
            car[2] = new Car { Length = 0, myPB = pictureBox3, Name = "Mater" };
            car[2].myPB.BackgroundImage = Resource1.Mater;
            car[3] = new Car { Length = 0, myPB = pictureBox4, Name = "Luigi" };
            car[3].myPB.BackgroundImage = Resource1.Luigi;      
        }

        public void LoadPunters() // loads the punters thru the factory while factory gets the data from individual business classes
        {
            for (int i = 0; i < 3; i++)
            {
                //static dont need to instantiate
                myPunter[i] = Factory.GetAPunter(i);
                myPunter[i].LabelWinner = lblWinner;
            }
        }


        public void StartRace()
        {
            var myRandom = new Random();

            bool end = false;

            while (end != true)
            {
                int distance = GameForm.ActiveForm.Width - pictureBox1.Width - 30;

                for (int i = 0; i < car.Length; i++)
                {
                    Thread.Sleep(2);
                    car[i].myPB.Left += myRandom.Next(1, 7); // the code that makes the car move (random distance)



                    if (car[i].myPB.Left > distance)
                    {
                        end = true;
                        Winner = car[i].Name;
                        this.Text = Winner;

                        //find the winner 
                        FindWinner(Winner);
                    }
                }
            }
        }


        private void FindWinner(string CarWinner)
        {

            for (int i = 0; i < 3; i++)
            {
                if (myPunter[i].Car == CarWinner)
                {
                    myPunter[i].Money += myPunter[i].Bet;
                    myPunter[i].LabelWinner.Text += CarWinner + " and " + myPunter[i].PunterName + " Has Won ... Congratulations!";

                }

                else
                {
                    myPunter[i].Money -= myPunter[i].Bet;
                    myPunter[i].LabelWinner.Text += "  -  " + myPunter[i].PunterName + " Has Lost better luck next time :( ";
                }
                myPunter[i].Bet = 0; // resets the punters bet so that it doesnt repeat when they are out of money
            }
            LoadMoney();

            if (myPunter[0].Money == 0) // disables the radiobutton when the punter runs out of money
            {
                rbFera.Enabled = false;
                txtFera.Text = "Fera is out of Money";
            }
            if (myPunter[1].Money == 0)
            {
                rbLambo.Enabled = false;
                txtLambo.Text = "Lambo is out of Money";
            }
            if (myPunter[2].Money == 0)
            {
                rbTes.Enabled = false;
                txtTes.Text = "Tes is out of Money";
            }

            // sees if all the requirements gameover requirements are met
            if (myPunter[0].Money == 0 && myPunter[1].Money == 0 || myPunter[0].Money == 0 && myPunter[2].Money == 0 || myPunter[1].Money == 0 && myPunter[2].Money == 0)
            {
                rbFera.Enabled = false;
                rbLambo.Enabled = false;
                rbTes.Enabled = false;
                pnlGameOver.Visible = true;
            }
        }

        private void LoadMoney() // i did it like this even though i could put it in the findwinner method because i wanted it to show in the textbox straight away right when the game is started 
        {   // shows the amount of money the punter has in the textbox
            txtFera.Text = myPunter[0].PunterName + " Has $" + myPunter[0].Money; 
            txtLambo.Text = myPunter[1].PunterName + " Has $" + myPunter[1].Money;
            txtTes.Text = myPunter[2].PunterName + " Has $" + myPunter[2].Money;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtFera.Visible = true;
            txtLambo.Visible = true;
            txtTes.Visible = true;

            StartRace();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            if (rbFera.Checked == true)
            {
                myPunter[0].Bet = (float)numUDbet.Value;

                    if (numUDCarNumber.Value == 1) // if a number is picked it returns a car to the punter
                    {
                    myPunter[0].Car = car[0].Name;
                    //myGameplay.UDPunter1Value1(); Note: Using this when I finish my Gameplay Class for my methods
                    }
                    if (numUDCarNumber.Value == 2)
                    {
                    myPunter[0].Car = car[1].Name;
                    //myGameplay.UDPunter1Value2();
                    }
                    if (numUDCarNumber.Value == 3)
                    {
                    myPunter[0].Car = car[2].Name;
                    //myGameplay.UDPunter1Value3();
                    }
                    if (numUDCarNumber.Value == 4)
                    {
                    myPunter[0].Car = car[3].Name;
                    //myGameplay.UDPunter1Value4();
                    }             
            }


            if (rbLambo.Checked == true)
            {
                myPunter[1].Bet = (float)numUDbet.Value;

                    if (numUDCarNumber.Value == 1)
                    {
                        myPunter[1].Car = car[0].Name;
                    }
                    if (numUDCarNumber.Value == 2)
                    {
                        myPunter[1].Car = car[1].Name;
                    }
                    if (numUDCarNumber.Value == 3)
                    {
                        myPunter[1].Car = car[2].Name;
                    }
                    if (numUDCarNumber.Value == 4)
                    {
                        myPunter[1].Car = car[3].Name;
                    }
            }


            if (rbTes.Checked == true)
            {
                myPunter[2].Bet = (float)numUDbet.Value;

                    if (numUDCarNumber.Value == 1)
                    {
                        myPunter[2].Car = car[0].Name;
                    }
                    if (numUDCarNumber.Value == 2)
                    {
                        myPunter[2].Car = car[1].Name;
                    }
                    if (numUDCarNumber.Value == 3)
                    {
                        myPunter[2].Car = car[2].Name;
                    }
                    if (numUDCarNumber.Value == 4)
                    {
                        myPunter[2].Car = car[3].Name;
                    }
                
            }

            UpdateDetails();

        }

       private void UpdateDetails()
        {

            txtFera.Text = myPunter[0].PunterName + " has betted $" + myPunter[0].Bet + " on " + myPunter[0].Car; // shows how much the punter has bet on the text box and which car he chose
            txtLambo.Text = myPunter[1].PunterName + " has betted $" + myPunter[1].Bet + " on " + myPunter[1].Car;
            txtTes.Text = myPunter[2].PunterName + " has betted $" + myPunter[2].Bet + " on " + myPunter[2].Car;

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                car[i].myPB.Left = 12; // puts the pb back in the y position where it started
                lblWinner.Text = ""; // resets the label winner label

            }
        }


        private void rbFera_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rbF = (RadioButton)sender;

            if (rbF.Checked == true) //if the radiobutton is checked then it gets a punter through the factory to return data
            {
                Factory.GetAPunter(0);
                txtFera.Visible = true;
                txtFera.Text = myPunter[0].PunterName + " Has $" + myPunter[0].Money;
                txtLambo.Visible = false;
                txtTes.Visible = false;
            }
            numUDbet.Maximum = (decimal)myPunter[0].Money;//sets maximum equal to the punters money 
            myPunter[0].Bet = (float)numUDbet.Value;

        }

        private void rbLambo_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rbL = (RadioButton)sender;

            if (rbL.Checked == true) //if the radiobutton is checked then it gets a punter through the factory to return data
            {
                Factory.GetAPunter(1);
                txtFera.Visible = false;
                txtLambo.Visible = true;
                txtLambo.Text = myPunter[1].PunterName + " Has $" + myPunter[1].Money;
                txtTes.Visible = false;
            }
            numUDbet.Maximum = (decimal)myPunter[1].Money;//sets maximum equal to the punters money 
            //numUDbet.Value = (decimal)myPunter[1].Money;
            myPunter[1].Bet = (float)numUDbet.Value;

        }

        private void rbTes_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rbT = (RadioButton)sender;

            if (rbT.Checked == true)//if the radiobutton is checked then it gets a punter through the factory to return data
            {
                Factory.GetAPunter(2);
                txtFera.Visible = false;
                txtLambo.Visible = false;
                txtTes.Visible = true;
                txtTes.Text = myPunter[2].PunterName + " Has $" + myPunter[2].Money;
            }
            numUDbet.Maximum = (decimal)myPunter[2].Money;//sets maximum equal to the punters money 
            myPunter[2].Bet = (float)numUDbet.Value;

        }



        private void numUDbet_ValueChanged(object sender, EventArgs e)
        {


        }



        private void numUDCarNumber_ValueChanged(object sender, EventArgs e)
        {

            numUDCarNumber.Maximum = 4;

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
