using System;

namespace Animals
{
  public class Tiger: IWild
  {
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
