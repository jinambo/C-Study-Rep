using System;

namespace testik
{
    class Kokot {
        public string Jmeno;
        public double Vek;

        public Kokot(string Jmeno, double Vek) {
            this.Jmeno = Jmeno;
            this.Vek = Vek;
        }

        public string Vrat() {
            return Jmeno + ", " + Vek;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kokot kokot0 = new Kokot("Kamil", 21);
            Kokot kokot1 = new Kokot("", 0);

            if(kokot0.Vek > 18) {
                kokot1 = kokot0;
            }

            Console.WriteLine(kokot0.Vrat() + " : " + kokot1.Vrat());

            /* 
            double[] pole = new double[30];

            for(int i = 0; i < pole.Length; i++) {
                pole[i] = Math.Pow(2, i);
            }

            for(int i = 0; i < pole.Length; i++) {
                Console.WriteLine(pole[i]);
            }
            

            int[] pole1 = {3, 5, 7, 9};
            int[] pole2 = new int[4];

            int j = pole1.Length;

            for(int i = 0; i < pole1.Length; i++) {
                j--;
                pole2[i] = pole1[j]; 

                Console.WriteLine(pole2[i]);
            }
            */

            int[] pole1 = {3, 5, 7, 9};
            int[] pole2 = {3, 5, 7, 12};

            int poleSoucet1 = 0;
            int poleSoucet2 = 0;

            for (int i = 0; i < pole1.Length; i++) {
                poleSoucet1 = poleSoucet1 + pole1[i];
                poleSoucet2 = poleSoucet2 + pole2[i];
            }

            if (poleSoucet1 > poleSoucet2) {
                Console.WriteLine("pole1 je vetsi nez 2");
            } else {
                Console.WriteLine("pole1 neni vetsi nez 2");
            }



            Console.ReadKey();

        }
    }
}
