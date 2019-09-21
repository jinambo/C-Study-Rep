using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 1;
            int i, next, num;
            string n;

            Console.Write("Write n: ");
            
            n = Console.ReadLine();
            num = Convert.ToInt32(n);
            for (i = 0; num > i; i++) {
                if (num < 1) {
                    next = num;
                } else {
                    next = first + second;
                    first = second;
                    second = next;
                }

                Console.WriteLine(next);
            }


            Console.WriteLine("\nPress any key to end the program.");
            Console.ReadKey();

        }
    }
}
