using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using VolleyBall_V2.Models;

namespace Encapsulation
{
    class SpeedTest
    {
        class TestSpeed
        {
            public double speed;
            public string name;
            public int age;
        }

        static void Test(ref TestSpeed speed, string name)
        {
            speed.name = name;
        }

        static void Test(TestSpeed speed, string name)
        {
            speed.name = name;
            //return speed;
        }

        static unsafe void Test(int* num)
        {
            *num = 10;
        }

        static void Test(ref int num)
        {
            num = 10;
        }

        static int Test(int num)
        {
            return 10;
        }

        static unsafe void Main(string[] args)
        {
            var list = new List<long>();
            Stopwatch watch = new Stopwatch();
            for (int k = 0; k < 100; k++)
            {
                watch.Reset();
                watch.Start();

                for (int i = 0; i < 1000000; i++)
                {
                    
                }
                watch.Stop();
                list.Add(watch.ElapsedTicks);
            }

            Console.WriteLine("RunTime " + list.Average());

        }
    }

}