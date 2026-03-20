#region Exercise4

int numberOfApples = 96;
int applesInOneBasekt = 5;

Console.WriteLine("Enter how many trees you have");
int trees=int.Parse(Console.ReadLine());

int totalApples = numberOfApples * trees;
int baskets = totalApples / applesInOneBasekt;

if(totalApples%applesInOneBasekt != 0)
{
    baskets++;
}

Console.WriteLine("Total baskets: "+baskets);

#endregion

#region Exercise5

int x = 5;
int y = 10;
int largerNumber;

if (x > y)
{
    largerNumber = x;
}
else
{
    largerNumber = y;
}

Console.WriteLine("The larger number from the two is "+largerNumber);

if (largerNumber % 2 == 0)
{
    Console.WriteLine("And the number is even");
}
else
{
    Console.WriteLine("And the number is odd");
}

#endregion

#region Exercise6

Console.WriteLine("Enter a number from 1 to 3");
int input = int.Parse(Console.ReadLine());

switch (input)
{
    case 1:
        Console.WriteLine("You got a new car!");
        break;
    case 2:
        Console.WriteLine("You got a new plane!");
        break;
    case 3:
        Console.WriteLine("You got a new bike!");
        break;
    default:
        Console.WriteLine("Invalid input! PLease enter a number from 1 to 3");
        break;

}


#endregion



#region Task1

Console.WriteLine("Enter the First number: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the Second number: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the Operation: ");
char c = char.Parse(Console.ReadLine());

switch (c)
{
    case '+':
        Console.WriteLine("The result is: " + (a + b));
        break;
    case '-':
        Console.WriteLine("The result is: " + (a - b));
        break;
    case '*':
        Console.WriteLine("The result is: " + (a * b));
        break;
    case '/':
        Console.WriteLine("The result is: " + (a / b));
        break;
    default:
        Console.WriteLine("Invalid input!");
        break;
}

#endregion




#region Task2

Console.WriteLine("Enter the First number:");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the Second number:");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the third number:");
double num3 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the four number:");
double num4 = double.Parse(Console.ReadLine());


double average = (num1 + num2 + num3 + num4) / 4;
Console.WriteLine($"The average of {num1}, {num2}, {num3} and {num4} is : {average}");



#endregion




#region Task3

Console.WriteLine("Input the First number");
double number1 = double.Parse(Console.ReadLine());

Console.WriteLine("Input the Second number");
double number2 = double.Parse(Console.ReadLine());

double temp = number1;
number1 = number2;
number2 = temp;


Console.WriteLine("After Swapping:");
Console.WriteLine("First Number: " + number1);
Console.WriteLine("Second Number: " + number2);



#endregion

