using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest;
// <copyright file="Ad_cityDLLTest.insert.g.cs">Copyright ©  2021</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace WebFormIntelliTest.Tests
{
    public partial class Ad_cityDLLTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(Ad_cityDLLTest))]
        public void insert579()
        {
            Ad_cityDLL ad_cityDLL;
            ad_cityDLL = new Ad_cityDLL();
            this.insert(ad_cityDLL, (Add_cityBLL)null);
            Assert.IsNotNull((object)ad_cityDLL);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(Ad_cityDLLTest))]
        [Ignore]
        [PexDescription("the test state was: path bounds exceeded")]
        public void insert31()
        {
            Ad_cityDLL ad_cityDLL;
            Add_cityBLL add_cityBLL;
            ad_cityDLL = new Ad_cityDLL();
            add_cityBLL = new Add_cityBLL();
            add_cityBLL.City_name = (string)null;
            add_cityBLL.Country = "";
            add_cityBLL.State = (string)null;
            add_cityBLL.Status = false;
            this.insert(ad_cityDLL, add_cityBLL);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(Ad_cityDLLTest))]
        public void insert251()
        {
            Ad_cityDLL ad_cityDLL;
            Add_cityBLL add_cityBLL;
            ad_cityDLL = new Ad_cityDLL();
            add_cityBLL = new Add_cityBLL();
            add_cityBLL.City_name = (string)null;
            add_cityBLL.Country = "";
            add_cityBLL.State = "";
            add_cityBLL.Status = false;
            this.insert(ad_cityDLL, add_cityBLL);
            Assert.IsNotNull((object)ad_cityDLL);
        }
    }
}
