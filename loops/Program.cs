using System;

namespace loops {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("\n------------------------------------");
            // posloupnosti
            int j;
            for (j = 0; j <= 4; j++) {
                Console.Write("{0}, ", j);
            }

            Console.WriteLine("\n");

            for (j = 10; j <= 14; j++) {
                Console.Write("{0}, ", j);
            }

            Console.WriteLine("\n");

            for (j = 100; j >= 96; j--) {
                Console.Write("{0}, ", j);
            }

            Console.WriteLine("\n");

            for (j = 10; j <= 1000000; j = j * 10) {
                Console.Write("{0}, ", j);
            }

            Console.WriteLine("\n");

            for (j = 256; j >= 16; j = j / 2) {
                Console.Write("{0}, ", j);
            }

            Console.WriteLine("\n");

            // lichá čísla v intervalu 10 - 100
            for (j = 10; j <= 100; j++) {
                if (j % 2 != 0) {
                    Console.Write(j + ", ");
                }
            }

            Console.WriteLine("\n");

            // sudá čísla v intervalu 10 - 100
            for (j = 10; j <= 100; j++) {
                if (j % 2 == 0) {
                    Console.Write(j + ", ");
                }
            }

            Console.WriteLine("\n");

            // dělitelná čísla (3, 5) v intervalu 10 - 100
            for (j = 10; j <= 100; j++) {
                if (j % 3 == 0 || j % 5 == 0) {
                    Console.Write(j + ", ");
                }
            }

            Console.WriteLine("\n------------------------------------\n");

            // enter game
            int i;
            int pokusy = 3;

            Console.WriteLine("Sup bro? Do you wanna play game?\n\nPress the magic key.");

            for (i = 0; i < pokusy; i++) {
                if (Console.ReadKey().Key != ConsoleKey.Enter) {
                    Console.WriteLine(" - " + (i + 1) + " chances left..");
                } else {
                    i = pokusy;
                    Console.WriteLine("Nice, you have pressed the <enter>. Well done. You must be really smart.");
                }
            }

            if(i == pokusy) {
                Console.WriteLine("You have failed. Game over.");
            }

            Console.WriteLine("\n------------------------------------");

            // faktorial
            int n;
            int f = 1;
            for(n = 2; n < 10; n++) {
                Console.Write((f *= n) + ", ");
            }

            Console.WriteLine("\n------------------------------------");

            // mocnina
            int x = 2;
            int mocnina = 2;
            for (int k = 1; k < 10; k++) {
                Console.Write((mocnina *= x) + ", ");
            }

            Console.WriteLine("\n------------------------------------\n");
            Console.ReadKey();
        }
    }
}
