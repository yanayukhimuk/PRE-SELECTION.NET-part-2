using System;

namespace PRE_SELECTION.NET__part_2
{
    class Program
    {
        abstract class YandexTaxi
        {
            public string CarName;
            public double CarPrice;
            double FuelConsumption;

            public YandexTaxi(string name, double price, double fuel_cons)
            {
                CarName = name;
                CarPrice = price;
                FuelConsumption = fuel_cons;
            }
            public void DisplayCar()
            {
                Console.WriteLine($"Car model: {CarName}  Car price: {CarPrice}  Fuel consumption: {FuelConsumption}");
            }

        }

        class EconomCar : YandexTaxi
        {
            public double CarRate { set; get; }
            public int Discount { set; get; }
            public EconomCar(string name, double price, double fuel_cons, int discount) : base(name, price, fuel_cons)
            {
                Discount = discount;
            }

            public double FinalConsumption(double fuel_cons, int discount)
            {
                return fuel_cons * discount / 100;
            }

        }

        class LuxCar : YandexTaxi
        {
            public double CarRate { set; get; }
            public LuxCar(string name, double price, double fuel_cons, double lux_rate) : base(name, price, fuel_cons)
            {
                CarRate = lux_rate;
            }

            public double FinalCarPriceAcctoRate(double lux_rate, double price)
            {
                if (lux_rate >= 8 && lux_rate <= 10)
                {
                    Console.WriteLine("You have a luxury car!");
                    return price * lux_rate;
                }
                else if (lux_rate > 10 || lux_rate < 0)
                {
                    Console.WriteLine("Wrong rate has been enetered!");
                    return price * 0;
                }
                else
                {
                    Console.WriteLine("You have an econom car!s");
                    return price;
                }
            }
        }

        class ChildCar : YandexTaxi
        {
            bool ChildSeat { set; get; }
            public ChildCar(string name, double price, double fuel_cons, bool child_seat) : base(name, price, fuel_cons)
            {
                ChildSeat = child_seat;
            }
        }
        static void Main(string[] args)
        {
            EconomCar Reno = new EconomCar ("Pegeot_407", 5300, 10.1, 20);
            LuxCar Porsche = new LuxCar("Porsche Cayene", 20000, 25.2, 9.9);
            ChildCar childCar = new ChildCar("Renault", 4800, 6.2, true);

            double TotalPrice = Reno.CarPrice + Porsche.CarPrice + childCar.CarPrice;
            Console.WriteLine($"The total taxi price is: {TotalPrice}" );

            Console.WriteLine("The most economic car is: ");

        }
    }
}
