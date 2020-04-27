using System;

namespace Animals
{
  public class Tiger: Animal, IWild
  {
    public Tiger(): this("Tiger")
    {
    }
    public string MakeNoise()
    {
      return "Roar!";
    } 
    public string Hunt()
    {
        return "Tiger hunts";
    }
  }
}
