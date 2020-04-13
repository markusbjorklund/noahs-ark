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
    string actual = new Bird().TalkToOwner();

    Assert.AreEqual(expected, actual);
  }
    [Test]
  public void SnakeTalkToOwnerReturnsSssss()
  {
    string expected = "Sssssss!";
    string actual = new Snake().TalkToOwner();

    Assert.AreEqual(expected, actual);
  }
}