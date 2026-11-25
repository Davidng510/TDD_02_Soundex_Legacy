using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Soundex
{
    public string Encode(string word)
    {
        return "";
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
       Assert.AreEqual("A", s.Encode("A"));
       Assert.AreEqual("I", s.Encode("I"));
    }

}
