using System;

namespace PRE_SELECTION.NET__part_2
{
    abstract class YandexTaxi
    {
        public string CarModelName { set; get; }
        public double CarPrice { set; get; }
        public int CarId { set; get; }
        public double FuelConsumption { set; get; }


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
