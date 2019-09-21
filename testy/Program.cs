using System;

namespace testy
{
    class Program
    {
        static void Main(string[] args)
        {
            double t1 = 46.0;
            double t2 = 77.0;
            double t3 = 85.0;
            bool result;

            result = t1 > 45.00 || t2 > 45.00 || t3 > 45.00;
            Console.WriteLine("\n\nAt least one test got more than 45 points. -> " + result);

            result = t1 > 45.00 && t2 > 45.00 && t3 > 45.00;
            Console.WriteLine("Each test got more than 45 points. -> " + result);

            result = ((t1 > 45.0) && (t2 > 45.0)) || ((t1 > 45.0) && (t3 > 45.0)) || ((t2 > 45.0) && (t3 > 45.0));
            Console.WriteLine("At least two tests got more than 45 points. -> " + result);

            if (t1 > t2 && t1 > t3) {
                Console.WriteLine(t1);
                if (t2 > t3) {
                    Console.WriteLine(t2);
                } else {
                    Console.WriteLine(t3);
                }
            } else if (t2 > t1 && t2 > t3) {
                Console.WriteLine(t2);
                if (t1 > t3) {
                    Console.WriteLine(t1);
                } else {
                    Console.WriteLine(t3);
                }
            } else {
                Console.WriteLine(t3);
                if (t1 > t2) {
                    Console.WriteLine(t1);
                } else {
                    Console.WriteLine(t2);
                }
            }

            Console.ReadKey();
        }
    }
}
