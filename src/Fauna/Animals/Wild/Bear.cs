using System;

namespace Animals
{
  public class Bear : IWild
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
