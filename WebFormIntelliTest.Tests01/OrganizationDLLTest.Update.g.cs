using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;
// <copyright file="OrganizationDLLTest.Update.g.cs">Copyright ©  2021</copyright>
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
    public partial class OrganizationDLLTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(OrganizationDLLTest))]
        public void Update572()
        {
            OrganizationDLL organizationDLL;
            organizationDLL = new OrganizationDLL();
            this.Update(organizationDLL, (OrganizationBLL)null);
            Assert.IsNotNull((object)organizationDLL);
        }
    }
}
