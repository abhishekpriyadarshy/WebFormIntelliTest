// <copyright file="testBLLTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    [TestClass]
    [PexClass(typeof(testBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class testBLLTest
    {

        [PexMethod]
        public void insert([PexAssumeUnderTest] testBLL target, testBLL objectBLL)
        {
            target.insert(objectBLL);
            // TODO: add assertions to method testBLLTest.insert(testBLL, testBLL)
        }
    }
}
