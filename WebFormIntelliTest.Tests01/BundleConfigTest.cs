using System.Web.Optimization;
// <copyright file="BundleConfigTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    [TestClass]
    [PexClass(typeof(BundleConfig))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class BundleConfigTest
    {

        [PexMethod]
        public void RegisterBundles(BundleCollection bundles)
        {
            BundleConfig.RegisterBundles(bundles);
            // TODO: add assertions to method BundleConfigTest.RegisterBundles(BundleCollection)
        }
    }
}
