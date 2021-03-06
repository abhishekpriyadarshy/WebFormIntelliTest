using Models;
// <copyright file="HRAexemptionCalculatorTest.cs">Copyright ©  2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxCalculators;

namespace TaxCalculators.Tests
{
    [TestClass]
    [PexClass(typeof(HRAexemptionCalculator))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class HRAexemptionCalculatorTest
    {

        [PexMethod]
        public uint calculate(
            [PexAssumeUnderTest] HRAexemptionCalculator target,
            bool IsRented,
            Location location,
            uint AnnualBasicSalary,
            uint MonthlyRent,
            uint AnnualHouseRentAllowance
        )
        {
            uint result
               = target.calculate(IsRented, location, AnnualBasicSalary, MonthlyRent, AnnualHouseRentAllowance);
            return result;
            // TODO: add assertions to method HRAexemptionCalculatorTest.calculate(HRAexemptionCalculator, Boolean, Location, UInt32, UInt32, UInt32)
        }

        /// <summary>Test stub for calculate(Boolean, Location, UInt32, UInt32, UInt32)</summary>
        [PexMethod]
        [PexAllowedException(typeof(InvalidLocationException))]
        public uint calculateTest(
            [PexAssumeUnderTest] HRAexemptionCalculator target,
            bool IsRented,
            Location location,
            uint AnnualBasicSalary,
            uint MonthlyRent,
            uint AnnualHouseRentAllowance
        )
        {
            uint result
               = target.calculate(IsRented, location, AnnualBasicSalary, MonthlyRent, AnnualHouseRentAllowance);
            return result;
            // TODO: add assertions to method HRAexemptionCalculatorTest.calculateTest(HRAexemptionCalculator, Boolean, Location, UInt32, UInt32, UInt32)
        }
    }
}
