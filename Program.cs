using System;

class MainClass
{
    public static void Main(string[] args)
    {

        string MyName = "Jane";
        byte MyAge = 27;
        bool HaveIApet = true;
        double MyShoeSize = 37.5;
        double result = 10 % 3;

        Console.WriteLine("My name is " + MyName);
        Console.WriteLine("MyAge " + MyAge);
        Console.WriteLine("Do I have a pet? " + HaveIApet);
        Console.WriteLine("My shoe size is " + MyShoeSize);
        Console.WriteLine(DayOfWeek.Sunday);
        Console.WriteLine(result);
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        byte age = (byte)int.Parse(Console.ReadLine());
        Console.WriteLine("Your name is {0} and age is {1} ", name, age);
        Console.WriteLine("What is your favorite day of week?");
        DayOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine());
        Console.WriteLine($"You favotite day is {day}");
        Console.ReadKey();
    }



    enum DayOfWeek : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }

    enum Semaphore: int
    {
        red = 100,
        yellow = 200,
        green = 300
    }

    
}