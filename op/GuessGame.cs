using System;

public class GuessGame
{
    public void Run()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 51);
        int userGuess = 0;

        Console.WriteLine("Угадай число");
        Console.WriteLine("Я загадала число от 1 до 50. Попробуйте угадать его, если не боишься!");

        // Цикл, пока пользователь не угадает число
        while (userGuess != secretNumber)
        {
            Console.Write("Введите ваше число: ");
            userGuess = Convert.ToInt32(Console.ReadLine());

            if (userGuess < secretNumber)
            {
                Console.WriteLine("Слишком мало! Попробуйте еще раз или купи шоколадку.");
            }
            else if (userGuess > secretNumber)
            {
                Console.WriteLine("Слишком много! Попробуй еще раз или купи шоколадку.");
            }
            else
            {
                Console.WriteLine($"Поздравляю! Вы угадали число с вас шоколадка! Загаданное число: {secretNumber}.");
            }
        }
    }
}