using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    internal class Car
    {
        // access modifier private
        private string _name;
        private int _hp;
        private string _color;
        private int _maxSpeed;

        public int MaxSpeed { 
            set
            {
                _maxSpeed = value;
            } 
        } 

        // the public property
        public string Name { 
            get { return _name; } // get accessor
            set { _name = value; }  // set accessor
        }

        // Default Constructor
        public Car()
        {
            _name = "Car";
            _hp = 0;
            _color = "blue";
            _maxSpeed= 150;
        }

        //Partial Constructor
        public Car(string name, int hp = 0)
        {
            _name = name;
            Console.WriteLine(name + " was created.");
            _hp = hp;
            _color = "red";
        }

        // Full Specification Constructor

        public Car(string name, int hp, string color)
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
