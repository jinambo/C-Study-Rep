using System;

namespace hexConv {
    class Program {
        static void Main(string[] args) {
            int decn, q, dn = 0, m, l;
            int tmp;
            int s;
                
            Console.Write("\n\n");
            Console.Write("Convert a number in decimal to hexadecimal:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");		

            Console.Write("Input  any Decimal number: ");
            decn = Convert.ToInt32(Console.ReadLine());	

            q = decn;

            for(l = q;l > 0;l = l / 16) {
                tmp = l % 16;
                if (tmp < 10) {
                    tmp = tmp + 48; 
                }
                else {
                    tmp = tmp + 55;
                    dn = dn * 100 + tmp;
                }
            }

            Console.Write("\nThe equivalent Hexadecimal Number : ");

            for (m = dn;m > 0;m = m / 100) {
                s = m % 100;
                Console.Write("{0}",(char)s);
            }
            

            // if temp is greather than 10
            int i;
            for (i = 65; i <= 70; i++) {
                Console.WriteLine("{0} -> {1}\n", i, (char)i);
            }

            Console.Write("\n");

            // if temp is less than 10
            int j;
            for (j = 48; j <= 57; j++) {
                Console.WriteLine("{0} -> {1}\n", j, (char)j);
            }

            Console.Write("\n\n");

        }
    }
}
