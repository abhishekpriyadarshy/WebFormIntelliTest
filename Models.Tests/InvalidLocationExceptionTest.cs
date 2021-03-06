// <copyright file="InvalidLocationExceptionTest.cs">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace Models.Tests
{
    [TestClass]
    [PexClass(typeof(InvalidLocationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class InvalidLocationExceptionTest
    {

        [PexMethod]
        public InvalidLocationException Constructor(string message)
        {
            InvalidLocationException target = new InvalidLocationException(message);
            return target;
            // TODO: add assertions to method InvalidLocationExceptionTest.Constructor(String)
        }
    }
}
