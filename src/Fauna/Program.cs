using System;


namespace ConsoleApplication
{
  
  public class Program
  {
    public static void Main(string[] args)
    {
       Dog doggie = new Dog();
      Cat cattie = new Cat();
      Bird birdie = new Bird();
      Console.WriteLine(doggie.TalkToOwner());
      Console.WriteLine(cattie.TalkToOwner());
      Console.WriteLine(birdie.TalkToOwner());
    }
  }
}
