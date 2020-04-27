using System;

namespace Pets
{
  public class Bird : Animals, ITame
  {
    public string Name { get; set;}
    public Bird (string Name)
    {
      this.Name = Tweetie;
    }
    public string TalkToOwner()
    {
      return "Chirp!";
    }
    public override string MakeSound()
    {
      return "Scree!";
    }
  }
}
