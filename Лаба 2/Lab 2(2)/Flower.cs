using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2_
{
     
    
        abstract class Flower
        {
            public abstract string Name { get; }
            public abstract int Price { get; }
            public int Length;
            public string Fresh;

            public void GetInfo()
            {
                Console.WriteLine("***********************");
                Console.WriteLine($"Вид цветка: {Name}");
                Console.WriteLine($"Цена: {Price} грн");
                Console.WriteLine($"Длина:{Length} см");
                Console.WriteLine($"Свежесть: {Fresh}");
                Console.WriteLine("***********************");
            }

        }
    
}
