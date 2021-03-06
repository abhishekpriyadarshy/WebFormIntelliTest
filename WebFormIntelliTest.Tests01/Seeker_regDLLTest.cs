// <copyright file="Seeker_regDLLTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    [TestClass]
    [PexClass(typeof(Seeker_regDLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Seeker_regDLLTest
    {

        [PexMethod]
        public void insert([PexAssumeUnderTest] Seeker_regDLL target, Seeker_regBLL objectBLL)
        {
            target.insert(objectBLL);
            // TODO: add assertions to method Seeker_regDLLTest.insert(Seeker_regDLL, Seeker_regBLL)
        }
    }
}
