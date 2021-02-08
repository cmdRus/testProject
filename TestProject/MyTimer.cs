using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using ConsoleService.Models;

namespace ConsoleService
{
    
    class MyTimer
    {
        private static Timer timer;
        private static HardWare hardWare = new HardWare();
        public MyTimer(int time)
        {
            timer = new Timer(time);
            timer.Elapsed += OnTimedEvent;
            ApiClient.Connect();
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            hardWare.ReadData();
            Device d = new Device { Name = hardWare.GetName(), Size = hardWare.GetFreeSize(), ExecutionDate = DateTime.Now };
            ApiClient.PostRequest($"home", d);

            Console.WriteLine("Was sended to restApi : {0} {1} {2}", d.Name, d.Size, d.ExecutionDate);
        }

        public void StartTimer()
        {
            timer.Start();
        }

        public void StopTimer()
        {
            Console.ReadKey();
            timer.Stop();
        }
    }
}