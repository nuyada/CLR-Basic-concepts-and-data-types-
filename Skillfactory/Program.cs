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
            int myAge = 19;
            bool HaveIApet = true;
            double MyShoeSize = 44.5;
            //Console.WriteLine($"{myName}\n\tПривет, мир\n\tМне 27 лет\n\tMy name is\n {myName}");
            //Console.WriteLine("Привет,\n мир");
            //Console.WriteLine("\u0023");
            Console.WriteLine($"My name is {myName}\nMy age is {myAge}\nDo I have a pet? {HaveIApet}\nMy shoe size is {MyShoeSize}");
            Console.ReadKey();
        }
    }
}
