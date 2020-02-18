using System;

namespace Test {
    
    struct Pixel {
        public int R;
        public int G;
        public int B;

        public Pixel(int R, int G, int B) {
            this.R = R;
            this.G = G;
            this.B = B;
        }

        public int sectiHodnoty() {
            int soucet = R + G + B;
            return soucet;
        }
    }


    class Program {
        static void Main(string[] args) {
            Random rnd = new Random();
            var polePixel = new Pixel[] { };

            for(int j = 0; j <= 10; j++) {
                polePixel[i] = new Pixel(Random(rnd.Next(0, 255)), Random(rnd.Next(0, 255)), Random(rnd.Next(0, 255)));
            }

            int min = polePixel[0].sectiHodnoty();
            int max = polePixel[0].sectiHodnoty();
            Pixel nejmensi = new Pixel();
            Pixel nejvetsi = new Pixel();

            for (int i = 0; i < polePixel.Length; i++) {

                // Nejmenší pixel v poli (nejtmavší)
                if (polePixel[i].sectiHodnoty() < min) {
                    min = polePixel[i].sectiHodnoty();
                    nejmensi = polePixel[i];
                }

                // Největší pixel v poli (nejtmavší)
                if (polePixel[i].sectiHodnoty() > max) {
                    max = polePixel[i].sectiHodnoty();
                    nejvetsi = polePixel[i];
                }

                // Vypíše černý pixel
                if (polePixel[i].sectiHodnoty() == 0) {
                    Console.WriteLine("Černý pixel: RGB(" + polePixel[i].R + ", " + polePixel[i].G + ", " + polePixel[i].B + ").");
                }
            }

            Console.WriteLine("Nejmenší tedy nejtmavší pixel v poli: RGB(" + nejmensi.R + ", " + nejmensi.G + ", " + nejmensi.B + ").");
            Console.WriteLine("Největší tedy nejsvětlejší pixel v poli: RGB(" + nejvetsi.R + ", " + nejvetsi.G + ", " + nejvetsi.B + ").");

            Console.ReadKey();
        }
    }
}