// <copyright file="Seeker_request_for_bloodDLLTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    [TestClass]
    [PexClass(typeof(Seeker_request_for_bloodDLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Seeker_request_for_bloodDLLTest
    {

        [PexMethod]
        public void insert(
            [PexAssumeUnderTest] Seeker_request_for_bloodDLL target,
            Seeker_request_for_bloodBLL objectBLL
        )
        {
            target.insert(objectBLL);
            // TODO: add assertions to method Seeker_request_for_bloodDLLTest.insert(Seeker_request_for_bloodDLL, Seeker_request_for_bloodBLL)
        }
    }
}
