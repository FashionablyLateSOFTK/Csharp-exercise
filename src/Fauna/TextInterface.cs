using System;

namespace Animals
{
    public class TextInterface: Animals
    {

    public TextInterface() 
    {

    }
    public void Start()
    {
        Console.WriteLine("What do you want to do? [list, quit]");
        while (true)
        {
        string answer = Console.ReadLine();
        if (answer == "list")
        {
           Console.WriteLine("List of animals:"); 
           //print list of animals
           Console.WriteLine("Which animal do you want to see?");
           while (true)
           {
               string species = Console.ReadLine();
               if (species == "bird")
               {
                   while (true)
                   {
                   Console.WriteLine("What do you want to do? [Eat, TalkToOwner, MakeSound, ComeHere, GiveName, back, quit]");
                   string birdMethod = Console.ReadLine();
                   if (birdMethod == "Eat")
                   {
                      // Bird.Eat();
                   }
                   if (birdMethod == "TalkToOwner")
                   {
                        Bird.TalkToOwner();
                   }
                   if (birdMethod == "MakeSound")
                   {
                        Bird.MakeSound();
                   }
                   if (birdMethod == "ComeHere")
                   {
                        Bird.ComeHere();
                   }
                   if (birdMethod == "GiveName")
                   {
                       Console.WriteLine("Give a name:");
                       string name = Console.ReadLine();

                   }
                   if (birdMethod == "back")
                   {
                       
                   }
                    if (birdMethod == "quit")
                   {
                       break;
                   }}
               }
           }

        }
        if (answer == "quit")
        {
            break;
        }
        }

    }}
}