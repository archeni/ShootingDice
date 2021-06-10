using System;

namespace ShootingDice
{
  // TODO: Complete this class

  // A Player whose role will always be in the upper half of their possible rolls
  public class UpperHalfPlayer : Player
  {
    public override void Play(Player other)
    {
      int myRoll = new Random().Next(4) + 2; ;
      int otherRoll = other.Roll();

      Console.WriteLine($"{Name} rolls a {myRoll}");
      Console.WriteLine($"{other.Name} rolls a {otherRoll}");
      if (myRoll > otherRoll)
      {
        Console.WriteLine($"{Name} Wins!");
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
}