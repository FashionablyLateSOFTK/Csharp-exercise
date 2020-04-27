using System;

namespace Animals
{
  public class Wolf : Animal, IWild
  {
    public string MakeNoise()
    {
      return "Howl!";
    }
    public string Hunt()
    {
        return "Wolf hunts";
    }
  }
}
