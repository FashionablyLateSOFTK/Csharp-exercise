using System;

namespace Animals
{
  public class Wolf : Animal, IWild
  {
    public int weight { get; set; }
    private Random random;

    public Wolf(int weight)
    {
      this.random = new Random();
      this.weight = weight;     
    }
    public override string MakeSound()
    {
      return "Howl!";
    }
    public string Hunt()
    {
      double probability = this.random.NextDouble();

      if (probability <= 0.6)
      {
        Eat();
        return "Wolf kills and eats and now weighs " + this.weight + " kg.";
      }
      else
      {
        return "Wolf found no game and still weighs " + this.weight + " kg.";
      }
    }
    public override void Eat()
    {
      this.weight += 1;
    }
  }
}
