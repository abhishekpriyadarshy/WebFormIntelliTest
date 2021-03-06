// <copyright file="testDLLTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    [TestClass]
    [PexClass(typeof(testDLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class testDLLTest
    {

        [PexMethod]
        public void insert([PexAssumeUnderTest] testDLL target, testBLL objectBLL)
        {
            target.insert(objectBLL);
            // TODO: add assertions to method testDLLTest.insert(testDLL, testBLL)
        }
    }
}
