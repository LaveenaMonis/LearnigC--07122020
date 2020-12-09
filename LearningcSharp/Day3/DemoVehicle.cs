using System;
using System.Collections.Generic;
using System.Text;

namespace LearningcSharp.Day3
{
    class DemoVehicle
    {
        static void Main(string[] args)
        {
            Vehicle bmw = new Car();
            bmw.Start();
            bmw.Run();
            bmw.Stop();
            bmw.EngineSize = 9000;
            Console.WriteLine("--------------------");
        }
    }
}
