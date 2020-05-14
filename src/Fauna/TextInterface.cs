using System;
using System.Collections.Generic;

namespace Animals
{
    public class TextInterface
    {
        private Bird bird;
        public TextInterface(Bird bird)
        {
            this.bird = bird;
        }
        public void Start()
        {
            List<string> animals = new List<string>();
            animals.Add("Bird");
            animals.Add("Cat");
            animals.Add("Dog");
            animals.Add("Bear");
            animals.Add("Tiger");
            animals.Add("Wolf");


            Console.WriteLine("What do you want to do? [list, quit]");

            while (true)
            {
                string answer = Console.ReadLine();
                if (answer == "list")
                {
                    Console.WriteLine();
                    Console.WriteLine("List of animals:");
                    animals.ForEach(Console.WriteLine);//prints list of animals

                    Console.WriteLine();

                    Console.WriteLine("Which animal do you want to see?");

                    string species = Console.ReadLine();
                    Console.WriteLine();
                    while (true)
                    {

                        if (species == "Bird")
                        {
                            while (true)
                            {
                                Console.WriteLine("What do you want to do? [Eat, TalkToOwner, MakeSound, ComeHere, GiveName, back, quit]");
                                string birdMethod = Console.ReadLine();
                                if (birdMethod == "Eat")
                                {
                                    this.bird.Eat();
                                    Console.WriteLine();
                                }
                                if (birdMethod == "TalkToOwner")
                                {
                                    Console.WriteLine(this.bird.TalkToOwner());
                                    Console.WriteLine();
                                }
                                if (birdMethod == "MakeSound")
                                {
                                    Console.WriteLine(this.bird.MakeSound());
                                    Console.WriteLine();
                                }
                                if (birdMethod == "ComeHere")
                                {
                                    Console.WriteLine(this.bird.ComeHere());
                                    Console.WriteLine();
                                }
                                if (birdMethod == "GiveName")
                                {
                                    Console.WriteLine("Give a name:");
                                    string newName = Console.ReadLine();
                                    this.bird.Name = newName;
                                    //change the name for the animal
                                    Console.WriteLine();

                                }
                                if (birdMethod == "back")
                                {
                                    Start();
                                }
                                if (birdMethod == "quit") //still need some work(?)
                                {
                                    return;
                                }
                            }
                        }
                    }
                }
                if (answer == "quit")
                {
                    break;

                }
            }
        }
    }
}