using System;

namespace PRE_SELECTION.NET__part_2
{
    class Program
    {
        abstract class YandexTaxi
        {
            public string CarName;
            public double PricePerKM;
            int TravelDistance;
            int TravelTime;

            public YandexTaxi(string name, double price, int km, int min)
            {
                CarName = name;
                PricePerKM = price; 
                TravelDistance = km; 
                TravelTime = min;
            }

            public double TripPrice (double price, int km)
            {
                return price * km;
            }

            public void DisplayCar()
            {
                Console.WriteLine($"Car model: {CarName}  Price/km: {PricePerKM}  Travel distance: {TravelDistance} Travel time: {TravelTime}");
            }

        }

        class EconomCar : YandexTaxi
        {
            public int Discount { set; get; }
            public EconomCar (string name, double price, int km, int min, int discount) : base(name, price, km, min)
            {
                Discount = discount;
            }

            public double FinalPrice(double price, int discount, int km)
            {
                return (price * km) - (price * km * discount / 100);
            }

        }

        class LuxCar : YandexTaxi
        {
            public int CarRate { set; get; }
            public LuxCar(string name, double price, int km, int min, int lux_rate) : base(name, price, km, min)
            {
                CarRate = lux_rate;
            }

            public double FinalPrice (double price, int lux_rate, int km)
            {
                return price * km * lux_rate;
            }
        }

        class BigCar : YandexTaxi
        {
            public BigCar(string name, double price, int km, int min) : base(name, price, km, min)
            {

            }
        }

        class ChildCar : YandexTaxi
        {
            public ChildCar(string name, double price, int km, int min) : base(name, price, km, min)
            {

            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
