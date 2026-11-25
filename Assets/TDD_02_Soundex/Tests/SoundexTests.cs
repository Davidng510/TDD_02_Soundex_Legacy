using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Soundex
{
    public string Encode(string word)
    {
        return word + "000";
    }
}
public class SoundexTests
{
    private Soundex s;

    [SetUp]
    public void SetUp()
    {
        s= new Soundex();
    }
    // A Test behaves as an ordinary method
    [Test]
    public void SoundexTestsSimplePasses()
    {
       Assert.AreEqual(s.Encode("A"), "A000");
       Assert.AreEqual(s.Encode("I"), "I000");
    }

    [Test]

    public void Replace_Consonants_SpecifiedDigits()
    {
        Assert.AreEqual("A100", s.Encode("Ab"));
    }

}
