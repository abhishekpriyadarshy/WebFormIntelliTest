using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest.Util;
// <copyright file="AuthHelperTest.SignOut.g.cs">Copyright ©  2021</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace WebFormIntelliTest.Util.Tests
{
    public partial class AuthHelperTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(AuthHelperTest))]
        [PexRaisedException(typeof(NullReferenceException))]
        public void SignOutThrowsNullReferenceException478()
        {
            AuthHelper s0 = new AuthHelper();
            this.SignOut(s0);
        }
    }
}
