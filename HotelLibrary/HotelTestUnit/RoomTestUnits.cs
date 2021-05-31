using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelLibrary;
using System.IO;
using System;
using System.Collections.Generic;

namespace HotelTestUnit
{
    [TestClass]
    public class RoomTestUnits
    {
        [TestMethod]
        public void ConstructorTestMehtod()
        {
            var r113 = new Room(113, 3, DirectionOfWindows.West);
            Assert.AreEqual(113, r113.RoomNumber);
            Assert.AreEqual(3, r113.BedsCount);
            Assert.AreEqual(DirectionOfWindows.West, r113.WindowDirection);
            
        }
        
        [TestMethod]
        public void ToStringTestMethod()
        {
            var r123 = new Room(123, 2, DirectionOfWindows.North);
            Assert.AreEqual("Номер: 123. Кол-во кроватей: 2.", r123.ToString());
        }
        
        [TestMethod]
        public void PrintInfoTestMethod()
        {
            var r145 = new Room(145, 2, DirectionOfWindows.West)
            {
                PricePerDay = 5000, 
                WhenVacant = DateTime.Parse("17.10.2021 14:30")
            };
            
            var r256 = new Room(256, 3, DirectionOfWindows.South)
            {
                PricePerDay = 12000, 
                WhenVacant = DateTime.Parse("16.11.2021 12:45")
            };
            
            var consoleOut = new[]
            {
                "Номер: 145. Кол-во кроватей: 2.",
                "Окна: направлены на запад. Цена: 5000 руб./сутки. Номер будет свободен: 17.10.2021 14:30.",
                "Номер: 256. Кол-во кроватей: 3.",
                "Окна: направлены на юг. Цена: 12000 руб./сутки. Номер будет свободен: 16.11.2021 12:45."
            };

            TextWriter oldOut = Console.Out; 
            StringWriter output = new StringWriter();
            Console.SetOut(output); 
            r145.PrintInfo();
            r256.PrintInfo();
            Console.SetOut(oldOut); 
            var outputArray = output.ToString().Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);


            Assert.AreEqual(4, outputArray.Length);
            for (var i = 0; i < consoleOut.Length; i++)
                Assert.AreEqual(consoleOut[i], outputArray[i]);
        }
    }
}
