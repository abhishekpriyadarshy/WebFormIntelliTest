// <copyright file="EmployeeTest.cs">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace Models.Tests
{
    [TestClass]
    [PexClass(typeof(Employee))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class EmployeeTest
    {

        [PexMethod]
        public House PropertyGet([PexAssumeUnderTest] Employee target)
        {
            House result = target.Property;
            return result;
            // TODO: add assertions to method EmployeeTest.PropertyGet(Employee)
        }
    }
}
