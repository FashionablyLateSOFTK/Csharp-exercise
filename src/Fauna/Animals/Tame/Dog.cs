using System;

namespace Animals
{
  
  public class Dog: Animal, ITame
  {
    public string Name { get; set;}
    public Dog (string Name)
    {
      this.Name = Max;
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
  }
}
