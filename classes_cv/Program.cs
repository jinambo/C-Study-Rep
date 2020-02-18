using System;

namespace classes_cv {
    class Program {
        static void Main(string[] args) {
            Kruh k1 = new Kruh(5);
            Kruh o1 = new Kruh(5.0);

            Console.WriteLine("Kruh o polomeru " + k1.polomer + " má obvod " + k1.obvodKruhu() + " a obsah " + k1.obsahKruhu());
            Console.WriteLine(k1.porovnejPolomery(k1, o1));

            Console.ReadKey();
        }
    }
}
