using System;

namespace consoleapp {
    class Program {

        static void Main(string[] args) {
            Program p = new Program();
            p.test();

            string yoname;

            Console.WriteLine("And what is your name?");
            yoname = Console.ReadLine();

            p.sayGoodbye(yoname);
        }
        public void test() {
            string userInput; // user will input string data type
            string[] data; // user will split data with space and it will be pushed to the data array
            int a, b;
            double output;

            Console.Write("Enter number: "); // Write wont create a new line (difference between write and writeLine)

            userInput = Console.ReadLine();
            data = userInput.Split(',');

            a = Convert.ToInt32(data[0]);
            b = Convert.ToInt32(data[1]);

            output = Math.Sqrt((a*a) + (b*b));

            Console.WriteLine("{0} and {1} are your numbers and theirs sum's square root is: {2}", a, b, output);
            //Console.WriteLine(a + " and " + b + " are your numbers and theirs sum's square root is: " + output + ".");

            Console.WriteLine("Press <Enter> to close the program.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) {
                Console.WriteLine("- this is not and enter :(.");
            }
        }

        public void sayGoodbye(string name) {
            Console.WriteLine("Goodbye you human called " + name + ".");
        }
    }

}
