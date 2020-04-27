using System;


namespace Animals
{
  
  public class Animals
  {
    public static void Main(string[] args)
    {
      Dog doggie = new Dog();
      Cat cattie = new Cat();
      Bird birdie = new Bird();
      Console.WriteLine(doggie.MakeSound());
      Console.WriteLine(cattie.MakeSound());
      Console.WriteLine(birdie.MakeSound());
      
      Tiger t = new Tiger();
      
      Console.WriteLine(t.MakeSound());
      Console.WriteLine(t.Hunt());
    }
  }
}
