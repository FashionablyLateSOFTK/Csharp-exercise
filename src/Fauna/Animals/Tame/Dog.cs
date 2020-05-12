using System;

namespace Animals
{
  
  public class Dog: Animal, ITame
  {
    public string Name { get; set; }
    public int weight { get; set; }
    public Dog ()
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
    }
  }
}
