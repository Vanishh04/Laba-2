using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_1_.Data
{
     class Island:Planet
    {
        public void Call()
        {
            Console.WriteLine();
            Console.WriteLine("Класс Island был вызван");
        }

        public void NameofIsland()
        {
            var name = Enum.GetNames(typeof(Island));

            Console.WriteLine("**** Список островов планеты Земля: ****");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****************************************");
        }

        public void NumbofIsland()
        {
            var numbIsland = Enum.GetValues(typeof(Island)).Length;
            Console.WriteLine($"Номера островов планеты Земля: {numbIsland}");
            Console.WriteLine("****************************************");
        }
    }
}
