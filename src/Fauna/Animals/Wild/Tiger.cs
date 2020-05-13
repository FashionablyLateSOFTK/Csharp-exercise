using System;

namespace Animals
{
  public class Tiger: Animal, IWild
  {
    public int weight { get; set; }
    private Random random;

    public Tiger()
    {
      this.random = new Random();
      this.weight = 100;     
    }
   
    public override string MakeSound()
    {
      return "Roar!";
    } 
    public string Hunt()
    {
      double probability = this.random.NextDouble();

      if (probability <= 0.6)
      {
        Eat();
        return "Tiger kills and eats and now weighs " + this.weight + " kg.";
      }
      else
      {
        return "Found no game";
      }
    }
    public override void Eat()
    {
      this.weight += 1;
    }
  }
}
