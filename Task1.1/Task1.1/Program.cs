using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    class Program
    {


        static void Lottery()
        {
            try
            {
                Console.WriteLine("Enter your bet:");
                double bet = double.Parse(Console.ReadLine());
                Random Rand = new Random();

                int index = 3;
                while (index != 0)
                {
                    Console.Clear();
                    Console.WriteLine("The dice is rolling");
                    for (int i = 0; i < index; i++)
                    {
                        Console.Write("X");

                    }
                    System.Threading.Thread.Sleep(1000);
                    index--;
                }
                Console.Clear();
                int diceNumber = Rand.Next(12) + 1;
                Console.WriteLine("!" + diceNumber + "!");
                if (diceNumber <= 5)
                {
                    Console.WriteLine("You lost!"); return;
                }
                else if (diceNumber <= 8)
                {
                    Console.WriteLine("You get back your " + bet); return;
                }
                else if (diceNumber <= 11)
                {
                    Console.WriteLine("You get back " + bet * 2); return;
                }
                else if (diceNumber == 12)
                {
                    Console.WriteLine("You get back " + bet * 10); return;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Непредвиденная ошибка. Возврат к последней рабочей точке");
            }
        }

        static void MenuElement(int active, int current, string text)
        {
            if (current == active)
            {
                ConsoleColor oldColor = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(text);
                Console.BackgroundColor = oldColor;
            }
            else
            {
                Console.WriteLine(text);
            }
        }

        static void Task(int active)
        {
            Console.Clear();
            try
            {
                switch (active)
                {
                    case 0:

                        Console.WriteLine("Enter two numbers(not in one row):");
                        double a = double.Parse(Console.ReadLine()), b = double.Parse(Console.ReadLine());
                        if (a > b)
                            Console.WriteLine(a + " is the greatest");
                        else
                            Console.WriteLine(b + " is the greatest");
                        break;

                    case 1:

                        Console.WriteLine("мяу или гав?");
                        string s = Console.ReadLine().ToLower();
                        if (s == "мяу")
                            Console.WriteLine("Покорми кота");
                        else
                        {
                            if (s == "гав")
                                Console.WriteLine("Погуляй с собакой");
                            else
                                Console.WriteLine("А ты бунтарь");
                        }
                        break;


                    case 2:
                        Console.WriteLine("Введите номер месяца в году");
                        int answer = int.Parse(Console.ReadLine());
                        switch (answer)
                        {
                            case 12:
                            case 1:
                            case 2:
                                Console.WriteLine("Зима");
                                break;
                            case 3:
                            case 4:
                            case 5:
                                Console.WriteLine("Весна");
                                break;
                            case 6:
                            case 7:
                            case 8:
                                Console.WriteLine("Лето");
                                break;
                            case 9:
                            case 10:
                            case 11:
                                Console.WriteLine("Осень");
                                break;
                            default:
                                Console.WriteLine("На этой планете такого месяца нет»");
                                break;

                        }
                        break;

                    case 3:
                        Console.WriteLine("Введите 1 или 0");
                        int number = int.Parse(Console.ReadLine());
                        Console.WriteLine(number == 0 ? "Плохо" : number == 1 ? "Хорошо" : "");

                        break;

                    case 4:
                        Console.WriteLine("Введите номер дня недели");
                        int daynumber = int.Parse(Console.ReadLine());
                        switch (daynumber)
                        {
                            case 1:
                                Console.WriteLine("Понедельник");
                                break;
                            case 2:
                                Console.WriteLine("Вторник");
                                break;
                            case 3:
                                Console.WriteLine("Среда");
                                break;
                            case 4:
                                Console.WriteLine("Четверг");
                                break;
                            case 5:
                                Console.WriteLine("Пятница");
                                break;
                            case 6:
                                Console.WriteLine("Суббота");
                                break;
                            case 7:
                                Console.WriteLine("Воскресение");
                                break;
                            default:
                                Console.WriteLine("Нет такого дня недели");
                                break;
                        }
                        break;

                    case 5:
                        Console.WriteLine("km:");
                        double km = double.Parse(Console.ReadLine());
                        Console.WriteLine("iddle:");
                        double iddle = double.Parse(Console.ReadLine());
                        double price = 0 + ((km > 0) ? 20 : 0) + ((km > 5) ? (km - 5) : 0) * 3 + iddle;
                        Console.WriteLine("Total Price: {0:c}", price);
                        break;


                    case 6:
                        Console.WriteLine("Enter a number");
                        int natural = int.Parse(Console.ReadLine());
                        bool prime_flag = true;
                        for (int i = natural - 1; i > 1; i--)
                            if (natural % i == 0)
                            {
                                prime_flag = false;
                                break;
                            }
                        Console.WriteLine("This number is " + (prime_flag ? "prime" : "composite"));
                        break;


                    case 7:
                        Lottery();
                        break;


                    case 8:
                        const double uah_to_usd = 0.036704, usd_to_uah = 27.2449869,
                            uah_to_euro = 0.034254, euro_to_uah = 29.19,
                            usd_to_euro = 0.930760711, euro_to_usd = 1.07439;
                        Console.WriteLine("value:");
                        double value = double.Parse(Console.ReadLine());
                        Console.WriteLine("currency(USD,EURO,UAH):");
                        string currency = Console.ReadLine().ToUpper();

                        if (currency == "UAH")
                        {
                            Console.WriteLine("ToEuro:" + value * uah_to_euro);
                            Console.WriteLine("ToUSD:" + value * uah_to_usd);
                        }
                        else if (currency == "EURO")
                        {
                            Console.WriteLine("ToUAH:" + value * euro_to_uah);
                            Console.WriteLine("ToUSD:" + value * euro_to_usd);
                        }
                        else if (currency == "USD")
                        {
                            Console.WriteLine("ToEuro:" + value * usd_to_euro);
                            Console.WriteLine("ToUAH:" + value * usd_to_uah);
                        }
                        break;

                    case 9:
                        Console.WriteLine(@"Задачи
1. Пользователь вводит два числа. Вывести на экран большее
2. Пользователь вводит слово «мяу» или слово «гав» если слово введенное пользователем
«мяу» вывести на экран «Покорми кота» иначе «Погуляй с собакой»
3. Пользователь вводит номер месяца если месяц 1,2,12 вывести на экран «Зима»; 3,4,5 –
«Весна»; 6-8 – «Лето»; 9-11 – «Осень». В любом другом случае «На этой планете такого месяца
нет»
4. Пользователь вводит число 1 или 0 с помощью одной строки кода вывести на экран «Хорошо»
если пользователь ввел 1 или «Плохо» если пользователь ввел 0
5. Вывести название дня недели по его номеру (1 - понедельник, 7 - воскресенье)
6. Служба такси заказала вам программу, которая спрашивает количество километров и
количество минут простоя, а дальше считает так: первые 5 километров (или до 5 км) 20
гривен, каждый следующий километр 3 гривны, плюс простой 1 грн за 1 минуту. Программа
должна посчитать и сказать общую сумму оплаты за поездку.
7. Дано натуральное число. Выяснить, является ли оно простым, т.е. делится только на 1 и на
само себя.
8. Вы организатор лотереи. Пользователь вводит ставку. Вы бросаете 12-гранный кубик. Если
выпадают значения от 1 до 5, пользователь проиграл. Если выпадают значения от 6 до 8,
пользователь получает свою ставку обратно. Если выпало от 9 до 11, пользователь получает
двойную ставку, а если выпало 12 - ставку умноженную на 10. После окончания игры покажите
пользователю, сколько он выиграл.
9. Сделать программу перевода валют. Вводится сумма, потом выбирается вид валюты – гривны
или доллары или евро, программа переводит в две другие валюты. Текущий курс валюты
считать известным.
");
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Непредвиденная ошибка. Возврат к последней рабочей точке");
            }
        }
        //----------------------------------
        static void Menu()
        {
            int active = 0;
            string[] tasks = {
                "Two numbers", "Mew/bark(rus)", "Month(rus)", "Good/Bad(rus)", "Day(rus)", "Taxi", "Prime Numbers", "Lottery", "Currency", "Main Task(rus)" };
            while (true)
            {
                Console.Clear();
                Console.WriteLine("MENU\n__________");
                for (int i = 0; i < tasks.Length; i++)
                {
                    MenuElement(active, i, tasks[i]);
                }


                var KP = Console.ReadKey();
                switch(KP.Key)
                {
                   case ConsoleKey.Escape:
                        return;
                        break;
                    case ConsoleKey.DownArrow:
                        if(active != (tasks.Length-1))
                        {
                            active++;
                            continue;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (active != 0)
                        {
                            active--;
                            continue;
                        }
                        break;
                    case ConsoleKey.Enter:
                        Task(active);
                        Console.ReadKey();
                        continue;
                        break;
            }
                

            }
            

        }
        //-----------------------------------
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Menu();
            


        }
    }
}
