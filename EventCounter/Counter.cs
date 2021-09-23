using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventCounter
{
    public delegate void CountEventHandler(object sender, EventArgs e);
    class Counter
    {
        public event CountEventHandler CountEvent;
        public int count = 0;
        
        public void IncreaseCount()
        {
            while (count < 21)
            {
                Console.WriteLine("Waiting...");
                Thread.Sleep(5000);
                count++;
                Console.WriteLine("Count: " + count);
                Console.WriteLine();

                if (count == 20)
                {
                    raiseCountEvent(EventArgs.Empty);
                    count = 0;
                }
            }
            
        }

        public virtual void raiseCountEvent(EventArgs e)
        {
            CountEventHandler cEvent = CountEvent;
            cEvent?.Invoke(this,e);
        }
    }
}
