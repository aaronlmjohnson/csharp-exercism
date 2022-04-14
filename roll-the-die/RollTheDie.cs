using System;

public class Player
{
    public int RollDie()
    {
        Random die = new Random();
        return die.Next(1, 18);
    }

    public double GenerateSpellStrength()
    {
        Random die = new Random();
        return die.NextDouble() * 100;
    }
}
