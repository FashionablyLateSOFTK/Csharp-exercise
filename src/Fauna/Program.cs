using System;


namespace Animals
{
  
  public class Animals
  {
    public static void Main(string[] args)
    {
      Dog dog = new Dog("Max", 25);
      Cat cat = new Cat("Garfield", 3);
      Bird bird = new Bird("Tweetie", 2);
      Tiger tiger = new Tiger(100);
      Wolf wolf = new Wolf(50);
      Bear bear = new Bear(300);

      
     TextInterface textInterface = new TextInterface(bird, cat, dog);
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
