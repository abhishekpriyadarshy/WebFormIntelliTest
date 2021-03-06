using System.Reflection;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WebFormIntelliTest.Util;
// <copyright file="AppointmentDataSourceHelperTest.UpdateAppointments.g.cs">Copyright ©  2021</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace WebFormIntelliTest.Util.Tests
{
    public partial class AppointmentDataSourceHelperTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(AppointmentDataSourceHelperTest))]
        [PexRaisedException(typeof(TargetInvocationException))]
        public void UpdateAppointmentsThrowsTargetInvocationException170()
        {
            AppointmentDataSourceHelper s0 = new AppointmentDataSourceHelper();
            this.UpdateAppointments(s0, (List<SchedulerAppointment>)null);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(AppointmentDataSourceHelperTest))]
        [PexRaisedException(typeof(TargetInvocationException))]
        public void UpdateAppointmentsThrowsTargetInvocationException549()
        {
            List<SchedulerAppointment> list;
            SchedulerAppointment[] schedulerAppointments = new SchedulerAppointment[1];
            list = new List<SchedulerAppointment>
                       ((IEnumerable<SchedulerAppointment>)schedulerAppointments);
            AppointmentDataSourceHelper s0 = new AppointmentDataSourceHelper();
            this.UpdateAppointments(s0, list);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(AppointmentDataSourceHelperTest))]
        [PexRaisedException(typeof(TargetInvocationException))]
        public void UpdateAppointmentsThrowsTargetInvocationException821()
        {
            List<SchedulerAppointment> list;
            SchedulerAppointment[] schedulerAppointments = new SchedulerAppointment[0];
            list = new List<SchedulerAppointment>
                       ((IEnumerable<SchedulerAppointment>)schedulerAppointments);
            AppointmentDataSourceHelper s0 = new AppointmentDataSourceHelper();
            this.UpdateAppointments(s0, list);
        }
    }
}
