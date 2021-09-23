using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventCounter
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Counter c = new Counter();

            c.CountEvent += c_CountEvent;
            c.IncreaseCount();

            Console.ReadLine();
        }

        public static void c_CountEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event Received!");
            Console.WriteLine();
        }
    }
}
