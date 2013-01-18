using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Starmageddon
{
    public class Room
    {
        string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public void LoadDescription()
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\Dane\Documents\GitHub\Starmageddon\Starmageddon\Rooms\Room1.txt"))
                {
                    /*while ((description = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(description);
                    }*/

                    description = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
