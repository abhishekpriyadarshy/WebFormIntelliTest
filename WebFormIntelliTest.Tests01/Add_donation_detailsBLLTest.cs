// <copyright file="Add_donation_detailsBLLTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    /// <summary>This class contains parameterized unit tests for Add_donation_detailsBLL</summary>
    [TestClass]
    [PexClass(typeof(Add_donation_detailsBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Add_donation_detailsBLLTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public Add_donation_detailsBLL ConstructorTest()
        {
            Add_donation_detailsBLL target = new Add_donation_detailsBLL();
            return target;
            // TODO: add assertions to method Add_donation_detailsBLLTest.ConstructorTest()
        }

        /// <summary>Test stub for get_Blood_group()</summary>
        [PexMethod]
        public string Blood_groupGetTest([PexAssumeUnderTest] Add_donation_detailsBLL target)
        {
            string result = target.Blood_group;
            return result;
            // TODO: add assertions to method Add_donation_detailsBLLTest.Blood_groupGetTest(Add_donation_detailsBLL)
        }

        /// <summary>Test stub for get_Blood_quantity()</summary>
        [PexMethod]
        public string Blood_quantityGetTest([PexAssumeUnderTest] Add_donation_detailsBLL target)
        {
            string result = target.Blood_quantity;
            return result;
            // TODO: add assertions to method Add_donation_detailsBLLTest.Blood_quantityGetTest(Add_donation_detailsBLL)
        }

        /// <summary>Test stub for get_D_id()</summary>
        [PexMethod]
        public string D_idGetTest([PexAssumeUnderTest] Add_donation_detailsBLL target)
        {
            string result = target.D_id;
            return result;
            // TODO: add assertions to method Add_donation_detailsBLLTest.D_idGetTest(Add_donation_detailsBLL)
        }

        /// <summary>Test stub for get_D_name()</summary>
        [PexMethod]
        public string D_nameGetTest([PexAssumeUnderTest] Add_donation_detailsBLL target)
        {
            string result = target.D_name;
            return result;
            // TODO: add assertions to method Add_donation_detailsBLLTest.D_nameGetTest(Add_donation_detailsBLL)
        }

        /// <summary>Test stub for get_Select_org()</summary>
        [PexMethod]
        public string Select_orgGetTest([PexAssumeUnderTest] Add_donation_detailsBLL target)
        {
            string result = target.Select_org;
            return result;
            // TODO: add assertions to method Add_donation_detailsBLLTest.Select_orgGetTest(Add_donation_detailsBLL)
        }

        /// <summary>Test stub for get_Status()</summary>
        [PexMethod]
        public bool StatusGetTest([PexAssumeUnderTest] Add_donation_detailsBLL target)
        {
            bool result = target.Status;
            return result;
            // TODO: add assertions to method Add_donation_detailsBLLTest.StatusGetTest(Add_donation_detailsBLL)
        }

        /// <summary>Test stub for insert(Add_donation_detailsBLL)</summary>
        [PexMethod]
        public void insertTest([PexAssumeUnderTest] Add_donation_detailsBLL target, Add_donation_detailsBLL objectBLL)
        {
            target.insert(objectBLL);
            // TODO: add assertions to method Add_donation_detailsBLLTest.insertTest(Add_donation_detailsBLL, Add_donation_detailsBLL)
        }

        /// <summary>Test stub for set_Blood_group(String)</summary>
        [PexMethod]
        public void Blood_groupSetTest([PexAssumeUnderTest] Add_donation_detailsBLL target, string value)
        {
            target.Blood_group = value;
            // TODO: add assertions to method Add_donation_detailsBLLTest.Blood_groupSetTest(Add_donation_detailsBLL, String)
        }

        /// <summary>Test stub for set_Blood_quantity(String)</summary>
        [PexMethod]
        public void Blood_quantitySetTest([PexAssumeUnderTest] Add_donation_detailsBLL target, string value)
        {
            target.Blood_quantity = value;
            // TODO: add assertions to method Add_donation_detailsBLLTest.Blood_quantitySetTest(Add_donation_detailsBLL, String)
        }

        /// <summary>Test stub for set_D_id(String)</summary>
        [PexMethod]
        public void D_idSetTest([PexAssumeUnderTest] Add_donation_detailsBLL target, string value)
        {
            target.D_id = value;
            // TODO: add assertions to method Add_donation_detailsBLLTest.D_idSetTest(Add_donation_detailsBLL, String)
        }

        /// <summary>Test stub for set_D_name(String)</summary>
        [PexMethod]
        public void D_nameSetTest([PexAssumeUnderTest] Add_donation_detailsBLL target, string value)
        {
            target.D_name = value;
            // TODO: add assertions to method Add_donation_detailsBLLTest.D_nameSetTest(Add_donation_detailsBLL, String)
        }

        /// <summary>Test stub for set_Select_org(String)</summary>
        [PexMethod]
        public void Select_orgSetTest([PexAssumeUnderTest] Add_donation_detailsBLL target, string value)
        {
            target.Select_org = value;
            // TODO: add assertions to method Add_donation_detailsBLLTest.Select_orgSetTest(Add_donation_detailsBLL, String)
        }

        /// <summary>Test stub for set_Status(Boolean)</summary>
        [PexMethod]
        public void StatusSetTest([PexAssumeUnderTest] Add_donation_detailsBLL target, bool value)
        {
            target.Status = value;
            // TODO: add assertions to method Add_donation_detailsBLLTest.StatusSetTest(Add_donation_detailsBLL, Boolean)
        }
    }
}
