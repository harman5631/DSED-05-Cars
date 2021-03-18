using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED_05_Cars
{
    class Car
    {
        public string Name { get; set; }

        //How far the car has travelled
        public int Length { get; set; }

        public int UDnum { get; set; }

        public PictureBox myPB { get; set; }
    }
}
