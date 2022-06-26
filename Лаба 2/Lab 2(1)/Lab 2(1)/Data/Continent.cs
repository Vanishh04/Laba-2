using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_1_.Data
{
    class Continent:Planet
    {
        public void Call()
        {
            Console.WriteLine("Класс Continent был вызван");
            Console.WriteLine();
        }

        public void NameofContinent()
        {
            var name = Enum.GetNames(typeof(Continent));

            Console.WriteLine("**** Список континентов планеты Земля: ****");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*******************************");
        }

        public void NumbofContinent()
        {
            var numbContinent = Enum.GetValues(typeof(Continent)).Length;
            Console.WriteLine($"Номера континентов планеты Земля: {numbContinent}");
            Console.WriteLine("*******************************");
            Console.WriteLine();
        }
    }
}
