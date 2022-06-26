using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_1_.Data
{
    class Ocean : Planet
    {


        public void Call()
        {
            Console.WriteLine("Класс Ocean был вызван");
            Console.WriteLine();
        }

        public void NameofOcean()
        {
            var name = Enum.GetNames(typeof(Ocean));

            Console.WriteLine("**** Список океанов планеты Земля: ****");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***************************************");
        }

        public void NumbofOcean()
        {
            var numbOcean = Enum.GetValues(typeof(Ocean)).Length;
            Console.WriteLine($"Номера океанов планеты Земля: {numbOcean}");
            Console.WriteLine("***************************************");
        }
    }   
}
