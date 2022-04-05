using System;

namespace work1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleInLine;
            int expectationLine = 10;
            int expectationInHours;
            int expectationInMinutes;

            Console.Write("Введите кол-во людей в очереди: ");
            peopleInLine = Convert.ToInt32(Console.ReadLine());

            expectationInHours = (expectationLine * peopleInLine) / 60;
            expectationInMinutes = (expectationLine * peopleInLine) % 60;

            Console.WriteLine($"Вы должны отстоять в очереди {expectationInHours} часа и {expectationInMinutes} минут.");
        }
    }
}
