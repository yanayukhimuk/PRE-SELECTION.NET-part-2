using System;
using System.Collections.Generic;

namespace PRE_SELECTION.NET__part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            EconomCar Reno;
            LuxCar Porsche;
            ChildCar VWPolo;
            EconomCar Citroen;

            try
            {
                Reno = new EconomCar("Pegeot_407", 5300, 10.1, 1, 5.0, 20);
            }
            catch (YandexTaxiException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.Read();

            try
            {
                Porsche = new LuxCar("Porsche Cayene", 20000, 25.2, 2, 9.9);
            }
            catch (YandexTaxiException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.Read();

            try
            {
                VWPolo = new ChildCar("Renault", 4800, 6.2, 3, true);
            }
            catch (YandexTaxiException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.Read();

            try
            {
                Citroen = new EconomCar("Citroen C5", 4000, 7.8, 4, 5.0, 20);
            }
            catch (YandexTaxiException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.Read();


            List<YandexTaxi> TaxiCars = new List<YandexTaxi>() { Reno, Porsche, VWPolo, Citroen };

            double TotalPrice = 0.0;
            foreach (YandexTaxi car in TaxiCars)
            {
                TotalPrice += car.CarPrice;
            }

            Console.WriteLine($"The total taxi park price is: {TotalPrice}");

            foreach (YandexTaxi car in TaxiCars)
            {
                car.DisplayCar();
            }
            TaxiCars.Sort((car1, car2) => car1.FuelConsumption.CompareTo(car2.FuelConsumption));

            Console.WriteLine("Sorted cars: ");
            foreach (YandexTaxi car in TaxiCars)
            {
                car.DisplayCar();
            }

            Console.WriteLine("Enter the starting price: ");
            int StartPrice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the final price: ");
            int FinalPrice = int.Parse(Console.ReadLine());

            Console.WriteLine("Searching cars by price");
            foreach (YandexTaxi car in TaxiCars)
            {
                if (car.CarPrice >= StartPrice && car.CarPrice <= FinalPrice)
                {
                    car.DisplayCar();
                }

                else
                {
                    Console.WriteLine("No such cars!");
                }
            }


        }
    }
}
