using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = "C:/Users/achock/Desktop/Holis.txt";
                string[] amiguis = new string[] { "Cosi", "Bebe" };
                using (StreamWriter sw = new StreamWriter(path))
                {

                    foreach (string amigo in amiguis)
                    {
                        sw.WriteLine("Hola " + amigo + "!");
                    }
                }
                //Mi archivo esta en desktop tons le puse desktop
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro el archivo:");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
