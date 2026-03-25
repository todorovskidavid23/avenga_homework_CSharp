#region Exercise 3

static void Substrings()
{
    string msg = "Hello from Avenga Codecademy 2024";

    Console.WriteLine("Enter number of characters:");

    bool isParsed = int.TryParse(Console.ReadLine(), out int numberOfCharacters);

    if (!isParsed)
    {
        Console.WriteLine("Invalid input. Please enter a whole number!");
        return;
    }

    if (numberOfCharacters <= 0)
    {
        Console.WriteLine("You must enter a number greater than 0!");
        return;
    }

    if (numberOfCharacters > msg.Length)
    {
        Console.WriteLine("You cannot enter more characters than the message contains!");
        return;
    }

    string text = msg.Substring(0, numberOfCharacters);

    Console.WriteLine($@"New string: ""{text}""");
    Console.WriteLine($"Length: {text.Length}");
}

Substrings();

#endregion


#region Exercise 4

DateTime today = DateTime.Now;
Console.WriteLine(today.AddDays(3));
Console.WriteLine(today.AddMonths(1));
Console.WriteLine(today.AddMonths(1).AddDays(3));
Console.WriteLine(today.AddYears(-1).AddMonths(-2));
Console.WriteLine(today.ToString("MMMM"));
Console.WriteLine(today.ToString("yyyy"));

#endregion


#region Homework Class 04

static int AgeCalculator(DateTime birthday)
{
    DateTime today = DateTime.Now;
    int age = today.Year - birthday.Year;

    //Дали датумот на раѓање е после датумот што го добиваме кога ќе се вратиме назад од денес за толку години?
    //if (birthday > today.AddYears(-age))
    //{
    //    age--;
    //}
    DateTime birthdayThisYear = new DateTime(today.Year, birthday.Month, birthday.Day);

    if (birthdayThisYear > today)
    {
        age--;
    }

    return age;
}

Console.WriteLine("Enter your birthday (dd.MM.yyyy):");

bool isParsed = DateTime.TryParse(Console.ReadLine(), out DateTime userBirthday);

if (!isParsed)
{
    Console.WriteLine("Invalid date input!");
    return;
}

int userAge = AgeCalculator(userBirthday);

Console.WriteLine("Your age is: " + userAge);


#endregion