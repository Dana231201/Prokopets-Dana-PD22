using System;
using System.Collections.Generic;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Shaxgarage myGarage = new Shaxgarage();
            Console.WriteLine("Привествую вас в гараже");
            int choice = 0;
            int cars = 0;
            while (choice != 10)
            {
                Console.WriteLine("В вашем гараже {0} машин . Введите 1 для добавления машини , 2 для удаления ",cars);
                Console.WriteLine("3 для того чтобы показать весь список машин , 4 для того чтобы фильтровать гараж , 10 для закрытия гаража");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    myGarage.AddNewCar();
                    cars += 1;
                }
                else if (choice == 2)
                {
                    myGarage.RemoveCar();
                    cars -= 1;
                    if(cars < 0)
                    {
                        cars = 0;
                    }
                }
                else if (choice == 3)
                {
                    myGarage.DisplayAllCars();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Okay, which characteristic would you like to find?");
                    char character;
                    Console.WriteLine("n - имя");
                    Console.WriteLine("c - цвет");
                    Console.WriteLine("s - скорость");
                    Console.WriteLine("y - год выпуска");
                    character = Convert.ToChar(Console.ReadLine());
                    myGarage.SearchByOneCharacteristic(character);
                }
            }
        }
    }
}