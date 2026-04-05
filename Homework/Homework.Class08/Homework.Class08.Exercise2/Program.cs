using Homework.Class08.Exercise2.Enums;
using Homework.Class08.Exercise2.Models;

Song s1 = new Song("Back in Black", 4.2, Genre.Rock);
Song s2 = new Song("Billie Jean", 4.54, Genre.Rock);
Song s3 = new Song("Bohemian Rhapsody", 5.9, Genre.Rock);
Song s4 = new Song("Lose Yourself", 4.4, Genre.Hip_Hop);
Song s5 = new Song("Short Rap", 2.4, Genre.Hip_Hop);
Song s6 = new Song("Sandstorm", 3.8, Genre.Techno);
Song s7 = new Song("Echoes", 23.0, Genre.Rock);
Song s8 = new Song("Stairway to Heaven", 8.0, Genre.Rock);
Song s9 = new Song("The Four Seasons", 42.0, Genre.Classical);
Song s10 = new Song("Calm Classic", 6.7, Genre.Classical);
Song s11 = new Song("Beat It", 4.18, Genre.Rock);
Song s12 = new Song("Beautiful Day", 5.5, Genre.Rock);
Song s13 = new Song("Brief Intro", 1.9, Genre.Techno);
Song s14 = new Song("Bouncy Beat", 2.7, Genre.Hip_Hop);

List<Song> allSongs = new List<Song>
{
    s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14
};

List<Person> persons = new List<Person>
{
    new Person("1", "David", "Todorovski", 23, Genre.Rock, new List<Song> { s1, s2, s3 }),
    new Person("2", "Mila", "Todorovska", 21, Genre.Classical, new List<Song>()),
    new Person("3", "Jerry", "Seinfeld", 30, Genre.Hip_Hop, new List<Song>()),
    new Person("4", "Maria", "Gonzalez", 28, Genre.Classical, new List<Song>()),
    new Person("5", "Jane", "Doe", 26, Genre.Rock, new List<Song> { s3, s8 }), 
    new Person("6", "Stefan", "Ivanov", 22, Genre.Hip_Hop, new List<Song>()), 
    new Person("7", "Bob", "Marley", 35, Genre.Techno, new List<Song> { s1, s3, s6, s11 }),
    new Person("8", "Alice", "Johnson", 29, Genre.Rock, new List<Song> { s1, s2, s3, s8, s11 }),
    new Person("9", "Tom", "Brown", 20, Genre.Techno, new List<Song> { s6, s13 }),
    new Person("10", "Lucy", "Smith", 31, Genre.Classical, new List<Song> { s9, s10, s12, s4 }),

};



Person jerryAllSongsStartWithB = persons.FirstOrDefault(x => x.FirstName == "Jerry");
if (jerryAllSongsStartWithB != null)
{
    jerryAllSongsStartWithB.FavoriteSongs = allSongs
        .Where(x => x.Title.StartsWith("B"))
        .ToList();
}

Person mariaAllSongsLengthLongerThan6 = persons.FirstOrDefault(x => x.FirstName == "Maria");
if (mariaAllSongsLengthLongerThan6 != null)
{
    mariaAllSongsLengthLongerThan6.FavoriteSongs = allSongs
        .Where(x => x.Length > 6)
        .ToList();
}

Person janeAllRockSongs = persons.FirstOrDefault(x => x.FirstName == "Jane");
if (janeAllRockSongs != null)
{
    janeAllRockSongs.FavoriteSongs = allSongs
        .Where(x => x.Genre == Genre.Rock)
        .ToList();
}

Person stefanAllHipHopShorterThan3 = persons.FirstOrDefault(x => x.FirstName == "Stefan");
if (stefanAllHipHopShorterThan3 != null)
{
    stefanAllHipHopShorterThan3.FavoriteSongs = allSongs
        .Where(x => x.Length < 3 && x.Genre == Genre.Hip_Hop)
        .ToList();
}

foreach (Person person in persons)
{
    Console.WriteLine("---------------");
    person.GetFavSongs();
    Console.WriteLine();
}

Console.WriteLine("Persons with 4 or more songs:");
var personsWith4OrMoreSongs = persons.Where(x => x.FavoriteSongs.Count >= 4);

foreach (Person person in personsWith4OrMoreSongs)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}");
}