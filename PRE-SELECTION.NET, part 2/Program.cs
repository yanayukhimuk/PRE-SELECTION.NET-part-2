using System;

namespace PRE_SELECTION.NET__part_2
{
    class Program
    {
        interface YandexTaxi
        {
            void SetCarModel(string name);
            void SetPricePerKM(double price);

            void SetDistance(int km);
            void SetTripTime(int min);

            void SetArrivalTime(int h, int m, int s);
            void ShowCar();
        }
        static void Main(string[] args)
        {
            
        }
    }
}
