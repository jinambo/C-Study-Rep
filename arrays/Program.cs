using System;
using System.Collections.Generic;

namespace arrays {
    class Program {
        static void Main(string[] args) {
            int[][] jaggedArray3 = {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };
            Console.WriteLine("Map: " + jaggedArray3[1][2]);


            int[] array1 = new int[] {1,3,5}; 
            var list1 = new List<int>(); // Create a new list

            Random randomNum = new Random(); // Pseudo random num c# generator


            // Collect 10 random nums to the list
            for(int i = 0; i < 10; i++) {
                list1.Add(randomNum.Next(1,100));
            }

            Console.WriteLine("In this list there are:" + list1.Count + " elements"); // lenght of list
            Console.WriteLine("Does the list contain int with value 3? " + list1.Contains(3)); // will return true or false

            // print all elements from list
            foreach (int element in list1) {
                Console.Write(element + ", ");
            }

            Console.WriteLine("\n\nWanna end the program? Press escape..");
            while (Console.ReadKey().Key != ConsoleKey.Escape){
                // If Console Key is not esc then do nothing
            }


        }
        
    }
}
