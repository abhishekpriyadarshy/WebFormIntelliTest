using Models;
// <copyright file="TaxCalculatorTest.cs">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxCalculators;

namespace TaxCalculators.Tests
{
    /// <summary>This class contains parameterized unit tests for TaxCalculator</summary>
    [TestClass]
    [PexClass(typeof(TaxCalculator))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TaxCalculatorTest
    {

        /// <summary>Test stub for CalculateExemptionForRent(Employee, ITaxCalculator)</summary>
        [PexMethod]
        public uint CalculateExemptionForRentTest(
            [PexAssumeUnderTest] TaxCalculator target,
            Employee employee,
            ITaxCalculator ic
        )
        {
            uint result = target.CalculateExemptionForRent(employee, ic);
            return result;
            // TODO: add assertions to method TaxCalculatorTest.CalculateExemptionForRentTest(TaxCalculator, Employee, ITaxCalculator)
        }
    }
}
