using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравей, как си!");
            
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var s = (a + b) / 2 * h;
            Console.WriteLine(s);



        }
    }
}
