using System;

namespace HotelLibrary
{
    public class Room
    {
        public int Number;
        public int Beds;
        public DirectionOfWindows WinDir;
        public int Price;
        public DateTime WhenVacant;

        public Room(int number, int beds, DirectionOfWindows winDir, int price, string whenVacant)
        {
            Number = number;
            Beds = beds;
            WinDir = winDir;
            Price = price;
            WhenVacant = DateTime.Parse(whenVacant);
        }
        public override string ToString()
        {
            return $"Номер: {Number}. Кол-во кроватей: {Beds}.";
        }
        public void PrintInfo()
        {
            Console.WriteLine(this);

            var winDir = "";
            switch (WinDir)
            {
                case DirectionOfWindows.East:
                    winDir = "восток";
                    break;
                case DirectionOfWindows.West:
                    winDir = "запад";
                    break;
                case DirectionOfWindows.North:
                    winDir = "север";
                    break;
                case DirectionOfWindows.South:
                    winDir = "юг";
                    break;
            }

            Console.WriteLine($"Окна: направлены на {winDir}. Цена: {Price} руб./сутки. Номер будет свободен: {WhenVacant.ToShortDateString()} {WhenVacant.ToShortTimeString()}.");
        }

    }
}
