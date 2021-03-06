using System;

namespace Animals
{
  public class Tiger: Animal, IWild
  {
    public int weight { get; set; }
    private Random random;

    public Tiger(int weight)
    {
      this.random = new Random();
      this.weight = weight;     
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
        return "Tiger found no game and still weighs " + this.weight + " kg.";
      }
    }
    public override void Eat()
    {
      this.weight += 1;
    }
  }
}
