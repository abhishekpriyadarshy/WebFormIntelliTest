// <copyright file="InvalidRentExceptionTest.cs">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace Models.Tests
{
    [TestClass]
    [PexClass(typeof(InvalidRentException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class InvalidRentExceptionTest
    {

        [PexMethod]
        public InvalidRentException Constructor(string message)
        {
            InvalidRentException target = new InvalidRentException(message);
            return target;
            // TODO: add assertions to method InvalidRentExceptionTest.Constructor(String)
        }
    }
}
