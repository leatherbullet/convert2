using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandConvertRublesInDollars = "1";
            const string CommandConvertRublesInEuro = "2";
            const string CommandConvertDollarsInRubles = "3";
            const string CommandConvertDollarsInEuro = "4";
            const string CommandConvertEuroInRubles = "5";
            const string CommandConvertEuroInDollars = "6";
            const string CommandEndSesson = "7";

            float rublesInDollar = 90;
            float rublesInEuro = 100;
            float dollarsInEuro = 0.9f;
            float euroInDollars = 1.1f;
            float walletInRubles;
            float walletInDollars;
            float walletInEuro;
            float userInput;

            string userChoice;

            bool canCycleWork = true;

            Console.WriteLine("введите количество рублей:");
            walletInRubles = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("введите количество долларов:");
            walletInDollars = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("введите количество евро:");
            walletInEuro = Convert.ToSingle(Console.ReadLine());

            while (canCycleWork == true)
            {
                Console.Clear();
                Console.WriteLine($"ваш баланс:\n{walletInRubles}рублей\n{walletInDollars}долларов\n{walletInEuro}евро\n");
                Console.WriteLine($"курс омена:\n доллар ={rublesInDollar} рублей\n евро ={rublesInEuro} рублей\n доллар ={dollarsInEuro} евро\n евро ={euroInDollars} долларов\n");
                Console.WriteLine("выберете действие");
                Console.WriteLine($"{CommandConvertRublesInDollars}- поменять рубли на доллары");
                Console.WriteLine($"{CommandConvertRublesInEuro}- поменять рубли на евро");
                Console.WriteLine($"{CommandConvertDollarsInRubles}- поменять доллары на рубли");
                Console.WriteLine($"{CommandConvertDollarsInEuro}- поменять доллары на евро");
                Console.WriteLine($"{CommandConvertEuroInRubles}- поменять евро на рубли");
                Console.WriteLine($"{CommandConvertEuroInDollars}- поменять евро на доллары");
                Console.WriteLine($"{CommandEndSesson}- выход");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case CommandConvertRublesInDollars://1 
                        Console.WriteLine("сколько вы хотите купить долларов");
                        userInput = Convert.ToSingle(Console.ReadLine());

                        if (userInput <= walletInRubles / rublesInDollar)
                        {
                            walletInDollars = walletInDollars + userInput;
                            walletInRubles -= userInput * rublesInDollar;
                            Console.WriteLine("операция прошла успешно");
                            Console.ReadKey();
                        }
                        else if (walletInRubles < rublesInDollar * userInput)
                        {
                            Console.WriteLine("на вашем балансе не достаточно средств");
                            Console.ReadKey();
                        }
                        break;

                    case CommandConvertRublesInEuro://2 
                        Console.WriteLine("сколько евро вы хотите купить");
                        userInput = Convert.ToSingle(Console.ReadLine());

                        if (userInput <= walletInRubles / rublesInEuro)
                        {
                            walletInEuro += userInput;
                            walletInRubles -= userInput * rublesInEuro;
                            Console.WriteLine("операция прошла успешно");
                            Console.ReadKey();
                        }
                        else if (walletInRubles < userInput * rublesInEuro)
                        {
                            Console.WriteLine("на вашем балансе не достаточно средств");
                            Console.ReadKey();
                        }
                        break;

                    case CommandConvertDollarsInRubles://3 
                        Console.WriteLine("сколько рублей вы хотите купить");
                        userInput = Convert.ToSingle(Console.ReadLine());

                        if (userInput <= walletInDollars * rublesInDollar)
                        {
                            walletInRubles += userInput;
                            walletInDollars -= userInput / rublesInDollar;
                            Console.WriteLine("операция прошла успешно");
                            Console.ReadKey();
                        }
                        else if (walletInDollars < userInput / rublesInDollar)
                        {
                            Console.WriteLine("на вашем балансе не достаточно средств");
                            Console.ReadKey();
                        }
                        break;

                    case CommandConvertDollarsInEuro://4 
                        Console.WriteLine("сколько евро вы хотите купить");
                        userInput = Convert.ToSingle(Console.ReadLine());

                        if (userInput <= walletInDollars * dollarsInEuro)
                        {
                            walletInEuro += userInput;
                            walletInDollars -= userInput * euroInDollars;
                            Console.WriteLine("операция прошла успешно");
                            Console.ReadKey();
                        }
                        else if (walletInDollars < userInput * euroInDollars)
                        {
                            Console.WriteLine("на вашем балансе не достаточно средств");
                            Console.ReadKey();
                        }
                        break;

                    case CommandConvertEuroInRubles://5 
                        Console.WriteLine("сколько рублей вы хотите купить");
                        userInput = Convert.ToSingle(Console.ReadLine());

                        if (userInput <= walletInEuro * rublesInEuro)
                        {
                            walletInRubles += userInput;
                            walletInEuro -= userInput / rublesInEuro;
                            Console.WriteLine("операция прошла успешно");
                            Console.ReadKey();
                        }
                        else if (walletInEuro < userInput / rublesInEuro)
                        {
                            Console.WriteLine("на вашем балансе не достаточно средств");
                            Console.ReadKey();
                        }
                        break;

                    case CommandConvertEuroInDollars://6 
                        Console.WriteLine("сколько долларов вы хотите купить");
                        userInput = Convert.ToSingle(Console.ReadLine());

                        if (userInput <= walletInEuro * euroInDollars)
                        {
                            walletInDollars += userInput;
                            walletInEuro -= userInput * dollarsInEuro;
                            Console.WriteLine("операция прошла успешно");
                            Console.ReadKey();
                        }
                        else if (walletInEuro < euroInDollars * userInput)
                        {
                            Console.WriteLine("на вашем балансе не достаточно средств");
                            Console.ReadKey();
                        }
                        break;

                    case CommandEndSesson:
                        canCycleWork = false;
                        break;

                    default:
                        Console.WriteLine("неверный ввод");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
