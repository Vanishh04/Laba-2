using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2_
{
    class Lily:Flower
    {
        public override string Name { get { return "Лилия"; } }

        public override int Price { get { return 28; } }

        public Lily(int length, string fresh)
        {
            Length = length;
            Fresh = fresh;
        }
    }
}
