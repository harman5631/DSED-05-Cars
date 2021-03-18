using DSED_05_Cars.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED_05_Cars
{
    class Gameplay
    {
        Car[] car = new Car[4]; // All Car Racers inside array
        Punter[] myPunter = new Punter[3]; // All Punters inside array


        // method to load the cars into the picture box
        public Car[] LoadCars(PictureBox pictureBox1, PictureBox pictureBox2, PictureBox pictureBox3, PictureBox pictureBox4)
        {
            car[0] = new Car { Length = 0, myPB = pictureBox1, Name = "McQueen" }; // identifies which array/picture box to put the car image into
            car[0].myPB.BackgroundImage = Resource1.McQueen; // puts the image in the resource file into the Picture Box
            car[1] = new Car { Length = 0, myPB = pictureBox2, Name = "Guido" };
            car[1].myPB.BackgroundImage = Resource1.Guido;
            car[2] = new Car { Length = 0, myPB = pictureBox3, Name = "Mater" };
            car[2].myPB.BackgroundImage = Resource1.Mater;
            car[3] = new Car { Length = 0, myPB = pictureBox4, Name = "Luigi" };
            car[3].myPB.BackgroundImage = Resource1.Luigi;

            return car;
        }
        public Punter[] LoadPunters(Label lblWinner)
        {
            for (int i = 0; i < 3; i++)
            {
                //static dont need to instantiate
                myPunter[i] = Factory.GetAPunter(i);
                myPunter[i].LabelWinner = lblWinner;     
            }

            return myPunter;
        }

       
        public void UDPunter1Value1()
        {
            myPunter[0].Car = car[0].Name;
        }

        public void UDPunter1Value2()
        {
            myPunter[0].Car = car[1].Name;
        }
        public void UDPunter1Value3()
        {
            myPunter[0].Car = car[2].Name;
        }
        public void UDPunter1Value4()
        {
            myPunter[0].Car = car[3].Name;
        }


    }
}
