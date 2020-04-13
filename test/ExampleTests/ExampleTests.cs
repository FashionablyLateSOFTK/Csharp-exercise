using System;
using NUnit.Framework;
using Pets;

public class PetTests
{
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
}