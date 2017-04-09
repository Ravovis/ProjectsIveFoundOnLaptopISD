using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    class Program
    {


       static string Enc(string passTry)
        {
            Dictionary<char, char> array = new Dictionary<char, char>();
            array.Add('a','f');
            array.Add('b', 'q');
            array.Add('c', 't');
            array.Add('d', 'r');
            array.Add('e', 'x');
            array.Add('f', 'g');
            array.Add('g', 'z');
            array.Add('h', 'j');
            array.Add('i', 'i');
            array.Add('j', 's');
            array.Add('k', 'u');
            array.Add('l', 'c');
            array.Add('m', 'h');
            array.Add('n', 'v');
            array.Add('o', 'b');
            array.Add('p', 'd');
            array.Add('q', 'o');
            array.Add('r', 'a');
            array.Add('s', 'p');
            array.Add('t', 'y');
            array.Add('u', 'k');
            array.Add('v', 'w');
            array.Add('w', 'l');
            array.Add('x', 'e');
            array.Add('y', 'n');
            array.Add('z', 'm');
            string str = "";
            for (int i = 0; i < passTry.Length; i++)
            {
                str += array[passTry[i]];
            }
            str += "i";
            return str;



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
                        Console.WriteLine("Enter a number:");
                        int multiplier = int.Parse(Console.ReadLine());
                        Console.WriteLine("___________");
                        for (int i = 1; i <= 20; i++)
                        {
                            Console.WriteLine(i + "\t\t" + i * multiplier);
                        }
                        break;

                    case 1:
                        Console.WriteLine("Enter a number:");
                        string number1 = Console.ReadLine();
                        Console.WriteLine("It has " + number1.Length + " digits");
                        break;


                    case 2:
                        Random rand2 = new Random();
                        int number2 = rand2.Next(146) + 1;
                        int gues = 0;
                        while (gues != number2)
                        {
                            Console.WriteLine("Enter a number:");
                            gues = int.Parse(Console.ReadLine());
                            if (gues < number2)
                                Console.WriteLine("Too small");
                            else if (gues > number2)
                                Console.WriteLine("Too big");
                            else
                                Console.WriteLine("You get it!");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter the maximum:");
                        int maximum = int.Parse(Console.ReadLine());
                        int natural = 1;
                        while (natural * natural < maximum)
                        {
                            Console.Write((natural * natural) + "\t\t");
                            natural++;
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter the numbers:");
                        double s4 = 0;
                        for (int i = 0; i < 5; i++)
                        {
                            s4 += double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("The mean is " + (s4 / 5));

                        break;

                    case 5:
                        Console.WriteLine("Numbers:");
                        double s5 = 0;
                        double buf;
                        Random rand5 = new Random();
                        for (int i = 0; i < 5; i++)
                        {
                            buf = rand5.Next();
                            s5 += buf;
                            Console.Write(buf + "\t\t");
                        }
                        Console.WriteLine("The mean is " + (s5 / 5));
                        break;


                    case 6:

                        int geese = 0;
                        while (geese < 64)
                        {
                            if ((((64 - (geese * 2)) % 4) == 0) && (((64 - (geese * 2)) / 4) >= 0))
                                Console.WriteLine(geese + "geese and " + ((64 - (geese * 2)) / 4) + " rabbits");
                            geese++;
                        }

                        break;


                    case 7:
                        string password = "abbyi";
                        while (true)
                        {

                            Console.WriteLine("Enter the password");
                            string passTry = Console.ReadLine();
                            if (Enc(passTry) == password) // Хранить пароль воткрытую в коде - слишком рисковано. Любой дизасемлер сможет эту строку найти. Поэтому из соображений безопасности я и использовал банальное шифрование
                            {
                                Console.WriteLine("Welcome!"); return;
                            }
                            else
                            {
                                Console.WriteLine("Wrong password"); continue;
                            }
                        }
                        break;


                    case 8:
                        Console.WriteLine(@"Задачи
1. Вывести на экран таблицу умножения на N от 1 до 20 где N число введенное пользователем
2. Пользователь вводит число вывесли на экран количество разрядов в этом числе
3. Программа загадывает число от 1 до 146. Пользователь пытается его угадать. В случае не
верного ответа программа дает подсказку «больше» или «меньше»
4. Выведите все точные квадраты натуральных чисел, которые (квадраты) меньше заданного
числа N. (натуральные - это числа, которые мы используем при счёте: 1, 2, 3 и т.д.)
5. Прочитать с клавиатуры 5 целых чисел, посчитать их среднее арифметическое и сообщить его
пользователю
6. Создать 5 случайных целых чисел, посчитать их среднее арифметическое и сообщить его
пользователю
7. У гусей и кроликов вместе 64 лапы. Сколько может быть кроликов и гусей (указать все
сочетания)?
8. Напишите программу, которая будет «спрашивать» правильный пароль, до тех пор, пока он не
будет введен. Правильный пароль пусть будет «root». Если пароль не верный, программа
должна сказать 'Неверный пароль!' ");
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
                "Multiplication table","Amount of digits","Gues","Square", "Mean","Mean with random numbers","Limbs","Authorization", "Main Task(rus)" };
            while (true)
            {
                Console.Clear();
                Console.WriteLine("MENU\n__________");
                for (int i = 0; i < tasks.Length; i++)
                {
                    MenuElement(active, i, tasks[i]);
                }


                var KP = Console.ReadKey();
                switch (KP.Key)
                {
                    case ConsoleKey.Escape:
                        return;
                        break;
                    case ConsoleKey.DownArrow:
                        if (active != (tasks.Length - 1))
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
