using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verisoft
{
    public class Frog : Animal, ILand, IWater
    {
        private int numOfLeghth = 4;

        public Frog(int mood)
    : base(false, false, mood)
        {
        }
        public override void SayHello(int times)
        {
            if (times <= 0)
            {
                SayHello(3);
            }
            else
            {
                for (int i = 0; i < times; i++)
                {
                    Console.Write("quack!");
                }
                Console.WriteLine();
            }
        }
        public override void WhatMood()
        {
            if (mood == (int)Lmood.MOOD_HAPPY)
            {
                Console.Write("is will sing:");
                SayHello(3);
                Console.Write("on the shore");
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("it will plop into the water");
            }

        }
        public int GetNumberLegs()
        {
            return numOfLeghth;
        }


        public bool hashGills()
        {
            return false;//ע"פ גוגל לראשנים יש זימים אך כשנהפכים לצפרדעים כבר אין
        }

        public bool hashLaysEggs()
        {
            return true;
        }


        public override string ToString()
        {
            return $"{base.ToString()}, " +
                   $"number of legs: {numOfLeghth}, " +
                   $"hashGills: {hashGills()}, " + $"hashLaysEggs: {hashLaysEggs()}";
        }

    }
}
