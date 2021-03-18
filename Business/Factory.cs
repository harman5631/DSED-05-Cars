using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSED_05_Cars.Business
{
    class Factory
    {
        //Decides which punter to instantiate 1,2,3

        public static Punter GetAPunter(int id)
        {
            switch (id)
            {
                case 0:
                    return new Ferarri();
                case 1:
                    return new Lamborghini();
                case 2:
                    return new Tesla();

                default: return null;


            }


        }



    }
}
