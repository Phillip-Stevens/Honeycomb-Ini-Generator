using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexagon_Ini_Generator
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Program Start!");

                FileHandler handler = new FileHandler();

                handler.FileRead(@"C:\Users\philt\Documents\Rainmeter\Skins\Honeycomb\Template ini.txt");

                Console.ReadKey();

                handler.ReplaceText("PROGRAMNAME", "TEST");

                handler.CreateFile();
        }
    }
}
