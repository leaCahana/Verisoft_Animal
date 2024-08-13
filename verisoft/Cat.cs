using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verisoft
{
    public class Cat : Animal, ILand
    {
        private int numOfLeghth = 4;

        public Cat(int mood) : base(true, true, mood)
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
                for (int i = 0; i < times; i++)
                {
                    Console.Write("meow!");
                }
                Console.WriteLine();

            }

        }

        public override void WhatMood()
        {
            if (mood == (int)Lmood.MOOD_HAPPY)
            {
                Console.WriteLine("purr, purr!");
            }
            else
            {
                Console.WriteLine("hiss");

            }
        }


        public int GetNumberLegs()
        {
            return numOfLeghth;
        }


        public override string ToString()
        {
            return $"{base.ToString()}, " +
                   $"number of legs: {numOfLeghth}";
        }


    }
}
