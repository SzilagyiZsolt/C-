using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Schumacher
{
    internal class Program
    {
        static List<Schumi> adatok = new List<Schumi>();
        static void Main(string[] args)
        {
            adatokbeolvasása();
            feladatok3();
            feladatok4();
            feladatok5();
            Console.ReadKey();
        }

        private static void feladatok5()
        {
            Console.WriteLine("5. Feladat: Hibastatisztika");
            foreach (var item in adatok.FindAll(z=>z.Position==0).GroupBy(a =>a.Status).Select(b => new {hiba=b.Key, db=b.Count()}))
            {
                if (item.db>2)
                {
                    Console.WriteLine($"\t{item.hiba} : {item.db}");
                }
            }
        }

        private static void feladatok4()
        {
            Console.WriteLine("4. Feladat: Magyar nagydíj helyezései");
            foreach (var item in adatok.FindAll(a => a.Grandprix.Equals("Hungarian Grand Prix")&&a.Position>0))
            {
                Console.WriteLine($"\t{item.Date.ToShortDateString()} : {item.Position} hely");
            }
        }

        private static void feladatok3()
        {
            Console.WriteLine("3. Feladat");
            Console.WriteLine($"\t{adatok.Count} sort olvasott be");
        }

        private static void adatokbeolvasása()
        {
            try
            {
                using (StreamReader file= new StreamReader("schumacher.csv"))
                {
                    file.ReadLine();
                    while (!file.EndOfStream)
                    {
                        adatok.Add(new Schumi(file.ReadLine()));
                    }
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
