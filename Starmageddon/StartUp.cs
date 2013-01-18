using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Starmageddon
{
    public static class StartUp
    {
        public static void SetWindowTitle()
        {
            string s = "Starmageddon: ";
            Random rand = new Random();

            switch (rand.Next(1, 4))
            {
                case 1:
                    Console.Title = s + "A Text Adventure -- THROUGH SPACE!";
                    break;
                case 2:
                    Console.Title = s + "SPACE!";
                    break;
                case 3:
                    Console.Title = "Lobsterdog 2: Son of Lobsterdog";
                    break;
            }
        }

        public static void DisplayMainMenu()
        {

        }

        public static void SetConsoleDimensions()
        {
            Console.SetWindowSize(103, 40);
            Console.SetBufferSize(103, 40);
        }
    }
}
