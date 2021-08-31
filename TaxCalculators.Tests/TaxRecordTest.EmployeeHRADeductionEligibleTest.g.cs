using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using DAL;
using TaxCalculators;
// <copyright file="TaxRecordTest.EmployeeHRADeductionEligibleTest.g.cs">Copyright ©  2015</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TaxCalculators.Tests
{
    public partial class TaxRecordTest
    {

[TestMethod]
[PexGeneratedBy(typeof(TaxRecordTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void EmployeeHRADeductionEligibleTestThrowsNullReferenceException464()
{
    TaxRecord taxRecord;
    bool b;
    taxRecord = new TaxRecord((IDAL)null);
    b = this.EmployeeHRADeductionEligibleTest(taxRecord, (Employee)null);
}
    }
}
