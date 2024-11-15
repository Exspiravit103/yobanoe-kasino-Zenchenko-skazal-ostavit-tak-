using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
namespace yobanoe_kasino_Zenchenko_skazal_ostavit_tak_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                int first, Second, three;
                Console.WriteLine("Введите вашу ставку");
                int bid;
                bid = int.Parse(Console.ReadLine());
                if (bid == 42) //немного читов от максимов)
                {
                    bid = 100;
                    first = 7;
                    Second = 7;
                    three = 7;
                    Console.WriteLine("Вселенная удивленна вашимы познаниями и стримится вам угодить");
                    goto Cheat;
                }
                if (!(bid % 5 == 0 && bid >= 5 && bid <= 100))
                {
                    Console.WriteLine("Некоректное значение ставки");
                    Main(args);
                }
                Random random = new Random();
                first = random.Next(1, 10);
                Second = random.Next(1, 10);
                three = random.Next(1, 10);
                Cheat:
                double result = 1;
                Console.WriteLine($"{first} {Second} {three}");
                if ((first == Second) && (Second == three))
                {
                    switch (first)
                    {
                        case 1:
                            result *= bid * 10 * 1.5;
                            break;
                        case 2:
                            result *= bid * 20 * 1.5;
                            break;
                        case 3:
                            result *= bid * 30 * 1.5;
                            break;
                        case 4:
                            result *= bid * 40 * 1.5;
                            break;
                        case 5:
                            result *= bid * 50 * 1.5;
                            break;
                        case 6:
                            result *= bid * 60 * 1.5;
                            break;
                        case 7:
                            Console.WriteLine("ДЖЕКПОТ!");
                            result *= bid * 150 * 1.5;
                            break;
                        case 8:
                            result *= bid * 80 * 1.5;
                            break;
                        case 9:
                            result *= bid * 90 * 1.5;
                            break;
                    }
                    Console.WriteLine($"ваш выиграш составил: {result}");
                }
                else if ((first == Second) || (first == three))
                {
                    Console.WriteLine($"ваш выиграш составил:{Twosame(first, bid)}");
                }
                else if ((Second == three))
                {
                    Console.WriteLine($"ваш выиграш составил:{Twosame(Second, bid)}");
                }
                else
                {
                    Console.WriteLine("к сожалению(вашему) вы проиграли и потеряли деньги(в нашем кармане)");
                }

            }
            static double Twosame(int a, int bid)
            {
                double result = 1;
                switch (a)
                {
                    case 1:
                        result *= bid * 1 * 1.25;
                        break;
                    case 2:
                        result *= bid * 2 * 1.25;
                        break;
                    case 3:
                        result *= bid * 3 * 1.25;
                        break;
                    case 4:
                        result *= bid * 4 * 1.25;
                        break;
                    case 5:
                        result *= bid * 5 * 1.25;
                        break;
                    case 6:
                        result *= bid * 6 * 1.25;
                        break;
                    case 7:
                        Console.WriteLine("Мини Джекпот");
                        result *= bid * 15 * 1.25;
                        break;
                    case 8:
                        result *= bid * 8 * 1.25;
                        break;
                    case 9:
                        result *= bid * 9 * 1.25;
                        break;
                }
                return result;
            }
        }
    }
}
