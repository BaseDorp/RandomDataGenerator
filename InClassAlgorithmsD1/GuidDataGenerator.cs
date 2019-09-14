using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

namespace InClassAlgorithmsD1
{
    public class GuidDataGenerator
    {
        public List<Guid> myGuids;
        public List<double> myDoubles;

        public GuidDataGenerator()
        {
            // Creates list of Guids
            myGuids = new List<Guid>();
            myDoubles = new List<double>();
            Random random = new Random();

            
            // Gets 1 milion guids -----------------------------------------------------------------
            for (int i = 0; i < 1000000; i++)
            {
                // Get a random Guid
                myGuids.Add(Guid.NewGuid());
                // Get random double
                myDoubles.Add(random.NextDouble());
            }

            // Prints to screen -------------------------------------------------------------------
            
            for (int i = 0; i < myGuids.Count; i++)
            {
                Console.Write(i + ", " + myGuids[i] + ", " + myDoubles[i] + "\n");
            }

            // Create txt document --------------------------------------------------------------
            string filePath = Directory.GetCurrentDirectory();
            // takes the current directory that the project is in, and creates a txt file
            filePath += @"\DataText.txt";

            StreamWriter sw = new StreamWriter(filePath);

            for (int i = 0; i < myGuids.Count; i++)
            {
                sw.Write("{0}. {1}, {2}\n", i, myGuids[i], myDoubles[i]);
            }
            
        }
    }
}
