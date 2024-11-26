using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Введите ваше имя: ");
        string userName = Console.ReadLine();
        Console.WriteLine($"Здравствуй, {userName} тебя приветсвует Апполинария !");

        
        Console.Write("Напиши в год который ты родился и я скажу сколько тебе лет: ");
        int yearOfBirth = int.Parse(Console.ReadLine());
        int currentYear = DateTime.Now.Year;
        int age = currentYear - yearOfBirth;

        
        Console.WriteLine($"ТЫ еще крсотка тебе всего лишь: {age} лет.");
        Console.WriteLine($"с тебя 100.000 рублей мне на карту");

    }
}
