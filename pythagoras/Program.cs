using System;

namespace pythagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c; 
            double a_num, b_num, c_num;
            bool result;

            Console.WriteLine("Hello, welcome to the pythagoras.\n");

            Console.Write("Set a: ");
            a = Console.ReadLine();
            Console.Write("Set b: ");  
            b = Console.ReadLine();
            Console.Write("Set c: ");
            c = Console.ReadLine();

            a_num = Convert.ToDouble(a);          
            b_num = Convert.ToDouble(b);
            c_num = Convert.ToDouble(c);

            result = (a_num * a_num) + (b_num * b_num) == c_num * c_num;
            Console.WriteLine("Is it rectangular? (True ano, False ne): " + result);
            
            result = (a_num + b_num > c_num) && (a_num + c_num > b_num) && (b_num + c_num > a_num);
            Console.WriteLine("Does the triangle exist? (True ano, False ne): " + result);

            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}
