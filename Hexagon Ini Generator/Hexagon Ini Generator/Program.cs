using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexagon_Ini_Generator
{
    class Program
    {
        public string itemEntered
        { get; set; }

        public string[] replaceItems
        { get; set; }

        static void Main(string[] args)
        {

            Console.WriteLine("Program Start!");

            // Create File Handler which reads file in
            FileHandler handler = new FileHandler();

            Console.ReadKey();

            handler.ReplaceText("PROGRAMNAME", "TEST");

            handler.CreateFile();

            // Plan is to create a loop here that will one by one loop over asking set questions via a for loop.
        }
    }
}
