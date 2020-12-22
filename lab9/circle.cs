using System;

namespace Lab9
{
    class Circle : Shape, IDraw
    {
        private double circleRadius;
        private string name;
        public double Radius
        {
            get { return circleRadius; }
            set
            {
                if (value <= 0)
                {
                    circleRadius = 1;
                }
                else
                {
                    circleRadius = value;
                }
            }
        }

        public override int NumOfVertices { get { return 0; } }

        public override string Name { get { return name; } }

        public override string FigureColor { get; set; }

        public Circle(string name, string color, double radius)
        {
            this.name = name;
            FigureColor = color;
            Radius = radius;
        }
        public Circle(string name, double radius)
        {
            this.name = name;
            Radius = radius;
            FigureColor = RandomColor.randomColor();
        }
        public Circle(string name)
        {
            this.name = name;
            FigureColor = RandomColor.randomColor();
            Random r = new Random();
            Radius = r.Next(100);
        }

        public override double Square()
        {
            double S = Math.PI * Math.Pow(Radius, 2);
            return S;
        }

        public override double Perimeter()
        {
            double P = 2 * Math.PI * Radius;
            return P;
        }

        public void Draw()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Имя: {0}\nЦвет: {1}\nРадиус: {2}\nПлощадь: {3}\nПериметр: {4}",
                Name, FigureColor, Radius, Square(), Perimeter());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Почти круг");
            Console.WriteLine("-------------------------------------");
        }


    }

}