using RogueSharp.DiceNotation;
using RogueSharpV3Tutorial.Core;

public class Ghoul : Monster
{
    public static Ghoul Create(int level)
    {
        int health = Dice.Roll("6D8");
        return new Ghoul
        {
            Attack = Dice.Roll("4D5") + level / 3,
            AttackChance = Dice.Roll("30D4"),
            Awareness = 15,
            Color = Colors.KoboldColor,
            Defense = Dice.Roll("4D6") + level / 3,
            DefenseChance = Dice.Roll("12D6"),
            Gold = Dice.Roll("8D8"),
            Health = health,
            MaxHealth = health,
            Name = "Ghoul",
            Speed = 12,
            Symbol = 'G'
        };
    }
}