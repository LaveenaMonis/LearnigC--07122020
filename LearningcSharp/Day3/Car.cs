using System;
using System.Collections.Generic;
using System.Text;

namespace LearningcSharp.Day3
{
    class Car :Vehicle
    {
        public Car()
        {
            Console.WriteLine("Implicit constructor in car");
        }
        public int HorsePower { get; set; }
        public void Accelerate()
        {
            Console.WriteLine("Acc from class");
        }
        public override void Run()
        {
            Console.WriteLine("Run in child");
        }
    }
}
