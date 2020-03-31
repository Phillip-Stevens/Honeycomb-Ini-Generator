using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hexagon_Ini_Generator
{
    class FileHandler
    {
        public string fileText
        { get; set; }

        public string iniOutput
        { get; set; }

        public string docPath
        { get; set; }


        public void FileRead(string filePath)
        {
            // Read File in
            Console.WriteLine("Reading in the file...");
            string[] lines = System.IO.File.ReadAllLines(filePath);

            // read in all the text and put it on new lines (if needed)
            foreach (string line in lines)
            {
                fileText += (line + "\n");
            }

            Console.WriteLine("File Read Complete! \n");

            // Output all text
            DisplayOutput();

            return;
        }

        public void ReplaceText(string toReplace, string replaceWith)
        {
            fileText = fileText.Replace(toReplace, replaceWith);
            Console.Clear();

            Console.WriteLine("File Read Complete! \n\n");

            // Output all text
            DisplayOutput();
            return;
        }

        public void DisplayOutput()
        {
            // Output all text
            Console.Write(fileText + "...\n\n");
            return;
        }

        public void CreateFile()
        {
            // Setup File Creation location
            docPath = @"C:\Users\philt\Documents\Rainmeter\Skins\Honeycomb\Generated";
            System.IO.Directory.CreateDirectory(docPath);

            string fileName = "test.txt";

            docPath = System.IO.Path.Combine(docPath, fileName);

            //Write to file
            if (!System.IO.File.Exists(docPath))
            {
                using (System.IO.StreamWriter fs = new System.IO.StreamWriter(docPath))
                {
                    fs.WriteLine(fileText);
                    fs.Close();
                }

            }
            else
            {
                Console.WriteLine("ERROR: File already exists.", fileName);
                return;
            }

            Console.WriteLine("File Creation Complete! \n\n");

            // Create file
            return;
        }
    }
}
