using System;

namespace oop_game
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------------------------------
            // CHARACTERS
            // --------------------------------------------
            Character mainCharacter = new Character("Karlos", 100, 20, 10, 15);
            Character[] mobs = new Character[]{
                new Character("The Ruthless Spider", 100, 10, 7, 9),
                new Character("Captain Wise Swindler", 100, 12, 6, 11),
                new Character("Scarlet Beast", 100, 12, 11, 9),

                new Character("Vasil Vozembouch", 120, 20, 15, 10)
            };

            // --------------------------------------------
            // WELCOMING SCREEN
            // --------------------------------------------
            Console.WriteLine("Hello there, welome to the pretty shitty game.\nYou can choose those mobs to fight: \n");
            int i = 0;
            foreach (var mob in mobs)
            {
                i++;
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine(i + " - Name:" + mob.Name + ", Health: " + mob.Health + ", Strength: " + mob.Strength + ", Durability: " + mob.Durability + ", Dexterity: " + mob.Dexterity);
                Console.WriteLine("------------------------------------------------------------------------------------------");
            }

            Console.ReadKey();
        }
    }
}
