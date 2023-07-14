using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    { 
        private string _name;
        private int _hp;
        private string _color;

        // Default Constructor
        public Car()
        {
            _name = "Car";
            _hp = 0;
            _color = "blue";
        }

        // Constructor
        public Car(string name, int hp = 0, string color = "black")
        {
            _name = name;
            Console.WriteLine(name + " was created.");
            _hp = hp;
            _color = color;
        }

        public void Drive()
        {
            Console.WriteLine(
               _name + " is driving");
        }

        public void Stop() {
            Console.WriteLine(_name + " is stopped");
        }

        public void Details() {
            Console.WriteLine("The " +_color + " car " + _name + " has " + _hp + " horse power.");
        }
    }
}
