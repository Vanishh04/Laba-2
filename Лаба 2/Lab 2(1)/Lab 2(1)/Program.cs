using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2_1_.Data;

namespace Lab_2_1_
{
     class Program
    {
        static void Main(string[] args)
        {
            Planet planet = new Planet();
            planet.NameOfPlanet = " Земля ";
            planet.NamePlanet();
            planet.CreatePlanet();
        }
    }
}
