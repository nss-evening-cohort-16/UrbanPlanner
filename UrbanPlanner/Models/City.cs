using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner.Models
{
    class City
    {
        public City(string name, string mayor)
        {
            Name = name;
            Mayor = mayor;
        }

        //name, mayor, yearEstablished, collection of buildings, method to add building
        private int _yearEstablished = DateTime.Now.Year;
        
        public string Name { get; set; }
        public string Mayor { get; set; }
        public List<Building> Buildings { get; set; } = new List<Building>();

        public void AddBuilding(Building building)
        {
            //stub out your class - put the methods you're going to need, but don't have any code in them yet
            //TODO - define method logic
            //throw new NotImplementedException("The AddBuilding method is not yet defined.");

            Buildings.Add(building);
        }

        public void AddBuilding(string address, double width, int stories, double depth)
        {
            //if (Buildings == null)
            //{
            //    Buildings = new List<Building>();
            //}

            var building = new Building(address, width, stories, depth);
            Buildings.Add(building);
        }

        public void ListBuildings()
        {
            foreach (var building in Buildings)
            {
                building.PrintToConsole();
            }
        }

        public void PrintToConsole()
        {
            Console.WriteLine($@"
City Name: {Name}
Mayor: {Mayor}
Year Established: {_yearEstablished}");

        }

    }
}
