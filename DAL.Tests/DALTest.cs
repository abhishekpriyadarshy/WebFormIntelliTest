using Models;
// <copyright file="DALTest.cs">Copyright ©  2015</copyright>

using System;
using DAL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DAL.Tests
{
    [TestClass]
    [PexClass(typeof(global::DAL.DAL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DALTest
    {

        [PexMethod]
        public uint HRA([PexAssumeUnderTest] global::DAL.DAL target, Employee e)
        {
            uint result = target.HRA(e);
            return result;
            // TODO: add assertions to method DALTest.HRA(DAL, Employee)
        }
    }
}
