using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter student number: ");
            string studentNo = Console.ReadLine();

            
            // Adapter 
            MySQL adaptee1 = new MySQL();
            SQLite adaptee2 = new SQLite();
            Firebase adaptee3 = new Firebase();
            MSSQL adaptee4 = new MSSQL();
            Adapter adapter = new Adapter(adaptee1, adaptee2, adaptee3, adaptee4);

            adapter.TM1();
            adapter.TM2();
            adapter.TM3();
            adapter.TM4();
            // End Adapter

            
            Console.ReadLine();
        }
    }
}
