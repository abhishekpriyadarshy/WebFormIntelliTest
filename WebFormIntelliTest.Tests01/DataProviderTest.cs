using System.Reflection;
using System.Collections.Generic;
// <copyright file="DataProviderTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest.Util;

namespace WebFormIntelliTest.Util.Tests
{
    [TestClass]
    [PexClass(typeof(DataProvider))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DataProviderTest
    {

        [PexMethod]
        [PexMethodUnderTest("GenerateContacts()")]
        internal List<Contact> GenerateContacts([PexAssumeUnderTest] DataProvider target)
        {
            object[] args = new object[0];
            Type[] parameterTypes = new Type[0];
            List<Contact> result0 = ((MethodBase)(typeof(DataProvider).GetMethod("GenerateContacts",
                                                                                 BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                                 CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                        .Invoke((object)target, args) as List<Contact>;
            List<Contact> result = result0;
            return result;
            // TODO: add assertions to method DataProviderTest.GenerateContacts(DataProvider)
        }

        [PexMethod]
        public void UpdateIssue([PexAssumeUnderTest] DataProvider target, Issue issue)
        {
            target.UpdateIssue(issue);
            // TODO: add assertions to method DataProviderTest.UpdateIssue(DataProvider, Issue)
        }

        [PexMethod]
        public List<Contact> GetContacts([PexAssumeUnderTest] DataProvider target)
        {
            List<Contact> result = target.GetContacts();
            return result;
            // TODO: add assertions to method DataProviderTest.GetContacts(DataProvider)
        }

        /// <summary>Test stub for AddNewIssue(Issue)</summary>
        [PexMethod]
        public void AddNewIssueTest([PexAssumeUnderTest] DataProvider target, Issue issue)
        {
            target.AddNewIssue(issue);
            // TODO: add assertions to method DataProviderTest.AddNewIssueTest(DataProvider, Issue)
        }
    }
}
