using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Alarm
{
    class Alarm
    {
        public string time { get; set;}

        public void music()
        {
            while (true)
            {
                Console.Write("Breeen_Breeeen");
                Thread.Sleep(1000);
            }
        }
    }
}
