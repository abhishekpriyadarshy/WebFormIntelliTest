using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
// <copyright file="InvalidRentExceptionTest.Constructor.g.cs">Copyright ©  2015</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace Models.Tests
{
    public partial class InvalidRentExceptionTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(InvalidRentExceptionTest))]
        public void Constructor550()
        {
            InvalidRentException invalidRentException;
            invalidRentException = this.Constructor((string)null);
            Assert.IsNotNull((object)invalidRentException);
            Assert.IsNull(((Exception)invalidRentException).InnerException);
            Assert.AreEqual<int>(-2146233088, ((Exception)invalidRentException).HResult);
        }
    }
}
