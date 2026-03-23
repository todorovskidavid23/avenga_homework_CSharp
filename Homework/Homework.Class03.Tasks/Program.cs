#region Task1

int[] integers = new int[6];
int sum = 0;
for(int i = 0; i < integers.Length; i++)
{
    Console.WriteLine($"Enter integer no.{i+1}");
    int input = int.Parse(Console.ReadLine());

    if (input % 2 == 0)
    {
        sum = sum + input;
    }
}
Console.WriteLine("The result is: "+sum);


#endregion


#region Task2

string[] studentsG1 =
{
    "Zdravko1", "Petko1", "Stanko1", "Branko1", "Trajko1"
};
string[] studentsG2 =
{
    "Zdravko2", "Petko2", "Stanko2", "Branko2", "Trajko2"
};

Console.WriteLine("Enter student group: ( there are 1 and 2 )");
int groupInput = int.Parse(Console.ReadLine());

if (groupInput == 1)
{
    Console.WriteLine("The Students in G1 are:");
    foreach (var student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if (groupInput == 2)
{
    Console.WriteLine("The Students in G2 are:");
    foreach (var student in studentsG2)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Invalid Input! Please enter 1 or 2.");
}



#endregion