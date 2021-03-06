using Microsoft.ExtendedReflection.DataAccess;
// <copyright file="Add_countryBLLTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    /// <summary>This class contains parameterized unit tests for Add_countryBLL</summary>
    [TestClass]
    [PexClass(typeof(Add_countryBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Add_countryBLLTest
    {

        /// <summary>Test stub for insert(Add_countryBLL)</summary>
        [PexMethod(MaxBranches = 20000)]
        [PexAllowedException(typeof(TermDestructionException))]
        public void insertTest([PexAssumeUnderTest] Add_countryBLL target, Add_countryBLL objectBLL)
        {
            target.insert(objectBLL);
            // TODO: add assertions to method Add_countryBLLTest.insertTest(Add_countryBLL, Add_countryBLL)
        }

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public Add_countryBLL ConstructorTest()
        {
            Add_countryBLL target = new Add_countryBLL();
            return target;
            // TODO: add assertions to method Add_countryBLLTest.ConstructorTest()
        }

        /// <summary>Test stub for get_Country_name()</summary>
        [PexMethod]
        public string Country_nameGetTest([PexAssumeUnderTest] Add_countryBLL target)
        {
            string result = target.Country_name;
            return result;
            // TODO: add assertions to method Add_countryBLLTest.Country_nameGetTest(Add_countryBLL)
        }

        /// <summary>Test stub for get_Status()</summary>
        [PexMethod]
        public bool StatusGetTest([PexAssumeUnderTest] Add_countryBLL target)
        {
            bool result = target.Status;
            return result;
            // TODO: add assertions to method Add_countryBLLTest.StatusGetTest(Add_countryBLL)
        }


        /// <summary>Test stub for set_Country_name(String)</summary>
        [PexMethod]
        public void Country_nameSetTest([PexAssumeUnderTest] Add_countryBLL target, string value)
        {
            target.Country_name = value;
            // TODO: add assertions to method Add_countryBLLTest.Country_nameSetTest(Add_countryBLL, String)
        }

        /// <summary>Test stub for set_Status(Boolean)</summary>
        [PexMethod]
        public void StatusSetTest([PexAssumeUnderTest] Add_countryBLL target, bool value)
        {
            target.Status = value;
            // TODO: add assertions to method Add_countryBLLTest.StatusSetTest(Add_countryBLL, Boolean)
        }
    }
}
