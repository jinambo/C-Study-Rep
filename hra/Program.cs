using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------
            // CHARCTERS
            //---------------------------------------------
            Character mainCharacter = new Character("Chuck Norris", 100, 25, 10);
            Enemy bigDragon = new Enemy("Giant Three-Headed Dragon", 75, 20, 6);
            Enemy[] minions = new Enemy[] {
                new Enemy("Small Minion", 30, 5, 5),
                new Enemy("Medium Minion", 45, 5, 5),
                new Enemy("Big Minion", 50, 5, 5)
            };

            //---------------------------------------------
            // WELCOMING INTRODUCTION
            //---------------------------------------------
            Console.WriteLine("Vítejte v darčím dungeonu.\nPokud chcete projít musíte porazit následující moby: \n");
            int i = 0;

            foreach (Enemy minion in minions)
            {
                i++;
                Console.WriteLine(i + ") " + minion.Name);
            }

            Console.WriteLine((i + 1) + ") " + bigDragon.Name);
            Console.WriteLine("Pro spuštění hry stiskněte <enter>..");

            //---------------------------------------------
            // FIGHT
            //---------------------------------------------            
            while (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                foreach (var minion in minions)
                {
                    while (minion.Health > 0 && mainCharacter.Health > 0)
                    {
                        // útok na miniona
                        minion.toFight(mainCharacter.Atack(), minion.Defend());
                        Console.WriteLine("Minion " + minion.Name + " má: " + minion.Health);

                        // útok na hráče
                        mainCharacter.toFight(minion.Atack(), mainCharacter.Defend());
                        Console.WriteLine("Máte: " + mainCharacter.Health);
                    }
                    Console.WriteLine("\n");
                }
                while (bigDragon.Health > 0 && mainCharacter.Health > 0)
                {
                    // útok na draka
                    bigDragon.toFight(mainCharacter.Atack(), bigDragon.Defend());
                    Console.WriteLine("Drak má: " + bigDragon.Health);

                    // útok na hráče
                    mainCharacter.toFight(bigDragon.Atack(), mainCharacter.Defend());
                    Console.WriteLine("Máte: " + mainCharacter.Health);
                }
            }


            Console.ReadKey();
        }
    }
}
