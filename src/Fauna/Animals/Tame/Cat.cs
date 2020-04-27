using System;

namespace Animals
{
  public class Cat : Animal, ITame
  {
    public string Name { get; set; }
    public Cat (string Name)
    {
      this.Name = Garfield;
    }
    
    public string TalkToOwner()
    {
      return "Mew!";
    } 
    public override string MakeSound()
    {
      return "Mew!";
    }
    public string ComeHere();
    {
      return this.Name + " come to the owner.";
    }
  }
}
