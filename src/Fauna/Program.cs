using System;


namespace Animals
{
  
  public class Animals
  {
    public static void Main(string[] args)
    {
      Dog doggie = new Dog("Max");
      Cat cattie = new Cat("Garfield");
      Bird bird = new Bird("Tweetie", 5);
      Tiger tiger = new Tiger();
      Wolf wolf = new Wolf();
      Bear bear = new Bear();

      
     TextInterface textInterface = new TextInterface(bird);
     textInterface.Start();

      /*Console.WriteLine(doggie.TalkToOwner());
      Console.WriteLine(cattie.TalkToOwner());
      Console.WriteLine(birdie.TalkToOwner());
    
      Console.WriteLine();

      Console.WriteLine(doggie.MakeSound());
      Console.WriteLine(cattie.MakeSound());
      Console.WriteLine(birdie.MakeSound());
      Console.WriteLine(tiger.MakeSound());
      Console.WriteLine(wolf.MakeSound());
      Console.WriteLine(bear.MakeSound());

      Console.WriteLine();

      Console.WriteLine(doggie.ComeHere());
      Console.WriteLine(cattie.ComeHere());
      Console.WriteLine(birdie.ComeHere());

      Console.WriteLine();

      Console.WriteLine(tiger.Hunt());
      Console.WriteLine(wolf.Hunt());
      Console.WriteLine(bear.Hunt());

      Console.WriteLine();

      
      birdie.Eat();
      cattie.Eat();
      doggie.Eat();*/
    }
  }
}
