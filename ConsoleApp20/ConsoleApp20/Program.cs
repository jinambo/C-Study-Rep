using System;

namespace Test
{
    class Program
    {
        class Kruh
        {
            public double r;

            public Kruh(double r)
            {
                this.r = r;
            }

            public double Obvod()
            {
                return Math.Round(2 * Math.PI * r, 2);
            }

            public double Obsah()
            {
                return Math.Round(Math.PI * (r * r), 2);
            }

        }

        static void Main(string[] args)
        {
            Kruh k1 = new Kruh(4);
            Kruh k2 = new Kruh(5.1);

            Console.WriteLine("Obvod k1: " + k1.Obvod() + ", obsah k1: " + k1.Obsah());

            if (k1.Obvod() == k2.Obvod()) {
                Console.WriteLine("Kruh k1 ma stejny obvod jako kruh k2.");
            } else
            {
                Console.WriteLine("Kruh k1 nema stejny obvod jako kruh k2.");
            }

            Console.ReadKey();
        }
    }
}