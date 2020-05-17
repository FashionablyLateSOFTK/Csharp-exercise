using System;

namespace Animals
{
  public class Bird : Animal, ITame
  {
    public string Name { get; set; }
    public int weight { get; set; }
    public Bird (string Name, int weight)
    {
      this.Name = Name;
      this.weight = weight;//
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
    public override void Eat()
    {
      this.weight += 1;
      Console.WriteLine(this.Name + " got a slimy worm to eat and now it's weight is " + this.weight + " kg.");
    }
  }
}
