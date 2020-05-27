using System;

namespace Lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть число");
            string number = Console.ReadLine();
            int i = int.Parse(number);
            switch (i)
            {
                case 10:
                    Console.WriteLine("Десять ");
                    break;
                case 11:
                    Console.WriteLine("Одинадцять ");
                    break;
                case 12:
                    Console.WriteLine("Дванадцять");
                    break;
                case 13:
                    Console.WriteLine("Тринадцять ");
                    break;
                case 14:
                    Console.WriteLine("Чотирнадцять ");
                    break;
                case 15:
                    Console.WriteLine("П'ятнадцять ");
                    break;
                case 16:
                    Console.WriteLine("Шiстнадцять ");
                    break;
                case 17:
                    Console.WriteLine("Сiмнадцять ");
                    break;
                case 18:
                    Console.WriteLine("Вiсiмнадцять ");
                    break;
                case 19:
                    Console.WriteLine("Дев'ятнадцять ");
                    break;
                case 20:
                    Console.WriteLine("Двадцять ");
                    break;
                default:
                    Console.WriteLine("Введiть число вiд 10 до 20 ");
                    break;

            }
            Console.ReadKey();
        }
    }
}