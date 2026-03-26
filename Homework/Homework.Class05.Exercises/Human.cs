using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Class05.Exercises
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public string GetPersonStats()
        {
            return $"{FirstName} {LastName} {Age}";
        }

    }
}
