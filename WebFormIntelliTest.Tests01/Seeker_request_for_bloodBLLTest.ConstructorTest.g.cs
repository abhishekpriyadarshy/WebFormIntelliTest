using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;
// <copyright file="Seeker_request_for_bloodBLLTest.ConstructorTest.g.cs">Copyright ©  2021</copyright>
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
    public partial class Seeker_request_for_bloodBLLTest
    {

[TestMethod]
[PexGeneratedBy(typeof(Seeker_request_for_bloodBLLTest))]
public void ConstructorTest762()
{
    Seeker_request_for_bloodBLL seeker_request_for_bloodBLL;
    seeker_request_for_bloodBLL = this.ConstructorTest();
    Assert.IsNotNull((object)seeker_request_for_bloodBLL);
    Assert.AreEqual<string>((string)null, seeker_request_for_bloodBLL.S_name);
    Assert.AreEqual<string>((string)null, seeker_request_for_bloodBLL.S_id);
    Assert.AreEqual<string>((string)null, seeker_request_for_bloodBLL.Mo_no);
    Assert.AreEqual<string>((string)null, seeker_request_for_bloodBLL.Org_name);
    Assert.AreEqual<string>((string)null, seeker_request_for_bloodBLL.Blood_group);
    Assert.AreEqual<string>
        ((string)null, seeker_request_for_bloodBLL.Blood_quantity);
    Assert.AreEqual<string>((string)null, seeker_request_for_bloodBLL.Request);
    Assert.AreEqual<string>((string)null, seeker_request_for_bloodBLL.Remark);
    Assert.AreEqual<bool>(false, seeker_request_for_bloodBLL.Status);
}
    }
}
