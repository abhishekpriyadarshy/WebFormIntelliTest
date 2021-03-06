// <copyright file="TaxRecordTest.cs">Copyright ©  2015</copyright>
using System;
using DAL;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using TaxCalculators;

namespace TaxCalculators.Tests
{
    /// <summary>This class contains parameterized unit tests for TaxRecord</summary>
    [PexClass(typeof(TaxRecord))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class TaxRecordTest
    {
        /// <summary>Test stub for .ctor(IDAL)</summary>
        [PexMethod]
        public TaxRecord ConstructorTest(IDAL id)
        {
            TaxRecord target = new TaxRecord(id);
            return target;
            // TODO: add assertions to method TaxRecordTest.ConstructorTest(IDAL)
        }

        /// <summary>Test stub for EmployeeHRADeductionEligible(Employee)</summary>
        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        public bool EmployeeHRADeductionEligibleTest([PexAssumeUnderTest]TaxRecord target, Employee employee)
        {
            bool result = target.EmployeeHRADeductionEligible(employee);
            return result;
            // TODO: add assertions to method TaxRecordTest.EmployeeHRADeductionEligibleTest(TaxRecord, Employee)
        }
    }
}
