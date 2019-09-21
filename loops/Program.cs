using System;

namespace loops {
    class Program {
        static void Main(string[] args) {
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

            // faktorial
            int n;
            int f = 1;
            for(n = 2; n < 10; n++) {
                Console.WriteLine(f *= n);
            }

            // mocnina
            int x = 2;
            int mocnina = 2;
            for (int k = 1; k < 10; k++) {
                Console.WriteLine("\n" + (mocnina *= x));
            }

            Console.ReadKey();
        }
    }
}
