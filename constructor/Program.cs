using System;
using System.Collections.Generic;  

namespace constructor {
    class Program {

        Program p = new Program();

        static void Main(string[] args) {
            var person1 = new Person(1, "Karel", "Gott");

            Console.WriteLine("the first person is " + person1.name);
        }

        public void addNew(int id, string name, string lastName) {
            List<string> names = new List<string>();

            names.Add(id + " " + name + " " + lastName);
        }
    }

}
