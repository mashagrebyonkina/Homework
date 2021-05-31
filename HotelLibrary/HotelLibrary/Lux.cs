using System;
using System.Collections.Generic;

namespace HotelLibrary
{
    public class Lux : JuniorSuite
    {
        public int CountRooms;
        public int MinRentDuration;
        
        public Lux(
            int roomNumber, int bedsCount, DirectionOfWindows windowDirection, List<bool> calls, int countRooms, int minRentDuration) 
            : base(roomNumber, bedsCount, windowDirection, calls)
        {
            CountRooms = countRooms;
            MinRentDuration = minRentDuration;
        }

        public override void PrintInfo()
        {
            Console.WriteLine(this);
            Console.WriteLine(
                $"Количество комнат: {CountRooms}" + "\n" +
                $"Минимальная продолжительность аренды: {MinRentDuration}");
        }
    }
}