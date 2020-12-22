﻿using System;

namespace Lab9
{
    class Triangle : Shape, IDraw
    {
        private string name;
        private double triangleSide;
        private double triangleBase;
        public double Side
        {
            get { return triangleSide; }
            set
            {
                if (value <= 0)
                {
                    triangleSide = 1;
                }
                else
                {
                    triangleSide = value;
                }
            }
        }

        public double Base
        {
            get { return triangleBase; }
            set
            {
                if (value <= 0)
                {
                    triangleBase = 1;
                }
                else
                {
                    triangleBase = value;
                }
            }
        }

        public override int NumOfVertices { get { return 3; } }

        public override string Name { get { return name; } }

        public override string FigureColor { get; set; }

        public Triangle(string name, string color, double side, double tBase)
        {
            this.name = name;
            FigureColor = color;
            Side = side;
            Base = tBase;
        }
        public Triangle(string name, double side, double tBase)
        {
            this.name = name;
            Side = side;
            Base = tBase;
            FigureColor = RandomColor.randomColor();
        }
        public Triangle(string name)
        {
            this.name = name;
            FigureColor = RandomColor.randomColor();
            Random r = new Random();
            Side = r.Next(100);
            Base = r.Next(100);
        }

        public override double Square()
        {
            double halfPerimeter = Perimeter() / 2;
            double S = Math.Sqrt(halfPerimeter * (halfPerimeter - Side) * (halfPerimeter - Side) * (halfPerimeter - Base));

            return S;
        }

        public override double Perimeter()
        {
            double P = Side * 2 + Base;
            return P;
        }

        public void Draw()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Имя: {0}\nКолор: {1}\nСторона: {2}\nОснование: {3}\nПлощадь: {4}\nПериметр: {5}",
                Name, FigureColor, Side, Base, Square(), Perimeter());
            Console.WriteLine();
    
            Console.WriteLine();
            Console.WriteLine("Ты долго пытался");
            Console.WriteLine("------------------------------");
        }


    }

}