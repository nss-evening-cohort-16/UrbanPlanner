using System;
using UrbanPlanner.Models;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = new City("Gotham", "Batman");
            //city.ListBuildings();

            //instantiate - use the 'new' keyword to create an instance of an object
            //initialize - give an instance an initial value
            Building oneTwoThree = new Building("123 Main Street");
            oneTwoThree.Width = 5;
            oneTwoThree.Stories = 2;
            oneTwoThree.Depth = 10;
            //city.AddBuilding(oneTwoThree);

            city.AddBuilding("123 Main Street", 5, 2, 10);

            foreach (var building in city.Buildings)
            {
                building.PrintToConsole();
            }

            city.Buildings.ForEach(b => b.PrintToConsole());

            //oneTwoThree.Volume = 1; public property, but no setter makes it readonly. Cannot be set in code outside the class/constructor

            Building fourFiveSix = new Building("456 Main Street")
            {
                Width = 7,
                Depth = 4,
                Stories = 3
            };


            Building differentOne = new("1023 Something Avenue")
            {
                Width = 6,
                Depth = 15,
                Stories = 1
            };


            Building sherlocksPlace = new Building("221B Baker Street")
            {
                Width = 10,
                Depth = 10,
                Stories = 10
            };
            //oneTwoThree._dateConstructed = DateTime.Now;  private, not accessible
            oneTwoThree.Construct();
            fourFiveSix.Construct();
            sherlocksPlace.Construct();
            differentOne.Construct();
            
            oneTwoThree.Purchase("Scrooge McDuck");

            city.AddBuilding(oneTwoThree);
            city.AddBuilding(fourFiveSix);
            city.AddBuilding(sherlocksPlace);
            city.AddBuilding(differentOne);
            city.ListBuildings();
            //oneTwoThree.PrintToConsole();
            Console.ReadLine();
            


        }
    }
}
