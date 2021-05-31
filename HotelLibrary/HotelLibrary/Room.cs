using System;

namespace HotelLibrary
{
    public class Room
    {
        public readonly int RoomNumber; 
        public int BedsCount;
        public DirectionOfWindows WindowDirection;
        public int PricePerDay;
        public DateTime WhenVacant;

        public Room(int roomNumber, int bedsCount, DirectionOfWindows windowDirection)
        {
            RoomNumber = roomNumber;
            BedsCount = bedsCount;
            WindowDirection = windowDirection;
        }
        
        public override string ToString()
        {
            return $"Номер: {RoomNumber}. Кол-во кроватей: {BedsCount}.";
        }
        
        public virtual void PrintInfo()
        {
            Console.WriteLine(this);

            var windowDirection = "";
            switch (WindowDirection)
            {
                case DirectionOfWindows.East:
                    windowDirection = "восток";
                    break;
                case DirectionOfWindows.West:
                    windowDirection = "запад";
                    break;
                case DirectionOfWindows.North:
                    windowDirection = "север";
                    break;
                case DirectionOfWindows.South:
                    windowDirection = "юг";
                    break;
            }

            Console.WriteLine(
                $"Окна: направлены на {windowDirection}. " +
                $"Цена: {PricePerDay} руб./сутки. " +
                $"Номер будет свободен: {WhenVacant.ToShortDateString()} {WhenVacant.ToShortTimeString()}.");
        }

    }
}
