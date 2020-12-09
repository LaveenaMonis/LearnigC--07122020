using System;
using System.Collections.Generic;
using System.Text;

namespace LearningcSharp.Day3
{
    class Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("Implicit value of vehicle");
        }
        public int EngineSize { get; set; }

        public virtual void Run()
        {
            Console.WriteLine("Run in Vehicle");
        }
        public  void Start()
        {
            Console.WriteLine("Start in Vehicle");
        }
        public  void Stop()
        {
            Console.WriteLine("Stop in Vehicle");
        }

    }
}
