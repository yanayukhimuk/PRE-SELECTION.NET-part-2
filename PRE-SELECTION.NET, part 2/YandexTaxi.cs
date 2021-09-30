using System;

namespace PRE_SELECTION.NET__part_2
{
    abstract class YandexTaxi
    {

        private readonly double price;
        private readonly int id;
        private readonly double fuel_cons;
        public string CarModelName { set; get; }

        public double CarPrice
        {
            set
            {
                if (value < 0)
                {
                    throw new YandexTaxiException("The price can't be negative!");
                }
                else
                    CarPrice = price;
            }

            get
            {
                return price;
            }

        }
        public int CarId
        {
            set
            {
                if (value < 0)
                {
                    throw new YandexTaxiException("The ID can't be negative!");
                }
                else
                    CarId = id;
            }

            get
            {
                return id;
            }

        }
        public double FuelConsumption
        {
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new YandexTaxiException("The invalid fuel consumption!");
                }
                else
                    FuelConsumption = fuel_cons;
            }

            get
            {
                return fuel_cons;
            }

        }

        public YandexTaxi() { }
        public YandexTaxi(string name, double price, double fuel_cons, int car_id)
        {
            CarModelName = name;
            CarPrice = price;
            FuelConsumption = fuel_cons;
            CarId = car_id;
        }
        public void DisplayCar()
        {
            Console.WriteLine($" Car ID: {CarId} Car model: {CarModelName}  Car price: {CarPrice}  Fuel consumption: {FuelConsumption}");
        }

    }
}
