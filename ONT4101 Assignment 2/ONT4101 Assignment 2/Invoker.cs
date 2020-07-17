using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class Invoker
    {
        public CommandBase command { get; set; }
        public void ExecuteCommand()
        {
            command.ExecuteCalculation();
        }


       
    }
}
