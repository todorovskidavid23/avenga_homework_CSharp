using Homework.Class08.Exercise2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Class08.Exercise2.Models
{
    public class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }
        public Person(string id, string firstName, string lastName, int age, Genre favoriteMusicType, List<Song> favoriteSongs)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoriteMusicType;
            FavoriteSongs = favoriteSongs ?? new List<Song>();
        }

        public void GetFavSongs()
        {
            Console.WriteLine($"Person: {FirstName} {LastName}");

            if (FavoriteSongs.Count() == 0)
            {
                Console.WriteLine("This person hates music.");
                return;
            }

            Console.WriteLine("Favorite songs:");
            foreach (Song song in FavoriteSongs)
            {
                Console.WriteLine($"- {song.Title}");
            }
        }
    }
}
