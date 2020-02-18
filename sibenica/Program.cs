using System;
using System.Collections.Generic;
using System.Linq;

namespace sibenica {
    class Program {
        static void Main(string[] args) {
            string word;
            char guess;
            List<char> listOfLetters = new List<char>(); // an empty list - single chars from the string will be added

            Console.WriteLine("---------------------------");
            Console.Write("Welcome to Game of Šibenica. \nType any word to continue: ");
            Console.WriteLine("\n---------------------------");

            word = Console.ReadLine();
            listOfLetters.AddRange(word); // add chars from word variable to list

            char[] fakeArray = new char[listOfLetters.Count];
            List<char> listOfGuess = fakeArray.ToList();
            int i = 0;

            // 5 pokusu
            Console.WriteLine(listOfGuess.Count + " You have just 10 tries.\n");
            while (String.Join("", listOfGuess.ToArray()) != word) {
                string resultWord = String.Join("", listOfGuess.ToArray());
                guess = Convert.ToChar(Console.ReadLine());
                i++;

                if (listOfLetters.Contains(guess)) {
                    var index = listOfLetters.IndexOf(guess);
                    var secondIndex = listOfLetters.IndexOf(guess, listOfLetters.IndexOf(guess) + 1);
                    bool isRepeated = listOfLetters.Count(x => x == guess) > 1;

                    if(isRepeated == true) {
                        Console.WriteLine("Letter: " + listOfLetters[secondIndex] + " was found at: " + listOfLetters.IndexOf(guess, listOfLetters.IndexOf(guess) + 1));
                        listOfGuess.Insert(secondIndex, guess);
                    }

                    Console.WriteLine(" Letter: " + listOfLetters[index] + " was found at: " + listOfLetters.IndexOf(guess));
                    listOfGuess.Insert(index, guess);
                }

                if (word == resultWord) {
                    Console.WriteLine("You have won the game.");
                    break;
                }

                if (i > 5) {
                    Console.WriteLine("You have lost the game.");
                    Console.WriteLine(word + " is same as fucking " + resultWord);
                    break;
                }
            }

            foreach (var guessedLetter in listOfGuess) {
                Console.Write(guessedLetter);
            }

            Console.ReadKey();
        }
    }
}
