using System;
using System.Linq;

namespace pole {
    class Program {
        static void Main(string[] args) {
            double[] array1 = {12, 3, 5, 7, 12, 34, 8, 16}; 
            double[][] arrayMulti = new double[5][];

            for(int i = 0; i < arrayMulti.Length; i++) {
                arrayMulti[i] = new double[10];
                for(int ij = 0; ij < arrayMulti[i].Length; ij++) {
                    Console.Write("-");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Hodnoty v poli: ");
            foreach (int item in array1) {
                Console.Write(item + ", ");
            }

            Console.WriteLine("\n");

            // počet prvků
            Console.WriteLine("\nPočet prvků v poli: " + array1.Length);

            // nejmenší prvek v poli
            double minint = array1[0];
            /* 
            foreach (double value in array1) {
                if (value < minint) {
                    minint = value;
                    Console.Write("Nejmenší prvek v poli: " + minint + "\n");
                }
            }
            */

            for (int i = 0; i < array1.Length; i++) {
                if (array1[i] < minint) {
                    minint = array1[i];
                    Console.Write("Nejmenší prvek v poli: " + minint + "\n");
                }
            }
            

            // průměrná hodnota v poli
            Console.WriteLine("\n");
            double suma, avg;
            suma = 0;
            for (int i = 0; i < array1.Length; i++) {
                suma = suma + array1[i];
            }
            avg = suma / array1.Length;
            Console.WriteLine("\nPrůměrná hodnota v poli: " + avg);

            // sudá čísla
            Console.WriteLine("\n");
            Console.Write("\nSudá čísla: ");
            for (int i = 0; i < array1.Length; i++) {
                if (array1[i] % 2 == 0) {
                    Console.Write(array1[i] + ", ");
                }
            }

            // lichá čísla
            Console.Write("\nLichá čísla: ");
            for (int i = 0; i < array1.Length; i++) {
                if (array1[i] % 2 != 0) {
                    Console.Write(array1[i] + ", ");
                }
            }

            Console.WriteLine("\n\n");

            Array.Reverse(array1);
            Console.Write("Obracené pole: ");
            foreach (int i in array1) {
                Console.Write(i + ", ");
            }


            // porovnani prvku
            int[] prvni = {5,10,15,10};
            int prvni_hodnota = 0;
            int[] druhe = {20,5,5,10};
            int druha_hodnota = 0;

            for (int i = 0; i < prvni.Length; i++) {
                prvni_hodnota = prvni_hodnota + prvni[i];
            }

            for (int i = 0; i < druhe.Length; i++) {
                druha_hodnota = druha_hodnota + druhe[i];
            }
            
            // porovnání hodnot prvků
            if(prvni_hodnota == druha_hodnota) {
                Console.WriteLine("Hodnota prvního pole(" + prvni_hodnota + ") se rovná hodnotě druhého pole(" + druha_hodnota + ")");
            } else {
                Console.WriteLine("Hodnota prvního pole(" + prvni_hodnota + ") se nerovná hodnotě druhého pole(" + druha_hodnota + ")");
            }

            Console.WriteLine("\n\n");
            // porovnavání sumy prvků
            if (prvni.Length > druhe.Length) {
                Console.WriteLine("První pole má více prvků než druhé - " + prvni.Length + " a " + druhe.Length);
            } else if(prvni.Length < druhe.Length) {
                Console.WriteLine("První pole má méně prvků než druhé -  - " + prvni.Length + " a " + druhe.Length);
            } else {
                Console.WriteLine("První pole má stejně prvků jako druhé -  - " + prvni.Length + " a " + druhe.Length);
            }

            Console.WriteLine("\n");
            // najdi prvočíslo
            int[] mouznePrvocislo = {1, 2, 3, 6, 5, 7, 11, 16, 21, 71};
            int j, p;
            Console.WriteLine("Prvočísla jsou: ");
            for (int i = 0; i < mouznePrvocislo.Length; i++) {
                j = 2;
                p = 1;
                while (j < mouznePrvocislo[i]) {
                    if (mouznePrvocislo[i] % j == 0) {
                        p = 0;
                        break;
                    }
                    j++;
                }

                if (p == 1) {
                    Console.Write(mouznePrvocislo[i] + ", ");
                }
            }

            Console.WriteLine("\n\n");
            // opakuje se cislo
            int[] array = { 3, 4, 3, 5, 5, 3 };
            int count = 1, tempCount;
            int frequentNumber = array[0];
            int tempNumber = 0;
            for (int i = 0; i < (array.Length - 1); i++)
            {
                tempNumber = array[i];
                tempCount = 0;
                for (int jj = 0; jj < array.Length ; jj++)
                {
                    if (tempNumber == array[jj])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    frequentNumber = tempNumber;
                    count = tempCount;
                }
            }
            Console.WriteLine("Nejvíce opakované číslo v poli je {0}, bylo zde {1}x.",frequentNumber,count);        

            // matice
            /* char[,] matice = new char[2, 3] { // 2 pole o rozměru 3 -> nemusí takto zapisovat, c# si rozměr dopočítá
                {'a', 'b', 'g'}, { 'c', 'd', 'e' }
            };
            */


            Console.WriteLine("\nPro konec stiskni libovolnoú klavesu.");
            Console.ReadKey();
        }
    }
}
