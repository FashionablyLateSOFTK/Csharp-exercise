using System;

namespace Animals
{
  public class Cat : Animal, ITame
  {
    public string Name { get; set; }
    public int weight { get; set; }
       
    public Cat (string Name)
    {
      this.Name = Name;
      this.weight = 3;
     
    }
        
    public string TalkToOwner()
    {
      return "Mew!";
    } 
    public override string MakeSound()
    {
      return "Mew!";
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
