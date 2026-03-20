#region Exercise3



string[] words = new string[] { "word1", "word2", "word3", "word4", "word5" };

double[] decimalValues = [1.1, 1.2, 1.3, 1.4, 1.5];

char[] characters = new char[5];

Console.WriteLine("Enter 5 characters: ");
for (int i = 0; i < characters.Length; i++)
{
    characters[i] = char.Parse(Console.ReadLine());
    break;
}

//Console.WriteLine("You entered:");
//for (int i = 0; i < characters.Length; i++)
//{
//    Console.WriteLine(characters[i]);
//}

//foreach (char item in characters)
//{
//    Console.WriteLine(item);
//}

bool[] boolValues = [true, false, false, true];

int[][] arrayOfArrays = new int[][]
{
    new int[] { 1, 2 },
    new int[] { 3, 4 },
    new int[] { 5, 6 },
    new int[] { 7, 8 },
    new int[] { 9, 10 }
};

int[][] numberss = new int[5][];
numberss[0] = new int[] { 1, 2 };
numberss[1] = new int[] { 3, 4 };
numberss[2] = new int[] { 5, 6 };
numberss[3] = new int[] { 7, 8 };
numberss[4] = new int[] { 9, 10 };


int[][] numbers2 =
[
    new int[] { 1, 2 },
    new int[] { 3, 4 },
    new int[] { 5, 6 },
    new int[] { 7, 8 },
    new int[] { 9, 10 },
];


#endregion


#region Exercise5

int[] numbers = new int[5];
int sum = 0;


for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
    sum = sum + numbers[i];
}

Console.WriteLine("The sum is " + sum);

#endregion




#region Exercise5

string[] names = new string[0];

do
{
    Console.WriteLine("Please enter a name:");
    string userInput = Console.ReadLine();

    Array.Resize(ref names, names.Length + 1);
    names[names.Length - 1] = userInput;

    Console.WriteLine("Do you want to insert another name? y/n");
    userInput = Console.ReadLine();

    if (userInput == "n" || userInput == "N")
    {
        break;
    }

} while (true);

Console.WriteLine("All entered names:");
foreach (string name in names)
{
    Console.WriteLine(name);
}

#endregion