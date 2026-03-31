
using Homework.Class05;


Driver[] drivers = new Driver[]
{
    new Driver("Bob", 2),
    new Driver("Greg", 3),
    new Driver("Jill", 5),
    new Driver("Anne", 4)
};

Car[] cars = new Car[]
{
    new Car("Hyundai", 120),
    new Car("Mazda", 130),
    new Car("Ferrari", 200),
    new Car("Porsche", 180)
};

Console.WriteLine("Choose a car no.1:");
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine($"{i + 1}. {cars[i].Model}");
}
int carChoice1 = int.Parse(Console.ReadLine()) - 1;

Console.WriteLine("Choose Driver:");
for (int i = 0; i < drivers.Length; i++)
{
    Console.WriteLine($"{i + 1}. {drivers[i].Name}");
}
int driverChoice1 = int.Parse(Console.ReadLine()) - 1;

cars[carChoice1].Driver = drivers[driverChoice1];

Console.WriteLine("Choose a car no.2:");
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine($"{i + 1}. {cars[i].Model}");
}
int carChoice2 = int.Parse(Console.ReadLine()) - 1;

Console.WriteLine("Choose Driver:");
for (int i = 0; i < drivers.Length; i++)
{
    Console.WriteLine($"{i + 1}. {drivers[i].Name}");
}
int driverChoice2 = int.Parse(Console.ReadLine()) - 1;

cars[carChoice2].Driver = drivers[driverChoice2];

RaceCars(cars[carChoice1], cars[carChoice2]);

static void RaceCars(Car car1, Car car2)
{
    int speed1 = car1.CalculateSpeed(car1.Driver);
    int speed2 = car2.CalculateSpeed(car2.Driver);

    if (speed1 > speed2)
    {
        Console.WriteLine("Car no. 1 was faster.");
    }
    else if (speed2 > speed1)
    {
        Console.WriteLine("Car no. 2 was faster.");
    }
    else
    {
        Console.WriteLine("Both cars were equally fast.");
    }
}

