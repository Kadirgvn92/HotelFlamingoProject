using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainEnterance
{
    internal class Room
    {
        public int RoomNumber { get; set; }
        public string IsFree { get; set; } // Odanın durumunu temsil eder (true: boş, false: dolu)

        public Room(int roomNumber, string isFree)
        {
            RoomNumber = roomNumber;
            IsFree = isFree;
        }
    }
}
