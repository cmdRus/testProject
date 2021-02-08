using ConsoleService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace ConsoleService
{
    class Program
    {
        static void Main(string[] args)
        {


            //string d = ApiClient.GetRequest<string>("Home");

            MyTimer timer = new MyTimer(10000);
            timer.StartTimer();
            timer.StopTimer();
        }
    }
}
