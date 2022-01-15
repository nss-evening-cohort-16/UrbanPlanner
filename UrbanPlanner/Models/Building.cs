using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner.Models
{
    class Building
    {
        //overloading - multiple methods with same name but different signatures
        //constructor method - same name and return type as the class
        public Building()
        {

        }
        public Building(string address)
        {
            _address = address;
            //_designer = "Brian Neal";
        }

        public Building(string address, double width, int stories, double depth)
        {
            _address = address;
            Width = width;
            Stories = stories;
            Depth = depth;
        }

        //fields
        private string _designer = "Brian Neal";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        
        //properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get => Width * Depth * (3 * Stories);
        }
        public City City { get; set; }

        //methods
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string name)
        {
            _owner = name;
        }
        public void PrintToConsole()
        {
            //@ - string verbatim - will take every keystroke literally including new lines (Enter key)
            string output = $@"
{_address}-------------
Designed by {_designer}
Constructed on {_dateConstructed}
Owned by {_owner}
{Volume} cubic meters of space";
            
            Console.WriteLine(output);
        }
    }
}
