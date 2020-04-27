using System;

namespace Animals
{
  public class Wolf : IWild
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
