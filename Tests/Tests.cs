using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling;
using System.Collections.Generic;

namespace Tests;

[TestClass]
public class Tests
{
    [TestMethod]
    public void TestSuiteCanRun()
    {
        Assert.AreEqual(1,1);
    }
    [TestMethod]
    public void TestSutieCanReferenceCode()
    {
        AClass testClass = new AClass();
        Assert.IsNotNull(testClass);
    }
}