using System;
using ConsoleApp;
namespace ConsoleApp
{

    class ConsoleScreen : IProgram 
{
  public void run() 
  {
      Ford ford = new Ford();
      Tesla tesla = new Tesla();
      Toyota toyota = new Toyota();
      String choiceno;
    Console.WriteLine("***Welcome to OOPII car review***");
    Console.WriteLine("*# Choose Car");
    Console.WriteLine($"1. {ford.carmodel()}");
    Console.WriteLine($"2. {tesla.carmodel()}");
    Console.WriteLine($"3. {toyota.carmodel()}");
    Console.WriteLine("Enter the no to see the Specification \n enter 0 to exit");
    choiceno = Console.ReadLine();
    while(choiceno != "0")
    {
        choice(choiceno);
        break;
    }
  }
  public void choice(String c)
  {
      Ford ford = new Ford();
      Tesla tesla = new Tesla();
      Toyota toyota = new Toyota();
      switch (c) 
{
  case "1":
    Console.WriteLine("################################# \n");
    Console.WriteLine($"Car Model : {ford.carmodel()}");
    Console.WriteLine($"Horse Power : {ford.carHorsepower()}");
    Console.WriteLine($"Price : {ford.carPrice()}");
    Console.WriteLine($"Fuel Type : {ford.carFuelConsumption()}");
    Console.WriteLine($"Mileage : {ford.Mileage} \n");                   // access encapsulated field with property
    Console.WriteLine("################################# \n");
    run();
    break;
  case "2":
    Console.WriteLine("################################# \n");
    Console.WriteLine($"Car Model : {tesla.carmodel()}");
    Console.WriteLine($"Horse Power : {tesla.carHorsepower()}");
    Console.WriteLine($"Price : {tesla.carPrice()}");
    Console.WriteLine($"Fuel Type : {tesla.carFuelConsumption()}");
    Console.WriteLine($"Mileage : {tesla.Mileage} \n");                // access encapsulated field with property
    Console.WriteLine("#################################");
    run();
    break;
case "3":
    Console.WriteLine("################################# \n");
    Console.WriteLine($"Car Model : {toyota.carmodel()}");
    Console.WriteLine($"Horse Power : {toyota.carHorsepower()}");
    Console.WriteLine($"Price : {toyota.carPrice()}");
    Console.WriteLine($"Fuel Type : {toyota.carFuelConsumption()}");
    Console.WriteLine($"Mileage : {toyota.Mileage} \n");                // access encapsulated field with property
    Console.WriteLine("#################################");
    run();
    break;
case "0":
    break;
  default:
    Console.WriteLine("please enter no of the car from the coice");
    run();
    break;
}
  }
}

  class Program
  {
    static void Main(string[] args)
    {
       ConsoleScreen screen = new ConsoleScreen();
       screen.run();
       }  
  }
}