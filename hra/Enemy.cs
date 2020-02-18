using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Enemy : Character
    {
        public Enemy(string Name, int Health, int Strength, int Durability) : base(Name, Health, Strength, Durability)
        {
            this.Name = Name;
            this.Health = Health;
            this.Strength = Strength;
            this.Durability = Durability;
        }
    }
}
