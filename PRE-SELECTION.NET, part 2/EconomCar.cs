using System;

namespace PRE_SELECTION.NET__part_2
{
    class EconomCar : LuxCar
    {
        protected int Discount { set; get; }
        public EconomCar(string name, double price, double fuel_cons, int car_id, double lux_rate, int discount) : base(name, price, fuel_cons, car_id, lux_rate)
        {
            Discount = discount;
        }

        public double FinalConsumption(double fuel_cons, int discount)
        {
            return fuel_cons * discount / 100;
        }

        public new void DisplayTheCar()
        {
            DisplayCar();
            Console.WriteLine($"Car rate: {CarRate}  Discount: {Discount}");
        }
    }
}
