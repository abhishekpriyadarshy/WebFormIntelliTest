// <copyright file="Add_cityBLLTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    [TestClass]
    [PexClass(typeof(Add_cityBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Add_cityBLLTest
    {

        [PexMethod]
        public void insert([PexAssumeUnderTest] Add_cityBLL target, Add_cityBLL objectBLL)
        {
            target.insert(objectBLL);
            // TODO: add assertions to method Add_cityBLLTest.insert(Add_cityBLL, Add_cityBLL)
        }
    }
}
