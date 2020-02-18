using System;

namespace struktury_cv {
    class Program {
        static void Main(string[] args) {
            // Vektor
            Console.Write("Zadejte hodnotu bodu x: ");
            var x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zadejte hodnotu bodu y: ");
            var y = Convert.ToInt32(Console.ReadLine());
            
            Point2D vec1 = new Point2D(x,y);
            Point2D vec2 = new Point2D(4,2);

            // Kalkulačka - demonstrace programu
            string operace;
            Console.Write("Jakou operaci chcete provést? (+, -, *, /)");
            operace = Console.ReadLine();

            switch (operace) {
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
            Point2D vec3 = new Point2D();
            Console.WriteLine("Soucet vektoru je: " + (vec3.sectiVektory(vec1, vec2).x) + ", " + (vec3.sectiVektory(vec1, vec2).y));
            Console.WriteLine("Soucin vektoru je: " + (vec3.vynasobVektory(vec1, vec2).x) + ", " + (vec3.vynasobVektory(vec1, vec2).y));
            Console.WriteLine("Skalarni soucin vektoru je: " + vec3.skalar(vec1, vec2));

            // Komplexní čísla
            Complex imaginarniCislo = new Complex(-2.66, 3);
            Console.WriteLine("Absolutni hodnota komplexního čísla " + imaginarniCislo.imaginarni + "i je: " + imaginarniCislo.absolutka() + "i");


            // Pole komplexnich cisel
            var poleKomplexnichCisel = new Complex[] {new Complex(3.7, 2), new Complex(-5.1, 1), new Complex(-8.79, 2), new Complex(-3.42, 3)};

            double max = poleKomplexnichCisel[0].absolutka();

            for (int i = 0; i < poleKomplexnichCisel.Length; i++) {
                if (poleKomplexnichCisel[i].absolutka() > max) {
                    max = poleKomplexnichCisel[i].absolutka();
                }
            }

            Console.WriteLine("Největší číslo v poli je " + max + "i");

            Console.ReadKey();
        }
    }
}
