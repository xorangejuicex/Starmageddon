using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Starmageddon
{
    public static class Level
    {
        public static List<Room> theBuilding = new List<Room>();

        public static void InitializeLevel(int numOfRooms)
        {
            for (int x = 0; x < numOfRooms; x++)
            {
                Room room = new Room();

                theBuilding.Add(room);
                theBuilding[x].Description = LoadRoomDescription(x);

                Console.WriteLine(theBuilding[x].Description);
            }
        }

        private static string LoadRoomDescription(int roomNumber)
        {
            StreamReader sr = new StreamReader(@"Rooms/Room" + (roomNumber + 1) + ".txt");

            return sr.ReadToEnd();
        }
    }
}
