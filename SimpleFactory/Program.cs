using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = 100;
            double number2 = 10;

            Console.WriteLine(Factory.GetInstance("+").Result(number1, number2));
            Console.WriteLine(Factory.GetInstance("-").Result(number1, number2));
            Console.WriteLine(Factory.GetInstance("*").Result(number1, number2));
            Console.WriteLine(Factory.GetInstance("/").Result(number1, number2));

            Console.Read();
        }
    }
}
