//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace LearningcSharp.Day1
//{
//    public class HelloWorld
//    {
//        static void Main(string[] args)
//        {
//            //Console.WriteLine("Hello......");

//            //string name = "EITSI";
//            //string id = "GO6P";
//            //Console.WriteLine($"hello {name} with PUID {id}");
//            //var a = 10;
//            //var b = a;
//            //++b;
//            //b++;
//            //Console.WriteLine(a + " " + b);
//            Random random = new Random();

//            int[] arr = new int[5];
//            for (int i = 0; i < arr.Length -1 ; i++)
//            {
//                arr[i] = random.Next(2);
//            }
//            foreach (var item in arr)
//            {
//                Console.WriteLine(item);
//            }
//            int[] count = new int[2];
//            foreach (var item in arr)
//            {
//                count[item]++;
//            }
//            Console.WriteLine("Count of 0 : "+count[0]);
//            Console.WriteLine("Count of 1 : " + count[1]);

//        }
//    }
//}
