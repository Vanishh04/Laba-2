using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2_
{
    internal class Bundle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Генерация букета ********** ");
            Rose rose1 = new Rose(46, "высшая свежесть");
            Console.WriteLine("Выберите первый цветок:");
            Console.WriteLine();
            Console.WriteLine("#1:");
            Console.WriteLine();
            rose1.GetInfo();
            Console.WriteLine();
            Rose rose2 = new Rose(28, "средняя свежесть");
            Console.WriteLine("#2:");
            Console.WriteLine();
            rose2.GetInfo();
            Console.WriteLine();

            Console.WriteLine("Введите 1 или 2 для выбора первого цветка");
            Console.WriteLine();

            Flower[] bundle = new Flower[3];


            int status1 = 1;
            while (status1 != 0)
            {
                char choose1 = Console.ReadKey(true).KeyChar;
                switch (choose1)
                {
                    case '1': bundle[0] = rose1; Console.WriteLine("Выбран первый цветок с номером 1"); status1 = 0; break;
                    case '2': bundle[0] = rose2; Console.WriteLine("Выбран первый цветок с номером 2"); status1 = 0; break;
                    default: Console.WriteLine("Вы ввели некоректные значени, введите снова"); break;
                }
            };

            Console.WriteLine();

            Console.WriteLine("Выберите второй цветок:");
            Console.WriteLine();
            Console.WriteLine("#1:");
            Lily lily1 = new Lily(22, "средняя свежесть");
            Console.WriteLine();
            lily1.GetInfo();
            Console.WriteLine();
            Console.WriteLine("#2:");
            Lily lily2 = new Lily(29, "низкая свежесть");
            Console.WriteLine();
            lily2.GetInfo();
            Console.WriteLine();

            Console.WriteLine("Введите 1 или 2 для выбора второго цветка");



            int status2 = 1;
            while (status2 != 0)
            {
                char choose2 = Console.ReadKey(true).KeyChar;
                switch (choose2)
                {
                    case '1': bundle[1] = lily1; Console.WriteLine("Выбран второй цветок с номером 1"); status2 = 0; break;
                    case '2': bundle[1] = lily2; Console.WriteLine("Выбран второй цветок с номером 2"); status2 = 0; break;
                    default: Console.WriteLine("Вы ввели некоректные значени, введите снова"); break;
                }
            }

            Console.WriteLine();


            Console.WriteLine("Выберите третий цветок:");
            Console.WriteLine();
            Console.WriteLine("#1:");
            Chamomille chamomile1 = new Chamomille(19, "средняя свежесть");
            Console.WriteLine();
            chamomile1.GetInfo();
            Console.WriteLine();
            Console.WriteLine("#2:");
            Chamomille chamomile2 = new Chamomille(16, "высокая свежесть");
            Console.WriteLine();
            chamomile2.GetInfo();
            Console.WriteLine();

            Console.WriteLine("Введите 1 или 2 для выбора второго цветка");



            int status3 = 1;
            while (status3 != 0)
            {
                char choose3 = Console.ReadKey(true).KeyChar;
                switch (choose3)
                {
                    case '1': bundle[2] = chamomile1; Console.WriteLine("Выбран третий цветок с номером 1"); status3 = 0; break;
                    case '2': bundle[2] = chamomile2; Console.WriteLine("Выбран третий цветок с номером 2"); status3 = 0; break;
                    default: Console.WriteLine("Вы ввели некоректные значени, введите снова"); break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Цена букета:");

            int price = 0;
            for (int i = 0; i < bundle.Length; i++)
            {
                price += bundle[i].Price;
            }
            Console.WriteLine($"{price} грн");
            Console.WriteLine("*****************************************************");

            Console.WriteLine();
            Console.WriteLine("Сортировка цветов по уровню свежести:");
            Console.WriteLine();

            Console.WriteLine("*****************************************************");
            Console.WriteLine("Низкий уровень свежести:");
            string low = "низкая свежесть";

            for (int i = 0; i < bundle.Length; i++)
            {
                if (bundle[i].Fresh == low)
                {
                    Console.WriteLine(bundle[i].Name);
                }

            }
            Console.WriteLine("*****************************************************");

            Console.WriteLine();
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Средний уровень свежести:");
            string medium = "средняя свежесть";

            for (int i = 0; i < bundle.Length; i++)
            {
                if (bundle[i].Fresh == medium)
                {
                    Console.WriteLine(bundle[i].Name);
                }

            }
            Console.WriteLine();
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Высокий уровень свежести:");
            string high = "высокая свежесть";

            for (int i = 0; i < bundle.Length; i++)
            {
                if (bundle[i].Fresh == high)
                {
                    Console.WriteLine(bundle[i].Name);
                }

            }
            Console.WriteLine("*****************************************************");
            Console.WriteLine();
            Console.WriteLine("Диапазон длины стебел цветков:");
            Console.Write("Первый номер: "); int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второй номер: "); int numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*****************************************************");

            for (int i = 0; i < bundle.Length; i++)
            {
                if (bundle[i].Length >= numb1 && bundle[i].Length <= numb2)
                {
                    Console.WriteLine(bundle[i].Name);
                }
            }
            Console.WriteLine("*****************************************************");
        }
    }
}
