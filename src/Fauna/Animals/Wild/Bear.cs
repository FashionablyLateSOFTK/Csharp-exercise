using System;

namespace Animals
{
  public class Bear : Animal, IWild
  {
    public int weight { get; set; }
    private Random random;

    public Bear(int weight)
    {
      this.random = new Random();
      this.weight = weight;     
    }
    public override string MakeSound()
    {
      return "Growl!";
    }
    public string Hunt()
    {
      double probability = this.random.NextDouble();

      if (probability <= 0.6)
      {
        Eat();
        return "Bear kills and eats and now weighs " + this.weight + " kg.";
      }
      else
      {
        return "Bear found no game and still weighs " + this.weight + " kg.";
      }
    }
    public override void Eat()
    {
      this.weight += 1;
    }    
  }
}
