using System.Reflection;
using System.Collections.Generic;
// <copyright file="AppointmentDataSourceHelperTest.cs">Copyright ©  2021</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormIntelliTest.Util;

namespace WebFormIntelliTest.Util.Tests
{
    [TestClass]
    [PexClass(typeof(AppointmentDataSourceHelper))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AppointmentDataSourceHelperTest
    {

        [PexMethod]
        [PexMethodUnderTest("UpdateAppointments(List`1<SchedulerAppointment>)")]
        internal void UpdateAppointments([PexAssumeUnderTest] AppointmentDataSourceHelper target, List<SchedulerAppointment> list)
        {
            object[] args = new object[1];
            args[0] = (object)list;
            Type[] parameterTypes = new Type[1];
            parameterTypes[0] = typeof(List<SchedulerAppointment>);
            object result = ((MethodBase)(typeof(AppointmentDataSourceHelper).GetMethod("UpdateAppointments",
                                                                                        BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                                        CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method AppointmentDataSourceHelperTest.UpdateAppointments(AppointmentDataSourceHelper, List`1<SchedulerAppointment>)
        }
    }
}
