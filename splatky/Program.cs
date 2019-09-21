using System;

namespace splatky {
    class Program {
        static void Main(string[] args) {
            string inLet, inRocniSazba, inPocatecniDluh;

            Console.Write("Zadejte pocet let splátek: ");
            inLet = Console.ReadLine();
            Console.Write("Zadejte roční sazbu v procentech: ");
            inRocniSazba = Console.ReadLine();
            Console.Write("Zadejte počáteční dluh v českých korunách: ");
            inPocatecniDluh = Console.ReadLine();

            int let = Convert.ToInt32(inLet);
            double rocniSazba = Convert.ToDouble(inRocniSazba);

            double pocatecniDluh = Convert.ToDouble(inPocatecniDluh);
            double dluh = pocatecniDluh;

            int mesicu = let * 12;
            double mesicniSazba = rocniSazba / (12 * 100);

            double v = 1 / (1 + mesicniSazba);
            double splatka = (mesicniSazba * pocatecniDluh) / (1 - Math.Pow(v, mesicu));

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nMesic       Dluh              Úrok           Úmor\n");
            Console.WriteLine("-------------------------------------------------------------\n");
            Console.ResetColor();

            for (int i = 1; i <= mesicu; i++) {
                double urok = mesicniSazba * dluh;
                double umor = splatka - urok;

                Console.WriteLine($"{i}. {dluh,18:F2}Kč {urok,13:F2}Kč {umor,13:F2}Kč ");

                dluh = dluh - umor;
            }

            Console.WriteLine("-------------------------------------------------------------\n\n");
            Console.WriteLine($"Mesicni spaltka je: {splatka:F2} Kč");
            Console.WriteLine($"Celkem zaplatite: {splatka * mesicu:F2} Kč\n\n");

            Console.WriteLine("Stiskněte náhodné tlačítko pro vypnutí programu.");
            Console.ReadKey();
        }
    }
}
