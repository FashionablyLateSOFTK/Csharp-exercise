using System;

namespace Animals
{
  public class Bird : Animal, ITame
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
    public string ComeHere()
    {
      return this.Name + " came to the owner.";
    }
  }

  
}
