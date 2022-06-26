using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_2_
{
     class Chamomille:Flower
    {
        public override string Name { get { return "Ромашка"; } }

        public override int Price { get { return 51; } }

        public Chamomille(int length, string fresh)
        {
            Length = length;
            Fresh = fresh;
        }
    }
}
