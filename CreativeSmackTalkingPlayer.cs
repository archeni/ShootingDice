using System;
using System.Collections.Generic;

namespace ShootingDice
{
  // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
  public class CreativeSmackTalkingPlayer : Player
  {
    public List<string> insults = new List<string>() {
      "You smell like poo",
      "Your mother was a weasel",
      "Your father smelt of elderberries",
      "You suck",
      "You're kinda dumb"
    };
    public override int Roll()
    {
      var rand = new Random();
      Console.WriteLine(insults[rand.Next(4)]);
      return base.Roll();
    }
  }
}