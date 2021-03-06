// <copyright file="Ad_cityDLLTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    [TestClass]
    [PexClass(typeof(Ad_cityDLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Ad_cityDLLTest
    {

        [PexMethod(MaxBranches = 20000)]
        public void insert([PexAssumeUnderTest] Ad_cityDLL target, Add_cityBLL objectBLL)
        {
            target.insert(objectBLL);
            // TODO: add assertions to method Ad_cityDLLTest.insert(Ad_cityDLL, Add_cityBLL)
        }
    }
}
