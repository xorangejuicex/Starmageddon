using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Starmageddon
{
    public static class Level
    {
        public static Room[,] room = new Room[2, 2];

        public static void InitializeRooms(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    room[i, j] = new Room();
                }
            }

            LoadRoomDescriptions();

            Console.WriteLine(room[1, 0].Description);
            Console.WriteLine(room[1, 1].Description);
        }

        private static void LoadRoomDescriptions()
        {
            StreamReader sr = new StreamReader(@"Rooms/RoomDescriptions.txt");

            while (!sr.EndOfStream)
            {
                string str = sr.ReadLine();
                string[] arr = str.Split('\t');

                int x = Convert.ToInt32(arr[0]);
                int y = Convert.ToInt32(arr[1]);

                room[x, y].Description = Convert.ToString(arr[2]);
            }
        }
    }
}
