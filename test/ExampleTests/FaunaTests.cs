using System;
using NUnit.Framework;
using Animals;

namespace Animals
{
    public class PetTests
    {
     /* [Setup]
      public void Setup()
      {

      }*/
        [Test]
        public void DogTalkToOwnerReturnsWoof()
        {
            string expected = "Woof!";
            string actual = new Dog().TalkToOwner();

            Assert.AreEqual(expected, actual, "Dog should say Woof!");
        }
        [Test]
        public void CatTalkToOwnerReturnsWoof()
        {
            string expected = "Mew!";
            string actual = new Cat().TalkToOwner();

            Assert.AreEqual(expected, actual, "Cat should say Mew!");
        }
        [Test]
        public void BirdTalkToOwnerReturnsSqueek()
        {
            string expected = "Chirp!";
            string actual = new Bird().TalkToOwner();

            Assert.AreEqual(expected, actual, "Bird should say Chirp!");
        }
        public void BearMakeSound()
        {
            string expected = "Growl!";
            string actual = new Bear().MakeSound();

            Assert.AreEqual(expected, actual, "Bear should say Growl!");
        }
        public void TigerMakeSound()
        {
            string expected = "Roar!";
            string actual = new Tiger().MakeSound();

            Assert.AreEqual(expected, actual, "Tiger should say Roar!");
        }
        public void WolfMakeSound()
        {
            string expected = "Howl!";
            string actual = new Wolf().MakeSound();

            Assert.AreEqual(expected, actual, "Wolf should say Howl!!");
        }


    }
}