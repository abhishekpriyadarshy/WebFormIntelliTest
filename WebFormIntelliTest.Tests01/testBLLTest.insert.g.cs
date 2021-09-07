using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;
// <copyright file="testBLLTest.insert.g.cs">Copyright ©  2021</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace WebFormIntelliTest.Tests
{
    public partial class testBLLTest
    {

[TestMethod]
[PexGeneratedBy(typeof(testBLLTest))]
public void insert205()
{
    testBLL testBLL;
    testBLL = new testBLL();
    testBLL.Name1 = "";
    testBLL.Status = false;
    this.insert(testBLL, testBLL);
    Assert.IsNotNull((object)testBLL);
    Assert.AreEqual<string>("", testBLL.Name1);
    Assert.AreEqual<string>("", testBLL.Name);
    Assert.AreEqual<bool>(false, testBLL.Status);
}

[TestMethod]
[PexGeneratedBy(typeof(testBLLTest))]
public void insert839()
{
    testBLL testBLL;
    testBLL = new testBLL();
    testBLL.Name1 = (string)null;
    testBLL.Status = false;
    this.insert(testBLL, (testBLL)null);
    Assert.IsNotNull((object)testBLL);
    Assert.AreEqual<string>((string)null, testBLL.Name1);
    Assert.AreEqual<string>((string)null, testBLL.Name);
    Assert.AreEqual<bool>(false, testBLL.Status);
}

[TestMethod]
[PexGeneratedBy(typeof(testBLLTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void insert704()
{
    testBLL testBLL;
    testBLL = new testBLL();
    testBLL.Name1 = (string)null;
    testBLL.Status = false;
    this.insert(testBLL, testBLL);
}
    }
}
