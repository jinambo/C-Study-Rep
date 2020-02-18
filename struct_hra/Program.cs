using System;

namespace struct_hra {
    struct Kruh {
        public double r;

        public void zmenPolomer(int x) {
           r = x;
        }
    }
    class Program {
        static void Main(string[] args) {
            Kruh k1 = new Kruh();

            k1.zmenPolomer(5);

            Console.WriteLine(k1.r);
            Console.ReadKey();
        }
    }
}
