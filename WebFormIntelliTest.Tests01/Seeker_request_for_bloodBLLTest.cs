// <copyright file="Seeker_request_for_bloodBLLTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;

namespace WebFormIntelliTest.Tests
{
    /// <summary>This class contains parameterized unit tests for Seeker_request_for_bloodBLL</summary>
    [TestClass]
    [PexClass(typeof(Seeker_request_for_bloodBLL))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Seeker_request_for_bloodBLLTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public Seeker_request_for_bloodBLL ConstructorTest()
        {
            Seeker_request_for_bloodBLL target = new Seeker_request_for_bloodBLL();
            return target;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.ConstructorTest()
        }

        /// <summary>Test stub for get_Blood_group()</summary>
        [PexMethod]
        public string Blood_groupGetTest([PexAssumeUnderTest] Seeker_request_for_bloodBLL target)
        {
            string result = target.Blood_group;
            return result;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.Blood_groupGetTest(Seeker_request_for_bloodBLL)
        }

        /// <summary>Test stub for get_Blood_quantity()</summary>
        [PexMethod]
        public string Blood_quantityGetTest([PexAssumeUnderTest] Seeker_request_for_bloodBLL target)
        {
            string result = target.Blood_quantity;
            return result;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.Blood_quantityGetTest(Seeker_request_for_bloodBLL)
        }

        /// <summary>Test stub for get_Mo_no()</summary>
        [PexMethod]
        public string Mo_noGetTest([PexAssumeUnderTest] Seeker_request_for_bloodBLL target)
        {
            string result = target.Mo_no;
            return result;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.Mo_noGetTest(Seeker_request_for_bloodBLL)
        }

        /// <summary>Test stub for get_Org_name()</summary>
        [PexMethod]
        public string Org_nameGetTest([PexAssumeUnderTest] Seeker_request_for_bloodBLL target)
        {
            string result = target.Org_name;
            return result;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.Org_nameGetTest(Seeker_request_for_bloodBLL)
        }

        /// <summary>Test stub for get_Remark()</summary>
        [PexMethod]
        public string RemarkGetTest([PexAssumeUnderTest] Seeker_request_for_bloodBLL target)
        {
            string result = target.Remark;
            return result;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.RemarkGetTest(Seeker_request_for_bloodBLL)
        }

        /// <summary>Test stub for get_Request()</summary>
        [PexMethod]
        public string RequestGetTest([PexAssumeUnderTest] Seeker_request_for_bloodBLL target)
        {
            string result = target.Request;
            return result;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.RequestGetTest(Seeker_request_for_bloodBLL)
        }

        /// <summary>Test stub for get_S_id()</summary>
        [PexMethod]
        public string S_idGetTest([PexAssumeUnderTest] Seeker_request_for_bloodBLL target)
        {
            string result = target.S_id;
            return result;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.S_idGetTest(Seeker_request_for_bloodBLL)
        }

        /// <summary>Test stub for get_S_name()</summary>
        [PexMethod]
        public string S_nameGetTest([PexAssumeUnderTest] Seeker_request_for_bloodBLL target)
        {
            string result = target.S_name;
            return result;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.S_nameGetTest(Seeker_request_for_bloodBLL)
        }

        /// <summary>Test stub for get_Status()</summary>
        [PexMethod]
        public bool StatusGetTest([PexAssumeUnderTest] Seeker_request_for_bloodBLL target)
        {
            bool result = target.Status;
            return result;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.StatusGetTest(Seeker_request_for_bloodBLL)
        }

        /// <summary>Test stub for insert(Seeker_request_for_bloodBLL)</summary>
        [PexMethod(MaxBranches = 20000)]
        public void insertTest(
            [PexAssumeUnderTest] Seeker_request_for_bloodBLL target,
            Seeker_request_for_bloodBLL objectBLL
        )
        {
            target.insert(objectBLL);
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.insertTest(Seeker_request_for_bloodBLL, Seeker_request_for_bloodBLL)
        }

        /// <summary>Test stub for set_Blood_group(String)</summary>
        [PexMethod]
        public void Blood_groupSetTest([PexAssumeUnderTest] Seeker_request_for_bloodBLL target, string value)
        {
            target.Blood_group = value;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.Blood_groupSetTest(Seeker_request_for_bloodBLL, String)
        }

        /// <summary>Test stub for set_Blood_quantity(String)</summary>
        [PexMethod]
        public void Blood_quantitySetTest([PexAssumeUnderTest] Seeker_request_for_bloodBLL target, string value)
        {
            target.Blood_quantity = value;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.Blood_quantitySetTest(Seeker_request_for_bloodBLL, String)
        }

        /// <summary>Test stub for set_Mo_no(String)</summary>
        [PexMethod]
        public void Mo_noSetTest([PexAssumeUnderTest] Seeker_request_for_bloodBLL target, string value)
        {
            target.Mo_no = value;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.Mo_noSetTest(Seeker_request_for_bloodBLL, String)
        }

        /// <summary>Test stub for set_Org_name(String)</summary>
        [PexMethod]
        public void Org_nameSetTest([PexAssumeUnderTest] Seeker_request_for_bloodBLL target, string value)
        {
            target.Org_name = value;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.Org_nameSetTest(Seeker_request_for_bloodBLL, String)
        }

        /// <summary>Test stub for set_Remark(String)</summary>
        [PexMethod]
        public void RemarkSetTest([PexAssumeUnderTest] Seeker_request_for_bloodBLL target, string value)
        {
            target.Remark = value;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.RemarkSetTest(Seeker_request_for_bloodBLL, String)
        }

        /// <summary>Test stub for set_Request(String)</summary>
        [PexMethod]
        public void RequestSetTest([PexAssumeUnderTest] Seeker_request_for_bloodBLL target, string value)
        {
            target.Request = value;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.RequestSetTest(Seeker_request_for_bloodBLL, String)
        }

        /// <summary>Test stub for set_S_id(String)</summary>
        [PexMethod]
        public void S_idSetTest([PexAssumeUnderTest] Seeker_request_for_bloodBLL target, string value)
        {
            target.S_id = value;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.S_idSetTest(Seeker_request_for_bloodBLL, String)
        }

        /// <summary>Test stub for set_S_name(String)</summary>
        [PexMethod]
        public void S_nameSetTest([PexAssumeUnderTest] Seeker_request_for_bloodBLL target, string value)
        {
            target.S_name = value;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.S_nameSetTest(Seeker_request_for_bloodBLL, String)
        }

        /// <summary>Test stub for set_Status(Boolean)</summary>
        [PexMethod]
        public void StatusSetTest([PexAssumeUnderTest] Seeker_request_for_bloodBLL target, bool value)
        {
            target.Status = value;
            // TODO: add assertions to method Seeker_request_for_bloodBLLTest.StatusSetTest(Seeker_request_for_bloodBLL, Boolean)
        }
    }
}
