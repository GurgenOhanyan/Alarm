using System;
using System.Threading;
using System.Windows.Input;
namespace Alarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            Alarm alarm = new Alarm();
            alarm.time = "07:00";
            string time = Console.ReadLine();
            Thread alarmThread = new Thread(alarm.music);
            if (time == alarm.time)
            {
                alarmThread.Start();
                while(Console.ReadKey(true).Key != ConsoleKey.Escape)
                {

                }

                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    alarmThread.IsBackground = true;
                }
            }
            Console.ReadKey();
        }
    }
}
