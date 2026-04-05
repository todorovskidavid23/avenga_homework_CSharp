using Homework.Class08.Exercise2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Class08.Exercise2.Models
{
    public class Song
    {
        public string Title { get; set; }
        public double Length { get; set; }
        public Genre Genre { get; set; }

        public Song(string title, double length, Genre genre)
        {
            Title = title;
            Length = length;
            Genre = genre;
        }
    }
}
