using System;

namespace PRE_SELECTION.NET__part_2
{
    class ChildCar : YandexTaxi
    {
        bool ChildSeat { set; get; }
        public ChildCar(string name, double price, double fuel_cons, int car_id, bool child_seat) : base(name, price, fuel_cons, car_id)
        {
            ChildSeat = child_seat;
        }
        public void DisplayTheCar()
        {
            DisplayCar();
            Console.WriteLine($"ChildSeat: {ChildSeat}");
        }
    }
}
