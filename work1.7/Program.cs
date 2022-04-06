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
            int isOneHour = 60;

            Console.Write("Введите кол-во людей в очереди: ");
            peopleInLine = Convert.ToInt32(Console.ReadLine());

            expectationInHours = (expectationLine * peopleInLine) / isOneHour;
            expectationInMinutes = (expectationLine * peopleInLine) % isOneHour;

            Console.WriteLine($"Вы должны отстоять в очереди {expectationInHours} часа и {expectationInMinutes} минут.");
        }
    }
}
