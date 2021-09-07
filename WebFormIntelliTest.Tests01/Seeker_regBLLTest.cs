// <copyright file="Seeker_regBLLTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    [TestClass]
    [PexClass(typeof(Seeker_regBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Seeker_regBLLTest
    {

        [PexMethod]
        public void insert([PexAssumeUnderTest] Seeker_regBLL target, Seeker_regBLL objectBLL)
        {
            target.insert(objectBLL);
            // TODO: add assertions to method Seeker_regBLLTest.insert(Seeker_regBLL, Seeker_regBLL)
        }
    }
}
