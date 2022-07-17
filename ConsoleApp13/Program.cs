using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            float convertingRublesToDollars = 0.0172f;
            float convertingDollarsToEuros = 1.01f;
            float converingRublesToEuros = 0.173f;
            float convertingEurosToDollars = 0.99f;
            float convertingDollarsToRubles = 57.83f;
            float convertingEurosToRubles = 57.89f;
            float balanceRuble;
            float balanceDollar;
            float balanceEuro;
            string userInput;
            float currencyCount;
            bool isExit = false;

            while (isExit == false)
            {

                Console.WriteLine("Курсы валют на сегодня!");
                Console.WriteLine("1 Доллар = " + convertingDollarsToRubles + " рублей; " + convertingDollarsToEuros + " евро");
                Console.WriteLine("1 Евро = "+convertingEurosToRubles+" рублей; "+convertingEurosToDollars+" долларов");
                Console.WriteLine("1 Рубль = "+convertingRublesToDollars+" долларов; "+ converingRublesToEuros+" евро");

                Console.Write("Введите кол-во ваших рублей: ");
                balanceRuble = Convert.ToSingle(Console.ReadLine());
                Console.Write("Введите кол-во ваших долларов: ");
                balanceDollar = Convert.ToSingle(Console.ReadLine());
                Console.Write("Введите кол-во ваших евро: ");
                balanceEuro = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("1 - обменять рубли на доллары");
                Console.WriteLine("2 - обменять доллары на рубли");
                Console.WriteLine("3 - обменять рубли на евро"); 
                Console.WriteLine("4 - обменять евро на рубли");
                Console.WriteLine("5 - обменять евро на доллары");
                Console.WriteLine("6 - обменять доллары на евро");
                Console.WriteLine("7 - Покинуть приложение");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Обмен рублей на доллары");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (balanceRuble >= currencyCount)
                        {
                            balanceRuble -= currencyCount;
                            balanceDollar += currencyCount * convertingRublesToDollars;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Обмен долларов на рубли");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (balanceDollar >= currencyCount)
                        {
                            balanceDollar -= currencyCount;
                            balanceRuble += currencyCount * convertingDollarsToRubles;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Обмен рублей на евро");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (balanceRuble >= currencyCount)
                        {
                            balanceRuble -= currencyCount;
                            balanceEuro += currencyCount * converingRublesToEuros;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Обмен евро на рубли");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (balanceEuro >= currencyCount)
                        {
                            balanceEuro -= currencyCount;
                            balanceRuble += currencyCount * convertingEurosToRubles;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Обмен евро на доллары");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (balanceEuro >= currencyCount)
                        {
                            balanceEuro -= currencyCount;
                            balanceDollar += currencyCount * convertingDollarsToEuros;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств");
                        }
                        break;
                    case "6":
                        Console.WriteLine("Обмен доллары на евро");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (balanceDollar >= currencyCount)
                        {
                            balanceDollar -= currencyCount;
                            balanceEuro += currencyCount * convertingEurosToDollars;
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств");
                        }
                        break;
                    case "7":
                        Console.WriteLine("Приходите в другой раз");
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("Выберете правильную команду");
                        break;
                }

                Console.WriteLine("Ваш баланс " + balanceRuble + " рублей, " + balanceDollar + " долларов, " + balanceEuro + " евро");
            }
        }
    }
}
