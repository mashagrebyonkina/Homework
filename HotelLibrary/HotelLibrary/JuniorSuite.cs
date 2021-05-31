using System;
using System.Collections.Generic;

namespace HotelLibrary
{
    public class JuniorSuite : Room
    {
        public bool Wash, BookingTable, CleanUp, OrderTaxi;

        public JuniorSuite(int roomNumber, int bedsCount, DirectionOfWindows windowDirection, List<bool> calls) 
            : base(roomNumber, bedsCount, windowDirection)
        {
            Wash = calls[0];
            BookingTable = calls[1];
            CleanUp = calls[2];
            OrderTaxi = calls[3];
        }

        public override void PrintInfo()
        {
            Console.WriteLine(this);
            Console.WriteLine(
                "Статус доплнительных услуг:" + "\n" +
                "------------------------------------------------------------------------" + "\n" +
                $"Стирка вещей: {GetAnswer(Wash)}" + "\n" +
                $"Бронирование стола в ресторане: {GetAnswer(BookingTable)}" + "\n" +
                $"Чистка комнаты: {GetAnswer(CleanUp)}" + "\n" +
                $"Заказ такси: {GetAnswer(OrderTaxi)}");
            
            string GetAnswer(bool service) => service ? "назначено" : "не назначено";
        }
    }
}