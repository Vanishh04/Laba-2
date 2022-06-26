using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_1_.Data
{


    class Planet
    {
        public enum Continents
        {
            Euroasia, SouthernAmerica, Africa, Antarctida, Australia, NorthAmerica
        }

        public enum Oceans
        {
            Arctic, Indian, Atlantic, Pacific
        }

        public enum Islands
        {
            Cuba, Yava, Haiti, Cyprys
        }

        public string NameOfPlanet;

        public void NamePlanet()
        {
            Console.WriteLine($"Название планеты: {NameOfPlanet}");
            Console.WriteLine();
        }
        public void CreatePlanet()
        {
            Continent continent = new Continent();
            continent.Call();
            continent.NameofContinent();
            continent.NumbofContinent();

            Ocean ocean = new Ocean();
            ocean.Call();
            ocean.NameofOcean();
            ocean.NumbofOcean();

            Island island = new Island();
            island.Call();
            island.NameofIsland();
            island.NumbofIsland();

        }

        static void Main(string[] args)
        {
            Planet planet = new Planet();
            planet.NameOfPlanet = "Земля";
            planet.NamePlanet();
            planet.CreatePlanet();
        }


    }
}
