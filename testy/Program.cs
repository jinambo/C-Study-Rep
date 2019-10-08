using System;

namespace testy
{
    class Program
    {
        static void Main(string[] args)
        {
            double t1 = 16.0;
            double t2 = 21.0;
            double t3 = 21.0;
            bool result;

            result = t1 > 15.00 || t2 > 15.00 || t3 > 15.00;
            Console.WriteLine("\n\nAspon jeden test byl splněn. -> " + result);

            result = t1 > 15.00 && t2 > 15.00 && t3 > 15.00;
            Console.WriteLine("Všechny testy byly splněny. -> " + result);

            result = ((t1 > 15.0) && (t2 > 15.0)) || ((t1 > 15.0) && (t3 > 15.0)) || ((t2 > 15.0) && (t3 > 15.0));
            Console.WriteLine("Aspon dva testy byly splněny. -> " + result);

            // vypise dve nejlepsi testy
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
