using System;
using System.Collections.Generic;

namespace Animals
{
    public class TextInterface
    {
        private Bird bird;
        private Cat cat;
        private Dog dog;
        public TextInterface(Bird bird, Cat cat, Dog dog)
        {
            this.bird = bird;
            this.cat = cat;
            this.dog = dog;
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
                        if (species == "Bird" || species == "bird")
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
                        } // bird loop-end
                        if (species == "Cat" || species == "cat")
                        {
                            while (true)
                            {
                                Console.WriteLine("What do you want to do? [Eat, TalkToOwner, MakeSound, ComeHere, GiveName, back, quit]");
                                string catMethod = Console.ReadLine();
                                if (catMethod == "Eat")
                                {
                                    this.cat.Eat();
                                    Console.WriteLine();
                                }
                                if (catMethod == "TalkToOwner")
                                {
                                    Console.WriteLine(this.cat.TalkToOwner());
                                    Console.WriteLine();
                                }
                                if (catMethod == "MakeSound")
                                {
                                    Console.WriteLine(this.cat.MakeSound());
                                    Console.WriteLine();
                                }
                                if (catMethod == "ComeHere")
                                {
                                    Console.WriteLine(this.cat.ComeHere());
                                    Console.WriteLine();
                                }
                                if (catMethod == "GiveName")
                                {
                                    Console.WriteLine("Give a name:");
                                    string newName = Console.ReadLine();
                                    this.cat.Name = newName;
                                    //change the name for the animal
                                    Console.WriteLine();
                                }
                                if (catMethod == "back")
                                {
                                    Start();
                                }
                                if (catMethod == "quit") //still need some work(?)
                                {
                                    return;
                                }
                            }
                        }
                        if (species == "Dog" || species == "dog")
                        {
                            while (true)
                            {
                                Console.WriteLine("What do you want to do? [Eat, TalkToOwner, MakeSound, ComeHere, GiveName, back, quit]");
                                string dogMethod = Console.ReadLine();
                                if (dogMethod == "Eat")
                                {
                                    this.dog.Eat();
                                    Console.WriteLine();
                                }
                                if (dogMethod == "TalkToOwner")
                                {
                                    Console.WriteLine(this.dog.TalkToOwner());
                                    Console.WriteLine();
                                }
                                if (dogMethod == "MakeSound")
                                {
                                    Console.WriteLine(this.dog.MakeSound());
                                    Console.WriteLine();
                                }
                                if (dogMethod == "ComeHere")
                                {
                                    Console.WriteLine(this.dog.ComeHere());
                                    Console.WriteLine();
                                }
                                if (dogMethod == "GiveName")
                                {
                                    Console.WriteLine("Give a name:");
                                    string newName = Console.ReadLine();
                                    this.dog.Name = newName;
                                    //change the name for the animal
                                    Console.WriteLine();
                                }
                                if (dogMethod == "back")
                                {
                                    Start();
                                }
                                if (dogMethod == "quit") //still need some work(?)
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