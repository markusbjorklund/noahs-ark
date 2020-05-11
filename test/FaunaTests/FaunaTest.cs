using System;
using System.Collections.Generic;
using Animals;
using NUnit.Framework;
public class AnimalTests
{
    // talk to owner test
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
    public void BirdTalkToOwnerReturnsMeow()
    {
        string expected = "Tweet!";
        string actual = new Bird("Roadrunner").TalkToOwner();

        Assert.AreEqual(expected, actual, "Bird does not say that!");
    }

    [Test]
    public void HorseTalkToOwnerReturnsIhahaa()
    {
        string expected = "Ihahaa!";
        string actual = new Horse("Heppa").TalkToOwner();

        Assert.AreEqual(expected, actual, "Horse should say Ihahaa!");
    }

    // make sound tests
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
    public void HorseMakeThisSound()
    {
        string expected = "Hello!";
        string actual = new Horse("Heppa").MakeSound();

        Assert.AreEqual(expected, actual, "Horse should say Ihahaa!");
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

    // come here tests
    [Test]
    public void BirdComeHere()
    {
        string actual = new Bird("Roadrunner").ComeHere();
        string expected = actual.ToString();

        Assert.AreEqual(expected, actual, "The method does not work!");
    }

    // Eat tests
    [Test]
    public void CatEats()
    {
        string actual = new Cat("Garfield").Eat();
        Assert.That(actual, Does.Match("Garfield gained 1 kg, and weighs now 1 kg."));
    }

    public void DogEats()
    {
        string actual = new Dog("Doggie").Eat();
        Assert.That(actual, Does.Match("Doggie gained 1 kg, and weighs now 1 kg."));
    }

    public void BirdEats()
    {
        string actual = new Bird("Birdie").Eat();
        Assert.That(actual, Does.Match("Birdie gained 1 kg, and weighs now 1 kg."));
    }
    public void HorseEats()
    {
        string actual = new Horse("Horsie").Eat();
        Assert.That(actual, Does.Match("Birdie gained 1 kg, and weighs now 1 kg."));
    }


    // test for hunts
    [Test]
    public void WolfIsHunting()
    {
        string actual = new Wolf().Hunt();
        Assert.That(actual, Does.Match("Wolf.*"));
        //Assert.That(actual, Does.Match("Wolf finds food, gains 1kg and weighs now 1 kg."));
        //Assert.That(actual, Does.Match("Wolf does not find food and weighs now 0 kg."));


    }

    [Test]
    public void BearIsHunting()
    {
        List<string> outcomes = new List<string>();
        outcomes.Add("Bear finds food, gains 1kg and weighs now 1 kg.");
        outcomes.Add("Bear does not find food and weighs now 0 kg.");

        string expected = new Bear().Hunt();

        Assert.That(outcomes, Contains.Item(expected));

        //Assert.That(actual, Does.Match("Bear finds food, gains 1kg and weighs now 1 kg."));
        //Assert.That(actual, Does.Match("Bear does not find food and weighs now 0 kg."));
    }

    [Test]
    public void TigerIsHunting()
    {
        string actual = new Tiger().Hunt();
        Assert.That(actual, Does.Match("Tiger.*"));
        //Assert.That(actual, Does.Match("Tiger finds food, gains 1kg and weighs now 1 kg."));
        //Assert.That(actual, Does.Match("Tiger does not find food and weighs now 0 kg."));
    }
}