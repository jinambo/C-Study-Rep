using System;

namespace struktury_cv
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------
            // Point2D a vektory
            // -----------------

            Console.Write("Zadejte hodnotu bodu x: ");
            var x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zadejte hodnotu bodu y: ");
            var y = Convert.ToInt32(Console.ReadLine());

            Point2D vec1 = new Point2D(x, y); // první vektor
            Point2D vec2 = new Point2D(4, 2); // druhý vektor

            // Kalkulačka - demonstrace programu
            string operace;
            Console.Write("Jakou operaci chcete provést? (+, -, *, /)");
            operace = Console.ReadLine();

            switch (operace)
            {
                case "+":
                    Console.WriteLine("Součet bodů: " + vec1.sectiBody());
                    break;
                case "-":
                    Console.WriteLine("Rozdíl bodů: " + vec1.odectiBody());
                    break;
                case "*":
                    Console.WriteLine("Součin bodů: " + vec1.vynasobBody());
                    break;
                case "/":
                    Console.WriteLine("Rozdíl bodů: " + vec1.vydelBody());
                    break;
            }

            // Operace s vektory
            Console.WriteLine("\n----------------\nVEKTORY\n----------------");
            Point2D vec3 = new Point2D();

            Console.WriteLine("Soucet vektoru je: " + vec3.sectiVektory(vec1, vec2).x + "," + vec3.sectiVektory(vec1, vec2).y);
            Console.WriteLine("Soucin vektoru je: " + vec3.soucinVektoru(vec1, vec2).x + ", " + vec3.soucinVektoru(vec1, vec2).y);
            Console.WriteLine("Skalarni součin vektoru je: " + vec3.skalarniSoucinVektoru(vec1, vec2));



            // ---------------
            // Komplexní čísla
            // ---------------
            Console.WriteLine("\n--------------------------------\nKOMPLEXNÍ ČÍSLA\n--------------------------------");

            Complex imaginarniCislo = new Complex(-2.66, 3);

            // Vypiš absolutní hodnotu čísla
            Console.WriteLine("Absolutni hodnota komplexního čísla s imaginarni slozkou " + imaginarniCislo.imaginarni + " a realnou slozkou " + imaginarniCislo.realne + " i je: " + imaginarniCislo.absolut() + "i");


            // Pole komplexnich cisel
            var poleKomplexnichCisel = new Complex[] { new Complex(3.7, 1), new Complex(-5.1, 2), new Complex(-8.79, 3), new Complex(-3.42, 6) };


            // Vypiš největší komplexní číslo z pole podle jeho absolutní hodnoty
            double max = poleKomplexnichCisel[0].absolut();

            for (int i = 0; i < poleKomplexnichCisel.Length; i++) {
                if (poleKomplexnichCisel[i].absolut() > max) {
                    max = poleKomplexnichCisel[i].absolut();
                }
            }

            Console.WriteLine("Největší komplexní číslo v poli je " + max + "i");

            Console.ReadKey();
        }
    }
}