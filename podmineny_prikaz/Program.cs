// 3. cvičení A1ZAP

using System;

namespace podmineny_prikaz {
    class Program {
        static void Main(string[] args) {
            
            // Maximum ze dvou čísel
            int a = 5;
            int b = 10;

            if(a > b) {
                Console.WriteLine("{0} je větší než {1}.", a, b);
            } else {
                Console.WriteLine("{1} je větší než {0}.", a, b);
            }

            // Modulo
            int x = 15;

            if(x % 5 == 0) {
               Console.WriteLine("Cislo {0} je dělitelné pěti beze zbytku.", x); 
            }

            if (x % 2 == 0) {
               Console.WriteLine("Cislo {0} je sudé.", x);                 
            }

            if (x % 3 == 0) {
               Console.WriteLine("Cislo {0} je liché.", x);                 
            }

            // Kořeny kvadratické rovnice
            double koren1, koren2, D;
            double aa = 5;
            double bb = 60;
            double cc = 9;

            D = Math.Pow(bb, 2) - (4 * aa * cc);

            koren1 = (-bb + Math.Sqrt(D)) / 2 * aa;
            koren2 = (-bb - Math.Sqrt(D)) / 2 * aa;

            Console.WriteLine($"Prvni koren je {koren1:F2} a druhy je {koren2:F2}.");

            // BMI kalkulačka
            double bmi;
            double vaha = 73;
            double vyska = 1.73;

            bmi = vaha / Math.Pow(vyska, 2);
            
            if (bmi < 16.5) {
                Console.WriteLine("Vaše BMI je {0}, trpíte tedy težkou podvýživou.", bmi);
            } else if(bmi < 18.5 && bmi > 16.5) {
                Console.WriteLine("Vaše BMI je {0}, máte podváhu.", bmi);
            } else if(bmi < 25 && bmi > 18.5) {
                Console.WriteLine("Vaše BMI je {0}, to je ideální váha.", bmi);
            } else if (bmi < 30 && bmi > 25) {
                Console.WriteLine("Vaše BMI je {0}, máte nadváhu", bmi);
            } else if (bmi < 35 && bmi > 30) {
                Console.WriteLine("Vaše BMI je {0}, máte obezitu 1. stupně.", bmi);
            } else if (bmi < 40 && bmi > 35) {
                Console.WriteLine("Vaše BMI je {0}, máte obezitu 2. stupně.", bmi);
            } else if (bmi > 40) {
                Console.WriteLine("Vaše BMI je {0}, trpíte morbidní obezitou 3. stupně.", bmi);
            }

            // Max/min ze tří čísel
            int cislo1 = 13;
            int cislo2 = 28;
            int cislo3 = 6;

            if(cislo1 > cislo2 && cislo1 > cislo3) {
                Console.WriteLine("Cislo {0} je největší.", cislo1);
                if (cislo2 < cislo3) {
                    Console.WriteLine("Cislo {0} je nejmenší.", cislo2);
                } else {
                    Console.WriteLine("Cislo {0} je nejmenší.", cislo3);
                }
            } else if (cislo2 > cislo1 && cislo2 > cislo3)  {
                Console.WriteLine("Cislo {0} je největší.", cislo2);
                if (cislo3 < cislo1) {
                    Console.WriteLine("Cislo {0} je nejmenší.", cislo3);
                } else {
                    Console.WriteLine("Cislo {0} je nejmenší.", cislo1);
                }
            } else if (cislo3 > cislo1 && cislo3 > cislo2) {
                Console.WriteLine("Cislo {0} je největší.", cislo3);
                if (cislo1 < cislo2) {
                    Console.WriteLine("Cislo {0} je nejmenší.", cislo1);
                } else {
                    Console.WriteLine("Cislo {0} je nejmenší.", cislo2);
                }
            }

            // vypise dve nejlepsi testy
            double t1 = 16.0;
            double t2 = 14.0;
            double t3 = 21.0;

            if (t1 > t2 && t1 > t3) {
                Console.WriteLine(t1);
                if (t2 > t3) {
                    Console.WriteLine(t2);
                } else {
                    Console.WriteLine(t3);
                }
            } else if (t2 > t1 && t2 > t3) {
                Console.WriteLine(t2);
                if (t1 > t3) {
                    Console.WriteLine(t1);
                } else {
                    Console.WriteLine(t3);
                }
            } else {
                Console.WriteLine(t3);
                if (t1 > t2) {
                    Console.WriteLine(t1);
                } else {
                    Console.WriteLine(t2);
                }
            }

            Console.ReadKey();
        }
    }
}
