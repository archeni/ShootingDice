using System;

namespace ShootingDice
{
  public class Player
  {
    public string Name { get; set; }
    public int DiceSize { get; set; } = 6;

    public virtual int Roll()
    {
      // Return a random number between 1 and DiceSize
      return new Random().Next(DiceSize) + 1;
    }

    public virtual void Play(Player other)
    {
      // Call roll for "this" object and for the "other" object
      int myRoll = Roll();
      int otherRoll = other.Roll();

      Console.WriteLine($"{Name} rolls a {myRoll}");
      Console.WriteLine($"{other.Name} rolls a {otherRoll}");
      if (myRoll > otherRoll)
      {
        Console.WriteLine($"{Name} Wins!");
        if (other.ToString() == "ShootingDice.SoreLoserPlayer")
        {
          throw new SoreLoserException("I can't lose!");
        }
      }
      else if (myRoll < otherRoll)
      {
        Console.WriteLine($"{other.Name} Wins!");
      }
      else
      {
        // if the rolls are equal it's a tie
        Console.WriteLine("It's a tie");
      }
    }
  }

  public class SoreLoserException : Exception
  {
    public SoreLoserException(string message) : base(message)
    {

    }
  }
}