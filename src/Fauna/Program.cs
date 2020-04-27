using System;


namespace Animals
{
  
  public class Animals
  {
    public static void Main(string[] args)
    {
      Dog doggie = new Dog("Max");
      Cat cattie = new Cat("Garfield");
      Bird birdie = new Bird("Tweetie");
      Tiger tiger = new Tiger();
      Wolf wolf = new Wolf();
      Bear bear = new Bear();
      //Console.WriteLine(doggie.TalkToOwner());
      Console.WriteLine(cattie.TalkToOwner());
      Console.WriteLine(birdie.MakeSound());
      Console.WriteLine(doggie.ComeHere());
      Console.WriteLine(tiger.Hunt());
      Console.WriteLine(wolf.Hunt());
      Console.WriteLine(bear.MakeSound());

    }
  }
}
