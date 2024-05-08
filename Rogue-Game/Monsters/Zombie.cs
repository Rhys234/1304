using RogueSharp.DiceNotation;
using RogueSharpV3Tutorial.Core;

public class Zombie : Monster
{
    public static Zombie Create(int level)
    {
        int health = Dice.Roll("4D5");
        return new Zombie
        {
            Attack = Dice.Roll("1D2") + level / 3,
            AttackChance = Dice.Roll("25D5"),
            Awareness = 8,
            Color = Colors.ZombieColor,
            Defense = Dice.Roll("1D2") + level / 3,
            DefenseChance = Dice.Roll("10D3"),
            Gold = Dice.Roll("6D6"),
            Health = health,
            MaxHealth = health,
            Name = "Zombie",
            Speed = 9,
            Symbol = 'Z'
        };
    }
}