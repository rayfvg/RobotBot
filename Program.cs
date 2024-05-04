using System;

namespace MyPersonalRobots
{
    public class Program
    {
        private static void Main(string[] args)
        {
            bool EndProgramm = true;
            while (EndProgramm)
            {
                SetConsoleColor(ConsoleColor.Green);

                int numberOfCommand = GreetingUser();

                InputUserOperation(numberOfCommand);

                Console.WriteLine("\nПовторить программу? Y/N");
                string responseUser = Console.ReadLine();
                if (responseUser == "Y") EndProgramm = true;
                if (responseUser == "N") EndProgramm = false;

            }


        }

        private static int GreetingUser()
        {
            Console.WriteLine("Привет, меня зовут Александр, я твой робот");
            Console.Write("Введите ваше имя: ");

            string userName = Console.ReadLine();

            Console.WriteLine($"\n\nПриветствую вас: {userName}");
            Console.WriteLine("Введите команду:\n 1 - Калькулятор\n 2 - Рассказать случайный анекдот\n 3 - Покраска консоли\n 4 - Случайный герой в лол\n 5 - Обмен валют");

            int numberOfCommand = Convert.ToInt32(Console.ReadLine());
            return numberOfCommand;
        }

        private static void InputUserOperation(int numberOfCommand)
        {
            switch (numberOfCommand)
            {
                case 1:
                    SetConsoleColor(ConsoleColor.Green);

                    Console.WriteLine("\nВыберите операцию: \n\n1 - сложение \n\n2 - вычитание \n\n3 - умножение \n\n4 - деление");

                    int numberOperation = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите два числа");

                    float NumberOna = Convert.ToInt32(Console.ReadLine());
                    float NumberTwo = Convert.ToInt32(Console.ReadLine());

                    if (numberOperation == 1) Amount(NumberOna, NumberTwo);
                    if (numberOperation == 2) Subtraction(NumberOna, NumberTwo);
                    if (numberOperation == 3) Multiplication(NumberOna, NumberTwo);
                    if (numberOperation == 4) Division(NumberOna, NumberTwo);

                    break;

                case 2:
                    SetConsoleColor(ConsoleColor.Green);

                    Random randomNumber = new Random();
                    TellJoke(randomNumber.Next(1, 5));
                    break;

                case 3:
                    SetConsoleColor(ConsoleColor.Green);

                    Console.WriteLine("\nВыберите цвет. 1 - Синий, 2 - Зеленый, 3- Красный");
                    int userChangeConsoleColor = Convert.ToInt32(Console.ReadLine());

                    if (userChangeConsoleColor == 1)
                    {
                        SetConsoleColor(ConsoleColor.Blue);
                        Console.WriteLine("Цвет изменен на синий");
                    }

                    else if (userChangeConsoleColor == 2)
                    {
                        SetConsoleColor(ConsoleColor.Green);
                        Console.WriteLine("Цвет изменен на зеленый");
                    }

                    else if (userChangeConsoleColor == 3)
                    {
                        SetConsoleColor(ConsoleColor.Red);
                        Console.WriteLine("Цвет изменен на красный");
                    }

                    else Console.WriteLine("Была введена не верная операция");
                    break;

                case 4:
                    SetConsoleColor(ConsoleColor.Green);

                    Console.WriteLine("\nВыберите роль: Танк, Керри, Саппорт (с большой буквы)");

                    string gameRole = Console.ReadLine();

                    if (gameRole == "Танк")
                        Console.WriteLine("Персонаж Зак");

                    else if (gameRole == "Керри")
                        Console.WriteLine("Персонаж Ясио");

                    else if (gameRole == "Саппорт")
                        Console.WriteLine("Ваш персонаж Сона");

                    else
                        Console.WriteLine("Не правильно выбрана роль");

                    break;

                case 5:

                    float rublesInWallet;
                    float dollarInWallet;

                    int rubToUsd = 94;
                    int UsdToRub = 98;

                    int choosingOperation;
                    float moneyForExchange;

                    Console.WriteLine("Добро пожаловать в обменник валют");
                    Console.WriteLine("\nВведите баланс рублей");
                    rublesInWallet = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите баланс долларов");
                    dollarInWallet = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Выберите операцию:");
                    Console.WriteLine("\n1 - Обменять рубли на доллары");
                    Console.WriteLine("\n2 - Обменять доллары на рубли");
                    choosingOperation = Convert.ToInt32(Console.ReadLine());
                    if (choosingOperation == 1)
                    {
                        Console.WriteLine("Обмен рублей на доллары");
                        Console.WriteLine("\nСколько вы хотите обменять");
                        moneyForExchange = Convert.ToInt32(Console.ReadLine());
                        if (rublesInWallet >= moneyForExchange)
                        {
                            rublesInWallet -= moneyForExchange;
                            dollarInWallet += moneyForExchange / rubToUsd;
                        }
                        else Console.WriteLine("Не достаточно рублей");
                    }
                    else if (choosingOperation == 2)
                    {
                        Console.WriteLine("Обмен долларов на рубли");
                        Console.WriteLine("\nСколько вы хотите обменять");
                        moneyForExchange = Convert.ToInt32(Console.ReadLine());
                        if (dollarInWallet >= moneyForExchange)
                        {
                            dollarInWallet -= moneyForExchange;
                            rublesInWallet += moneyForExchange * UsdToRub;
                        }
                        else Console.WriteLine("Не достаточно долларов");
                    }
                 Console.WriteLine($"У вас {dollarInWallet} долларов и {rublesInWallet} рублей");   

                    break;

                default:
                    SetConsoleColor(ConsoleColor.DarkRed);
                    Console.WriteLine("\nБыла введена не верная операция");
                    break;
            }
        }

        private static void TellJoke(int index)
        {
            switch (index)
            {
                case 1:
                    Console.WriteLine("- Дочь, ты пила?\n- Нет, мама я топор");
                    break;

                case 2:
                    Console.WriteLine("Штирлиц стрелял вслепую\nСлепая бегала зигзагами и кричала");
                    break;

                case 3:
                    Console.WriteLine("Девушка не вовремя сделала каменное лицо\nи утонула");
                    break;

                case 4:
                    Console.WriteLine("Митинг косоглазых состоялся\nна сорок метров левее здания городской администрации");
                    break;
            }
        }
        private static void SetConsoleColor(ConsoleColor color) => Console.ForegroundColor = color;

        private static void Amount(float a, float b)
        {
            float summa = a + b;

            Console.WriteLine("\nРезультат: " + summa);
        }

        private static void Subtraction(float a, float b)
        {
            float subtraction = a - b;

            Console.WriteLine("\nРезультат: " + subtraction);
        }

        private static void Multiplication(float a, float b)
        {
            float multiplication = a * b;

            Console.WriteLine("\nРезультат: " + multiplication);
        }

        private static void Division(float a, float b)
        {
            float division = a / b;

            Console.WriteLine("\nРезультат: " + division);

            if (a == 0 || b == 0)
                Console.WriteLine("\nНельзя вводить ноль");
        }
    }
}