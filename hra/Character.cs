using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Character
    {
        public string Name { get; protected set; }
        public double Health { get; protected set; }
        public double Strength { get; protected set; }
        public double Durability { get; protected set; }

        public Character(string Name, double Health, double Strength, double Durability)
        {
            this.Name = Name;
            this.Health = Health;
            this.Strength = Strength;
            this.Durability = Durability;
        }

        public double Atack()
        {
            Random rnd = new Random();
            double minimalHit = this.Strength * 0.5;
            double maximalHit = this.Strength * 1.5;
            double hitValue = rnd.NextDouble() * (maximalHit - minimalHit) + minimalHit;

            return hitValue;
        }

        public double Defend()
        {
            Random rnd = new Random();
            double minimalDef = this.Strength * 0.1;
            double maximalDef = this.Strength * 0.75;
            double defValue = rnd.NextDouble() * (maximalDef - minimalDef) + minimalDef;

            return defValue;
        }

        public void toFight(double hitValue, double defValue)
        {
            if (defValue >= hitValue)
            {
                this.Health = Health;
            }
            else
            {
                this.Health = Health - (hitValue - defValue);
            }
        }

    }
}
