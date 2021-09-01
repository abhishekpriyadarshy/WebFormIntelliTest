// <copyright file="Doner_regDLLTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    [TestClass]
    [PexClass(typeof(Doner_regDLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Doner_regDLLTest
    {

        [PexMethod]
        public void insert([PexAssumeUnderTest] Doner_regDLL target, Doner_regBLL objectBLL)
        {
            target.insert(objectBLL);
            // TODO: add assertions to method Doner_regDLLTest.insert(Doner_regDLL, Doner_regBLL)
        }
    }
}
