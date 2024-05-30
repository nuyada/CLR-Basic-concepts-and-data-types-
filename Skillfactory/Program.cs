using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Skillfactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите свой возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Тебя зовут {name} и тебе {age} лет");
            Console.Write("Введите свою дату рождения: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine($"Твое др {birthdate}");
            Console.ReadKey();

        }

    }
}
