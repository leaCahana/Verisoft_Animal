using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verisoft
{
    public class Dog : Animal, ILand
    {
        private int numOfLeghth = 4;
        public Dog(int mood)
    : base(true, true, mood)
        {
        }
        public override void SayHello()
        {
            SayHello(1);
        }

        public override void SayHello(int times)
        {
            if (times <= 0)
            {
                SayHello();
            }
            else
            {
                Console.Write($"the dog wagging your tail {times}:");
                for (int i = 0; i < times; i++)
                {
                    Console.Write("~ ");//כשכוש זנב
                }
                Console.WriteLine();

            }

        }

        public int GetNumberLegs()
        {
            return numOfLeghth;
        }
        public override void WhatMood()
        {
            if (mood == (int)Lmood.MOOD_HAPPY)
            {
                Console.WriteLine("HOW HOW");
            }
            else
                Console.WriteLine("whooping :(");

        }


        public override string ToString()
        {
            return $"{base.ToString()}, " +
                   $"number of legs: {numOfLeghth}";
        }

    }
}
