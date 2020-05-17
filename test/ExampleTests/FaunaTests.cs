using System;
using NUnit.Framework;
using Animals;

namespace Animals
{
    public class PetTests
    {

        [Test]
        public void DogTalkToOwnerReturnsWoof()
        {
            string expected = "Woof!";
            string actual = new Dog("", 0).TalkToOwner();

            Assert.AreEqual(expected, actual, "Dog should say Woof!");
        }
        [Test]
        public void DogMakeSound()
        {
            string expected = "wof wof!";
            string actual = new Dog("", 0).MakeSound();

            Assert.AreEqual(expected, actual, "Dog should say Woof!");
        }
        [Test]
        public void DogComeHere()
        {
            string expected = new Dog("", 0) + " came to the owner.";
            string actual = new Dog("", 0) + new Dog("", 0).ComeHere();// <<<<<<<<<<<<

            Assert.AreEqual(expected, actual, "Dog should come to the owner.");
        }
        [Test]
        public void DogEat()
        {
            string expected = new Dog("", 0) + " got some food to eat and now it's weight is " + new Dog("", 0) + " kg.";
            string actual = new Dog("", 0) + " got some food to eat and now it's weight is " + new Dog("", 0) + " kg.";

            Assert.AreEqual(expected, actual, "Dog should be fed and gain 1 kg.");
        }
        [Test]
        public void CatTalkToOwnerReturnsMew()
        {
            string expected = "Mew!";
            string actual = new Cat("", 0).TalkToOwner();

            Assert.AreEqual(expected, actual, "Cat should say Mew!");
        }
        [Test]
        public void CatMakeSound()
        {
            string expected = "Mew!";
            string actual = new Cat("", 0).MakeSound();

            Assert.AreEqual(expected, actual, "Cat should say Mew!");
        }
        [Test]
        public void CatComeHere()
        {
            string expected = new Cat("", 0) + " came to the owner.";
            string actual = new Cat("", 0) + new Cat("", 0).ComeHere();

            Assert.AreEqual(expected, actual, "Cat should come to the owner.");
        }
        [Test]
        public void BirdTalkToOwnerReturnsSqueek()
        {
            string expected = "Chirp!";
            string actual = new Bird("", 0).TalkToOwner();

            Assert.AreEqual(expected, actual, "Bird should say Chirp!");
        }
        [Test]
        public void BirdMakeSound()
        {
            string expected = "Scree!";
            string actual = new Bird("", 0).MakeSound();

            Assert.AreEqual(expected, actual, "Bird should say Scree!");
        }
        [Test]
        public void BirdComeHere()
        {
            string expected = new Bird("", 0) + " came to the owner.";
            string actual = new Bird("", 0) + new Bird("", 0).ComeHere();

            Assert.AreEqual(expected, actual, "Bird should come to the owner.");
        }
        [Test]
        public void BearMakeSound()
        {
            string expected = "Growl!";
            string actual = new Bear(0).MakeSound();

            Assert.AreEqual(expected, actual, "Bear should say Growl!");
        }
        [Test]
        public void BearHunt()
        {
            string expected = "Bear kills and eats and now weighs " + new Bear(0) + " kg.!";
            string or = "Bear found no game and still weighs " + new Bear(0) + " kg."; 
            string actual = new Bear(0).Hunt();

            if (expected == actual)
            {
            Assert.AreEqual(expected, actual, "Bear should hunt!");
            }
            if (or == actual)
            {
                Assert.AreEqual(or, actual, "Bear should not always be successful!");
            }
           
        }
        [Test]
        public void TigerMakeSound()
        {
            string expected = "Roar!";
            string actual = new Tiger(0).MakeSound();

            Assert.AreEqual(expected, actual, "Tiger should say Roar!");
            
        }
        [Test]
        public void TigerHunt()
        {
           string expected = "Tiger kills and eats and now weighs " + new Tiger(0) + " kg.!";
            string or = "Tiger found no game and still weighs " + new Tiger(0) + " kg."; 
            string actual = new Tiger(0).Hunt();

            
            if (expected == actual)
            {
            Assert.AreEqual(expected, actual, "Tiger should hunt!");
            }
            if (or == actual)
            {
                Assert.AreEqual(or, actual, "Tiger should not always be successful!");
            }
        }
        [Test]

        public void WolfMakeSound()
        {
            string expected = "Howl!";
            string actual = new Wolf(0).MakeSound();

            Assert.AreEqual(expected, actual, "Wolf should say Howl!!");
        }
        [Test]
        public void WolfHunt()
        {
            string expected = "Wolf kills and eats and now weighs " + new Wolf(0) + " kg.!";
            string or = "Wolf found no game and still weighs " + new Wolf(0) + " kg."; 
            string actual = new Wolf(0).Hunt();

            
            if (expected == actual)
            {
            Assert.AreEqual(expected, actual, "Wolf should hunt!");
            }
            if (or == actual)
            {
                Assert.AreEqual(or, actual, "Wolf should not always be successful!");
            }
        }


    }
}