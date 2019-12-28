using System;
using System.Collections.Generic;
using System.Text;

namespace Lession_8_CW
{
    class Cash
    {
        private double dollars = 100;
        private double rubles = 6500;

        //Инкапсуляция доллары
        public double Dollars
        {
            get { return dollars; }
            set 
            { 
                dollars += value;
                rubles = dollars * 65;
            }
        }

        //Инкапсуляция рубли
        public double Rubles
        {
            get { return rubles; }
            set
            {
                rubles += value;
                dollars = rubles / 65;
            }
        }
    }
}
