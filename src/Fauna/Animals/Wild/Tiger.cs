using System;

namespace Animals
{
  public class Tiger: Animal, IWild
  {
    public Tiger(): this("Tiger")
    {
    }
    public override string MakeSound()
    {
      return "Roar!";
    } 
    public string Hunt()
    {
        return "Tiger hunts";
    }
  }
}
