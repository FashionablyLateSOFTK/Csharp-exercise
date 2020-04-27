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
            string actual = new Dog("").TalkToOwner();

            Assert.AreEqual(expected, actual, "Dog should say Woof!");
        }
        [Test]
        public void DogMakeSound()
        {
            string expected = "wof wof!";
            string actual = new Dog("").MakeSound();

            Assert.AreEqual(expected, actual, "Dog should say Woof!");
        }
        [Test]
        public void DogComeHere()
        {
            string expected = new Dog("") + " came to the owner.";
            string actual = new Dog("") + " came to the owner.";

            Assert.AreEqual(expected, actual, "Dog should come to the owner.");
        }
        [Test]
        public void CatTalkToOwnerReturnsMew()
        {
            string expected = "Mew!";
            string actual = new Cat("").TalkToOwner();

            Assert.AreEqual(expected, actual, "Cat should say Mew!");
        }
        [Test]
        public void CatMakeSound()
        {
            string expected = "Mew!";
            string actual = new Cat("").MakeSound();

            Assert.AreEqual(expected, actual, "Cat should say Mew!");
        }
        [Test]
        public void CatComeHere()
        {
            string expected = new Cat("") + " came to the owner.";
            string actual = new Cat("") + " came to the owner.";

            Assert.AreEqual(expected, actual, "Cat should come to the owner.");
        }
        [Test]
        public void BirdTalkToOwnerReturnsSqueek()
        {
            string expected = "Chirp!";
            string actual = new Bird("").TalkToOwner();

            Assert.AreEqual(expected, actual, "Bird should say Chirp!");
        }
        [Test]
        public void BirdMakeSound()
        {
            string expected = "Scree!";
            string actual = new Bird("").MakeSound();

            Assert.AreEqual(expected, actual, "Bird should say Scree!");
        }
        [Test]
        public void BirdComeHere()
        {
            string expected = new Bird("") + " came to the owner.";
            string actual = new Bird("") + " came to the owner.";

            Assert.AreEqual(expected, actual, "Bird should come to the owner.");
        }
        [Test]
        public void BearMakeSound()
        {
            string expected = "Growl!";
            string actual = new Bear().MakeSound();

            Assert.AreEqual(expected, actual, "Bear should say Growl!");
        }
        [Test]
        public void BearHunt()
        {
            string expected = "Bear hunts!";
            string actual = new Bear().Hunt();

            Assert.AreEqual(expected, actual, "Bear should hunt!");
        }
        [Test]
        public void TigerMakeSound()
        {
            string expected = "Roar!";
            string actual = new Tiger().MakeSound();

            Assert.AreEqual(expected, actual, "Tiger should say Roar!");
        }
        [Test]
        public void TigerHunt()
        {
            string expected = "Tiger hunts!";
            string actual = new Tiger().Hunt();

            Assert.AreEqual(expected, actual, "Tiger should hunt!");
        }
        [Test]

        public void WolfMakeSound()
        {
            string expected = "Howl!";
            string actual = new Wolf().MakeSound();

            Assert.AreEqual(expected, actual, "Wolf should say Howl!!");
        }
        [Test]
        public void WolfHunt()
        {
            string expected = "Wolf hunts!";
            string actual = new Wolf().Hunt();

            Assert.AreEqual(expected, actual, "Wolf should hunt!");
        }


    }
}