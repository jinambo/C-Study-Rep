using System;

namespace structcode {
    class Test {
        public int x, y, soucet;
        // constructor
        public Test(int x, int y) {
            this.x = x;
            this.y = y;
            this.soucet = x + y;
        }

        public int zmen(int zmenaX) {
            this.x = zmenaX;
            return x;
        }

        public int secti(int soucetX, int soucetY) {
            int soucet = soucetX + soucetY;
            return soucet;
        }
    }

    // struct vs class
    struct rozdilStr {
        public int a, b;
        public rozdilStr(int a, int b) {
            this.a = a;
            this.b = b;
        }
    }
    class rozdilCls {
        public int a, b;
        public rozdilCls(int a, int b) {
            this.a = a;
            this.b = b;
        }
    }
    class Program {
        static void Main(string[] args) {
            Test p = new Test(5,3);
            p.zmen(7);
            Console.WriteLine("Object x: " + p.x + " a object y: " + p.y);
            Console.WriteLine("Secti hodnoty objektu: " + p.soucet);
            Console.WriteLine("Secti hodnoty skrze metodu secti objektu: " + p.secti(p.x, p.y));

            Console.WriteLine("\n\n\n");

            // class vs struct
            var bod1 = new rozdilStr(5,3);
            bod1.a = 0;
            bod1.b = 0;

            var bod2 = new rozdilCls(5, 3);
            bod2.a = 0;
            bod2.b = 0;

            Console.WriteLine("Struktura vysledek: " + bod1.a + ", " + bod1.b);
            Console.WriteLine("Třída vysledek: " + bod2.a + ", " + bod2.b);


            Console.ReadKey();
        }
    }
}
