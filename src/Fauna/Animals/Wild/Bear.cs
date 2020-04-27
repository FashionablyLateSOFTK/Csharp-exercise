using System;

namespace Animals
{
  public class Bear : Animal, IWild
  {
    public string MakeNoise()
    {
      return "Growl!";
    }
    public string Hunt()
    {
        return "Bear hunts";
    } 
  }
}
