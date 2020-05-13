using System;

namespace Animals
{
  
  public class Dog: Animal, ITame
  {
    public string Name { get; set; }
    public int weight;
    public Dog (string Name)
    {
      this.Name = Name;
      this.weight = 25;
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
      Console.WriteLine(this.Name + " got some food to eat and now it's weight is " + this.weight " kg.");
    }
  }
}
