using System;

namespace morsecode {
    class Program {
        static void Main(string[] args) {
            Program p = new Program();
            string input;

            Console.WriteLine("Type any number: \n");
            input = Console.ReadLine();

            p.Convertor(input);

            Console.WriteLine("\n\nPress any key to close this program.");
            Console.ReadKey();
        }

        public void Convertor(string userInput) {
            int num = Convert.ToInt32(userInput);
            string[] morseCodes = {"-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----."};

            if (num < 9) {
                Console.Write("\nThis is your number in morse code: " + morseCodes[num]);
            } else {
                string moreThanNine = Convert.ToString(num); // number which is bigger than 9 will be converted to string

                Console.Write("\nThis is your number in morse code: ");
                // separate every single character in the string
                foreach (char c in moreThanNine) {
                    string stack = c.ToString(); // Stack those characters again -> we will be able to convert it to the integer

                    Console.Write(morseCodes[Convert.ToInt16(stack)] + " ");
                }
            }
        }

    }
}
