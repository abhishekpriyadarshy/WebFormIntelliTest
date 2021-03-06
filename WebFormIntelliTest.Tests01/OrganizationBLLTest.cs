// <copyright file="OrganizationBLLTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    [TestClass]
    [PexClass(typeof(OrganizationBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class OrganizationBLLTest
    {

        [PexMethod]
        public void insert([PexAssumeUnderTest] OrganizationBLL target, OrganizationBLL objectBLL)
        {
            target.insert(objectBLL);
            // TODO: add assertions to method OrganizationBLLTest.insert(OrganizationBLL, OrganizationBLL)
        }
    }
}
