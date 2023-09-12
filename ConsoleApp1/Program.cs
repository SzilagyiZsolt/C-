using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //két szám bekérése és összeadása
            int elso, masodik; //deklarálás
            Console.WriteLine("Két szám összeadása");
            Console.WriteLine("A továbbhaladáshoz adj meg egy számot majd nyomd meg az entert");
            elso=int.Parse(Console.ReadLine());
            Console.WriteLine("A továbbhaladáshoz adj meg egy másik számot majd nyomd meg az entert");
            masodik=int.Parse(Console.ReadLine());
            Console.WriteLine("A két szám összege: " +(elso+masodik).ToString());
            Console.WriteLine("A program bezárásához nyomd meg az entert");
            Console.ReadKey();
        }
    }
}
