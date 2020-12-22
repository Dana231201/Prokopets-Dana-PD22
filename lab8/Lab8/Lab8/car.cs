using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    class car
    {
        public string Name { get; }
        public string Color { get; }
        public int Speed { get; }
        public int Year { get; }
        public car() { }
        public car(string name, string color, int speed, int year)
        {
            Name = name;
            Color = color;
            Speed = speed;
            Year = year;
        }
    }
}
