using System;

class Character
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Strength { get; private set; }
    public int Durability { get; private set; }
    public int Dexterity { get; private set; }

    public Character(string Name, int Health, int Strength, int Durability, int Dexterity)
    {
        this.Name = Name;
        this.Health = Health;
        this.Strength = Strength;
        this.Durability = Durability;
        this.Dexterity = Dexterity;
    }

    public int Fight(int hit)
    {
        return this.Health = Health - hit;
    }
}