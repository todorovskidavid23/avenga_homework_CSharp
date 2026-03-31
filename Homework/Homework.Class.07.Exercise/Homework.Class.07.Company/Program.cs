using Homework.Class._07.CompanyLibrary;

SalesPerson salesPerson = new SalesPerson("David", "Todorovski");
salesPerson.AddSuccessRevenue(3000);
salesPerson.PrintInfo();
Console.WriteLine($"Salary: {salesPerson.GetSalary()}");

Manager manager = new Manager("John", "Doe", 1000);
manager.AddBonus(500);
manager.PrintInfo();
Console.WriteLine($"Salary: {manager.GetSalary()}");
