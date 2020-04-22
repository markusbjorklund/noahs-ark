using System;
using NUnit.Framework;
using Animals;

public class AnimalTests
{
  [Test]
  public void DogTalkToOwnerReturnsWoof()
  {
    string expected = "Woof!";
    string actual = new Dog().TalkToOwner();

    Assert.AreEqual(expected, actual);
  }

  [Test]
  public void CatTalkToOwnerReturnsMeow()
  {
    string expected = "Meow!";
    string actual = new Cat().TalkToOwner();

    Assert.AreEqual(expected, actual);
  }
    [Test]
  public void BirdTalkToOwnerReturnTweet()
  {
    string expected = "Tweet!";
    string actual = new Bird("Roadrunner").TalkToOwner();

    Assert.AreEqual(expected, actual, "Bird does not say that!");
  }
}