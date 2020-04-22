using System;
using Animals;
using NUnit.Framework;

public class AnimalTests
{
  // talk to owner
  [Test]
  public void DogTalkToOwnerReturnsWoof()
  {
    string expected = "Woof!";
    string actual = new Dog("Max").TalkToOwner();

    Assert.AreEqual(expected, actual, "Max is the name of the dog!");
  }

  [Test]
  public void CatTalkToOwnerReturnsMeow()
  {
    string expected = "Meow!";
    string actual = new Cat("Garfield").TalkToOwner();

    Assert.AreEqual(expected, actual, "Garfield is the name of the cat!");
  }

  [Test]
  public void BirdTalkToOwnerRreturnsMeow()
  {
    string expected = "Tweet!";
    string actual = new Bird("Roadrunner").TalkToOwner();

    Assert.AreEqual(expected, actual, "Bird does not say that!");
  }

  // make sound
  [Test]
  public void DogMakethisSound()
  {
    string expected = "Woof!";
    string actual = new Dog("Max").MakeSound();

    Assert.AreEqual(expected, actual, "Max is the name of the dog!");
  }

  [Test]
  public void CatMakeThisSound()
  {
    string expected = "Meow!";
    string actual = new Cat("Garfield").MakeSound();

    Assert.AreEqual(expected, actual, "Garfield is the name of the cat!");
  }

  [Test]
  public void BirdMakeThisSound()
  {
    string expected = "Tweet!";
    string actual = new Bird("Roadrunner").MakeSound();

    Assert.AreEqual(expected, actual, "Bird does not say that!");
  }

  [Test]
  public void BearMakeThisSound()
  {
    string expected = "Roar!";
    string actual = new Bear().MakeSound();

    Assert.AreEqual(expected, actual, "Bear does not say that!");
  }

  [Test]
  public void TigerMakeThisSound()
  {
    string expected = "Grrr!";
    string actual = new Tiger().MakeSound();

    Assert.AreEqual(expected, actual, "Tiger does not say that!");
  }

  [Test]
  public void WolfMakeThisSound()
  {
    string expected = "Owooooo!";
    string actual = new Wolf().MakeSound();

    Assert.AreEqual(expected, actual, "Wolf does not say that!");
  }
}