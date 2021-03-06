// <copyright file="AuthHelperTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest.Util;

namespace WebFormIntelliTest.Util.Tests
{
    [TestClass]
    [PexClass(typeof(AuthHelper))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AuthHelperTest
    {

        [PexMethod]
        public bool SignIn(
            [PexAssumeUnderTest] AuthHelper target,
            string userName,
            string password
        )
        {
            bool result = target.SignIn(userName, password);
            return result;
            // TODO: add assertions to method AuthHelperTest.SignIn(AuthHelper, String, String)
        }

        [PexMethod]
        public void SignOut([PexAssumeUnderTest] AuthHelper target)
        {
            target.SignOut();
            // TODO: add assertions to method AuthHelperTest.SignOut(AuthHelper)
        }
    }
}
