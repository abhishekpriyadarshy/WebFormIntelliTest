using System.Reflection;
// <copyright file="CustomerDetailsTest.cs">Copyright ©  2021</copyright>

using System;
using CarsSystem.WebForms.Client.Customers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarsSystem.WebForms.Client.Customers.Tests
{
    [TestClass]
    [PexClass(typeof(CustomerDetails))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CustomerDetailsTest
    {

        [PexMethod]
        [PexMethodUnderTest("Page_Load(Object, EventArgs)")]
        internal void Page_Load(
            [PexAssumeUnderTest] CustomerDetails target,
            object sender,
            EventArgs e
        )
        {
            object[] args = new object[2];
            args[0] = sender;
            args[1] = (object)e;
            Type[] parameterTypes = new Type[2];
            parameterTypes[0] = typeof(object);
            parameterTypes[1] = typeof(EventArgs);
            object result = ((MethodBase)(typeof(CustomerDetails).GetMethod("Page_Load",
                                                                            BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                            CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method CustomerDetailsTest.Page_Load(CustomerDetails, Object, EventArgs)
        }
    }
}
