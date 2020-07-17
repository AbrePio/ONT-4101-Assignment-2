using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class Receiver
    {
        public double TM1, TM2, TM3, TM4;
        public double avg;
        public void Action(double tm1, double tm2, double tm3, double tm4)
        {
            TM1 = tm1 * 0.30;
            TM2 = tm2 * 0.30;
            TM3 = tm3 * 0.30;
            TM4 = tm4 * 0.10;
            avg = TM1 + TM2 + TM3 + TM4;
            Console.WriteLine("Hello " + avg);
        }



        //command pattern
        public void receiver()
        {
            avg =+ avg;
            Console.WriteLine(avg);
        }
        //end command
        
    }
}
