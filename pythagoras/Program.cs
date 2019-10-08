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

            Console.Write("Zadejte a: ");
            a = Console.ReadLine();
            Console.Write("Zadejte b: ");  
            b = Console.ReadLine();
            Console.Write("Zadejte c: ");
            c = Console.ReadLine();

            a_num = Convert.ToDouble(a);          
            b_num = Convert.ToDouble(b);
            c_num = Convert.ToDouble(c);

            result = (a_num * a_num) + (b_num * b_num) == c_num * c_num;
            Console.WriteLine("Je trojúhelník pravoúhlý?: " + result);
            
            result = (a_num + b_num > c_num) && (a_num + c_num > b_num) && (b_num + c_num > a_num);
            Console.WriteLine("Existuje takový trojúhelník?: " + result);

            Console.WriteLine("Stiskněte libovolné tlačítko pro ukončení.");
            Console.ReadKey();
        }
    }
}
