using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class ConcreteCommand:CommandBase
    {
        public double param1 { get; set; }
        public double param2 { get; set; }
        public double param3 { get; set; }
        public double param4 { get; set; }
        protected Receiver _receiver;
        public ConcreteCommand(Receiver receiver)
        {
            _receiver = receiver;
        }
        public void ExecuteCalculation()
        {
            _receiver.Action(param1, param2, param3, param4);
        }
                
    }
}
