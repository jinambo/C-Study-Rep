using System;
using System.Collections.Generic;

namespace fileReader {
    class Program {
        public List<string> texty = new List<string>();
        static void Main(string[] args) {

            Program p = new Program();
            p.saveText();

            Console.ReadKey();
        }

        public void saveText() {
            string singleText;
            string repeat;

            Console.Write("Write something nice to save: ");
            singleText = Console.ReadLine();

            texty.Add(singleText);
            System.IO.File.WriteAllLines(@"/Users/jirisrytr/coding/c#/fileReader/file.txt", texty);

            Console.WriteLine("Words has been saved to the file.txt\n\n" + System.IO.File.ReadAllText(@"/Users/jirisrytr/coding/c#/fileReader/file.txt"));

            Console.WriteLine("Do you want to save more? y/n");
            repeat = Console.ReadLine();

            if (repeat == "y") {
                saveText();
            } else if (repeat == "n") {
                Console.WriteLine("OK, press any key to close the program.");
            } else {
                Console.WriteLine("Invalid value, press any key to close the program.");
            }

        }
    }
}
