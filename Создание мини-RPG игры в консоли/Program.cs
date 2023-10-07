using System.ComponentModel.Design;
using System.Globalization;

namespace GolubevaMR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игрок просыпается в незнакомой комнате и пытается вспомнить свое имя. Введите имя игрока:");
            string name = Console.ReadLine();
            Console.WriteLine("Имя героя " + name);
            Console.WriteLine(name + ", осматривается и видит вокруг себя следующие возможности: \n a. Открыть дверь \n б. Заглянуть под кровать \n в. Открыть ящик в углу комнаты \n г. Открыть вентиляцию \n д. Взглянуть на тумбочку \n е. Взглянуть на статую рядом \n");
            Console.WriteLine("Выберите действие:");
            string choice = Console.ReadLine();
            bool isGotKey = false;
            int art = 0;
            string thing = "артефакт";
            int num = 0;
            do
            {
                if (choice == "а")
                {
                    if (isGotKey == true)
                    {
                        Console.WriteLine("Дверь открыта!");
                        choice = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Дверь не открывается. Нужна отмычка!");
                        choice = Console.ReadLine();

                    }
                }
                else if (choice == "б")
                {
                    Console.WriteLine("Под кроватью " + name + " нашел первый " + thing + " для активации статуи");
                    art = art + 1;
                    choice = Console.ReadLine();
                }
                else if (choice == "в")
                {
                    if (art == 3)
                    {
                        Console.WriteLine(name + " открыл ящик и в нем лежит отмычка. Теперь можно открыть дверь!");
                        choice = Console.ReadLine();
                        isGotKey = true;
                    }
                    else
                    {
                        Console.WriteLine("Ящик не открылся.\nЧтобы открыть ящик нужно активировать статую!");
                        choice = Console.ReadLine();
                    }
                }
                else if (choice == "г")
                {

                    if (num < 3)
                    {
                        num++;
                        Console.WriteLine(name + " попробуй ещё раз!!");
                        choice = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Вентиляция открыта. Найдет второй " + thing);
                        art = art + 1;
                        choice = Console.ReadLine();
                    }
                }
                else if (choice == "д")
                {
                    art = art + 1;
                    Console.WriteLine("Найден третий " + thing);
                    choice = Console.ReadLine();
                }
                else if (choice == "е")
                {
                    if (art == 3)
                    {
                        Console.WriteLine("Статуя активирована!Теперь можно открыть ящик!");
                        choice = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(name + " должен сначала найти 3 артефакта!");
                        choice = Console.ReadLine();
                    }
                }
            }
            while (isGotKey == false);
            Console.WriteLine("Дверь открыта!");
            Console.WriteLine("Игра закончена");
        }
    }
}