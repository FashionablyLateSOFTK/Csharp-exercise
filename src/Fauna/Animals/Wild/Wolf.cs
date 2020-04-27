using System;

namespace Animals
{
  public class Wolf : Animal, IWild
  {
    public string MakeSound()
    {
      return "Howl!";
    }
    public string Hunt()
    {
        return "Wolf hunts";
    }
  }
}
