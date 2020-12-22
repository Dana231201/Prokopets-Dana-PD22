using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    class Shaxgarage
    {
        public List<car> myCars = new List<car>();
        public void AddNewCar()
        {
            string name;
            string color;
            int speed;
            int year;

            Console.Write("Введите имя машины: ");
            name = Console.ReadLine();

            Console.Write("Введите цвет машины: ");
            color = Console.ReadLine();

            Console.Write("Введите скорость машины: ");
            speed = int.Parse(Console.ReadLine());

            Console.Write("Введите год выпуска машины: ");
            year = int.Parse(Console.ReadLine());

            car newCar = new car(name, color, speed, year);

            myCars.Add(newCar);
        }

        public void RemoveCar()
        {
            int position;
            Console.Write("Введите номер машины в этом списке ");
            while (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > myCars.Count)
            {
                Console.Write("Под этим номером нет машин! Введите номер машины в этом списке: ");
            }
            myCars.RemoveAt(position - 1);
            Console.WriteLine("Машина под номером {0} была удалена", position);
        }
        public void DisplayAllCars()
        {
            int i = 1;
            foreach (car q in myCars)
            {
                DisplayInfoAboutCar(q);
                i++;
            }
        }
        public void SearchByOneCharacteristic(char character)
        {
            int i = 0;
            switch (character)
            {
                case 'n':
                    Console.Write("Какое название вы хотите найти? ");
                    string name = Console.ReadLine();

                    foreach (car q in myCars)
                    {
                        if (q.Name == name)
                        {
                            DisplayInfoAboutCar(q);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("К сожалению, совпадений не найдено");
                    i = 0;
                    break;

                case 'c':
                    Console.Write("Какой цвет вы хотите найти?");
                    string color = Console.ReadLine();
                    foreach (car q in myCars)
                    {
                        if (q.Color == color)
                        {
                            DisplayInfoAboutCar(q);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("К сожалению, совпадений не найдено");
                    i = 0;
                    break;

                case 's':
                    Console.Write("Какое имя вы хотите найти: ");
                    int speed = Convert.ToInt32(Console.ReadLine());
                    foreach (car q in myCars)
                    {
                        if (q.Speed == speed)
                        {
                            DisplayInfoAboutCar(q);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("К сожалению, совпадений не найдено");
                    i = 0;
                    break;

                case 'y':
                    Console.Write("Какое имя вы хотите найти: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    foreach (car q in myCars)
                    {
                        if (q.Year == year)
                        {
                            DisplayInfoAboutCar(q);
                            i++;
                        }
                    }
                    if (i == 0) Console.WriteLine("К сожалению, совпадений не найдено");
                    i = 0;
                    break;

                default:
                    Console.WriteLine("Такой характеристики нет");
                    break;
            }

        }
        public void DisplayInfoAboutCar(car car)
        {
            Console.WriteLine("\nИмя  : {0}\nЦвет  : {1}\nСкорость  : {2}\nГод  : {3}", car.Name, car.Color, car.Speed, car.Year);
        }
    }
}
