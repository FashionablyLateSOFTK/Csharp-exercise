using System;
using System.Collections.Generic;

namespace Animals
{
    public class TI
    {
        private Bird bird;
        private Cat cat;
        private Dog dog;
        private Bear bear;
        private Tiger tiger;
        private Wolf wolf;
        public TI(Bird bird, Cat cat, Dog dog, Bear bear, Tiger tiger, Wolf wolf)
        {
            this.bird = bird;
            this.cat = cat;
            this.dog = dog;
            this.bear = bear;
            this.tiger = tiger;
            this.wolf = wolf;
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
                if (species == "Bird" || species == "bird")
                {
                    Bird();
                }
                if (species == "Cat" || species == "cat")
                {
                    Cat();
                }

            }
            
        }
        public void Bird()
        {
            Console.WriteLine("What do you want to do? [Eat, TalkToOwner, MakeSound, ComeHere, GiveName, back, quit]");
            string birdMethod = Console.ReadLine();
            bool bBreak = false;
            while(bBreak == false)
            {
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
                bBreak = true;
                break;
            }
            
            if (bBreak == true)
            {
                break;
            }
           
        
        }}

        public void Cat()
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
            Cat();
        }
    }
}


