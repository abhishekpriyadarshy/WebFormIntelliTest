// <copyright file="Add_stateDLLTest.cs">Copyright ©  2021</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    /// <summary>This class contains parameterized unit tests for Add_stateDLL</summary>
    [PexClass(typeof(global::Add_stateDLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class Add_stateDLLTest
    {
        /// <summary>Test stub for insert(Add_stateBLL)</summary>
        [PexMethod]
        public void insertTest([PexAssumeUnderTest]global::Add_stateDLL target, Add_stateBLL objectBLL)
        {
            target.insert(objectBLL);
            // TODO: add assertions to method Add_stateDLLTest.insertTest(Add_stateDLL, Add_stateBLL)
        }
    }
}
