using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract7_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            string result;
            Console.WriteLine(" Напишите строку: ");
            str = Console.ReadLine();
            if (str.Length % 2 != 0) 
                result = str.Remove((str.Length / 2), 1); 
            else
                result = str.Remove((str.Length / 2) - 1, 2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
