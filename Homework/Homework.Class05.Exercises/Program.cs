
#region Exercise1

using Homework.Class05.Exercises;

Console.WriteLine("Enter FirstName:");
string firstName = Console.ReadLine();

Console.WriteLine("Enter LastName");
string lastName = Console.ReadLine();

Console.WriteLine("Enter Age:");
int age = int.Parse(Console.ReadLine());

Human human = new Human
{
    FirstName = firstName,
    LastName = lastName,
    Age = age
};

Console.WriteLine(human.GetPersonStats());

#endregion


#region Exercise2

Console.WriteLine("Enter a dog name:");
string name = Console.ReadLine();

Console.WriteLine("Enter the dog's race");
string race = Console.ReadLine();

Console.WriteLine("Enter the dog's color");
string color = Console.ReadLine();

//Dog dog = new Dog
//{
//    Name = name,
//    Race = race,
//    Color = color,
//};
Dog dog = new Dog(name, race, color);

Console.WriteLine("Choose an action:");
Console.WriteLine("1 - Eat");
Console.WriteLine("2 - Play");
Console.WriteLine("3 - Chase Tail");

int action = int.Parse(Console.ReadLine());

switch (action)
{
    case 1:
        dog.Eat();
        break;
    case 2:
        dog.Play();
        break;
    case 3:
        dog.ChaseTail();
        break;
    default:
        Console.WriteLine("Invalid Input! Please enter 1, 2 or 3");
        break;

}


#endregion



#region Exercise3

Console.WriteLine("Enter name:");
string studentName = Console.ReadLine();

Student[] students = new Student[]
{
    new Student("David", "Avenga", "G1"),
    new Student("Bob", "Seavus", "G2"),
    new Student("Jill", "Brainster", "G3"),
    new Student("Greg", "Semos", "G4"),
    new Student("Jhon", "Seavus", "G5")
};

foreach (Student student in students)
{
    if (student.Name.ToLower() == studentName.ToLower())
    {
        Console.WriteLine("The student is found!");
        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Academy: {student.Academy}");
        Console.WriteLine($"Group: {student.Group}");
        return;
    }

}
Console.WriteLine("Student not Found");


#endregion