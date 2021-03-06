// <copyright file="IssueTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest.Util;

namespace WebFormIntelliTest.Util.Tests
{
    [TestClass]
    [PexClass(typeof(Issue))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IssueTest
    {

        [PexMethod]
        public void SetCustomer([PexAssumeUnderTest] Issue target, Contact value)
        {
            target.SetCustomer(value);
            // TODO: add assertions to method IssueTest.SetCustomer(Issue, Contact)
        }

        [PexMethod]
        public void Assign([PexAssumeUnderTest] Issue target, Issue src)
        {
            target.Assign(src);
            // TODO: add assertions to method IssueTest.Assign(Issue, Issue)
        }
    }
}
