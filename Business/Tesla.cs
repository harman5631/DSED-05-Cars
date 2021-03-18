using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSED_05_Cars.Business
{
    class Tesla : Punter
    {
        public Tesla()
        {
            PunterName = "Tes";
            Car = "";
            Money = 50;
            MyColor = Color.DarkGreen;
        }
    }
}
