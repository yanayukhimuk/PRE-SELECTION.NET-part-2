using System;

namespace PRE_SELECTION.NET__part_2
{
    class LuxCar : YandexTaxi
    {
        protected double CarRate { set; get; }
        public LuxCar(string name, double price, double fuel_cons, int car_id, double lux_rate) : base(name, price, fuel_cons, car_id)
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
        public void DisplayTheCar()
        {
            DisplayCar();
            Console.WriteLine($"Car rate: {CarRate}");
        }
    }
}
