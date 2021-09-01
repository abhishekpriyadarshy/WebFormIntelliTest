// <copyright file="UserTest.cs">Copyright ©  2021</copyright>

using System;
using CarsSystem.Data.Models;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarsSystem.Data.Models.Tests
{
    [TestClass]
    [PexClass(typeof(User))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UserTest
    {

        [PexMethod]
        public User Constructor()
        {
            User target = new User();
            return target;
            // TODO: add assertions to method UserTest.Constructor()
        }
    }
}
