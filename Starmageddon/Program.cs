using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Starmageddon
{
    class Program
    {
        static void Main(string[] args)
        {
            StartUp.SetWindowTitle();
            StartUp.SetConsoleDimensions();

            Level.InitializeLevel(2);

            Console.ReadLine();
        }
    }
}
