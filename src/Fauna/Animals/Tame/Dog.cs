using System;

namespace Animals
{
  
  public class Dog: Animal, ITame
  {
    public string Name { get; set; }
    public int weight { get; set; }
    public Dog (string Name, int weight)
    {
      this.Name = Name;
      this.weight = weight;
    }
    public string TalkToOwner()
    {
      return "Woof!";
    } 
     public override string MakeSound()
    {
      return "wof wof!";

    }
    public string ComeHere()
    {
      return this.Name + " came to the owner.";
    }
    public override void Eat()
    {
      this.weight += 1;
      Console.WriteLine(this.Name + " got some food to eat and now it's weight is " + this.weight + " kg.");
    }
  }
}
