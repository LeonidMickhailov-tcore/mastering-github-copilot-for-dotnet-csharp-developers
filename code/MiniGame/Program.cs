using System;
using MiniGame;

class Program
{
    static void Main()
    {
        bool playAgain = true;
        while (playAgain)
        {
            Console.WriteLine("Выберите предмет:");
            foreach (var thing in Enum.GetValues(typeof(Things)))
            {
                Console.WriteLine($"{(int)thing} - {thing}");
            }

            Console.Write("Ваш выбор: ");
            if (!int.TryParse(Console.ReadLine(), out int userChoice) ||
                !Enum.IsDefined(typeof(Things), userChoice))
            {
                Console.WriteLine("Некорректный выбор.");
                continue;
            }

            Things userThing = (Things)userChoice;

            Random rnd = new Random();
            Things computerThing = (Things)rnd.Next(0, 3);

            Console.WriteLine($"Компьютер выбрал: {computerThing}");

            if (userThing == computerThing)
            {
                Console.WriteLine("Ничья!");
            }
            else if (
                (userThing == Things.Rock && computerThing == Things.Scissors) ||
                (userThing == Things.Scissors && computerThing == Things.Paper) ||
                (userThing == Things.Paper && computerThing == Things.Rock)
            )
            {
                Console.WriteLine("Вы победили!");
            }
            else
            {
                Console.WriteLine("Победил компьютер!");
            }

            Console.Write("Сыграть ещё раз? (д/н): ");
            var answer = Console.ReadLine();
            playAgain = answer != null && answer.Trim().ToLower() == "д";
            Console.WriteLine();
        }
        Console.WriteLine("Спасибо за игру!");
    }
}

