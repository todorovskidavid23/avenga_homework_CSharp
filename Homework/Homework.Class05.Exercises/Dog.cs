using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Class05.Exercises
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }


        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;
        }

        public void Eat()
        {
            Console.WriteLine($"The name of the dog is {Name}, {Race} race and color {Color}");
        }

        public void Play()
        {
            Console.WriteLine($"The name of the dog is {Name}, {Race} race and color {Color} is now playing");
        }

        public void ChaseTail()
        {
            Console.WriteLine($"The name of the dog is {Name}, {Race} race and color {Color} is now chasing its tail");
        }


    }
}
