using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillfactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Vova";
            Console.WriteLine($"{myName}\n\tПривет, мир\n\tМне 27 лет\n\tMy name is\n {myName}");
            Console.WriteLine("Привет,\n мир");
            Console.WriteLine("\u0023");
            Console.ReadKey();
        }
    }
}
