using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verisoft
{
    public enum Lmood
    {
        MOOD_HAPPY = 0,
        MOOD_SCARED = 1
    }

    public abstract class Animal
    {
        protected bool mammals;
        protected bool carnivorous;
        protected int mood;
        public Animal(bool mammals, bool comivorous, int mood)//constructor
        {
            this.mammals = mammals;
            this.carnivorous = comivorous;
            this.mood = mood;
        }
        protected Lmood CurrentMood // נכס שמחזיר את מצב הרוח כ-enum
        {
            get { return (Lmood)mood;}            // המרה לעבודה עם ה-enum
            set { mood = (int)value;}
        }
        public abstract void WhatMood();// או להפך מה החיה עושה כשהיא במצב רוח טוב
        public virtual void SayHello() { }
        public abstract void SayHello(int times);
        public Boolean IsMammals()
        {
            return mammals;
        }
        public void SetMammals(bool b)
        {
            mammals = b;
        }
        public Boolean Iscarnivorous()
        {
            return carnivorous;
        }
        public void Setcarnivorous(bool b)
        {
            carnivorous = b;
        }
        public override string ToString()
        {
            return $"Animal Name:{GetType().Name}: mammals: {mammals}, carnivorous: {carnivorous},mood: {CurrentMood} ";
        }
    }
}


