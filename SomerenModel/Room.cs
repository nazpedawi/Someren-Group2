using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public char BuildingName { get; set; }
        public string RoomType { get; set; }
        public int NumberOfBeds { get; set; }

        public Room(int roomNumber, char buildingName, string roomType, int numberOfBeds)
        {
            RoomNumber = roomNumber;
            BuildingName = buildingName;
            RoomType = roomType;
            NumberOfBeds = numberOfBeds;
        }
    }
}
