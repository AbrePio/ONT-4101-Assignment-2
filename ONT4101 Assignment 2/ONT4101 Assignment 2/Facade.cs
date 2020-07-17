using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    class Facade
    {
        int FinalMark;
        private Receiver _receiver;

        public Facade()
        {
            _receiver = new Receiver();
        }

        public void Result()
        {
            _receiver.receiver();
        }
    }
}
