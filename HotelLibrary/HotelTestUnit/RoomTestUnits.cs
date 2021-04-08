using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelLibrary;
using System.IO;
using System;

namespace HotelTestUnit
{
    [TestClass]
    public class RoomTestUnits
    {
        [TestMethod]
        public void ConstructorTestMehtod()
        {
            var r145 = CreateTestRoom();
            Assert.AreEqual(145, r145.Number);
            Assert.AreEqual(2, r145.Beds);
            Assert.AreEqual(DirectionOfWindows.West, r145.WinDir);
            Assert.AreEqual(5000, r145.Price);
            Assert.AreEqual("17.10.2021", r145.WhenVacant.ToShortDateString());
            Assert.AreEqual("14:30:00", r145.WhenVacant.ToLongTimeString());
            
        }
        [TestMethod]
        public void ToStringTestMethod()
        {
            var r145 = CreateTestRoom();
            Assert.AreEqual("Номер: 145. Кол-во кроватей: 2.", r145.ToString());
        }
        [TestMethod]
        public void PrintInfoTestMethod()
        {
       
            var r145 = CreateTestRoom();
            var r256 = new Room(256, 3, DirectionOfWindows.South, 12000, "16.11.2021 12:45");
            var consoleOut = new[] { "Номер: 145. Кол-во кроватей: 2.", $"Окна: направлены на запад. Цена: 5000 руб./сутки. Номер будет свободен: 17.10.2021 14:30.", "Номер: 256. Кол-во кроватей: 3.", $"Окна: направлены на юг. Цена: 12000 руб./сутки. Номер будет свободен: 16.11.2021 12:45." };

  
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
        private Room CreateTestRoom()
        {
            return new Room(145, 2, DirectionOfWindows.West, 5000, "17.10.2021 14:30");
        }
    }
}
