using System;
using WebFormIntelliTest.Util;
using System.Runtime.Remoting.Messaging;
using WebFormIntelliTest;
using Microsoft.Pex.Framework.Suppression;
// <copyright file="PexAssemblyInfo.cs">Copyright ©  2021</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("WebFormIntelliTest")]
[assembly: PexInstrumentAssembly("System.Web")]
[assembly: PexInstrumentAssembly("Microsoft.AspNet.FriendlyUrls")]
[assembly: PexInstrumentAssembly("System.Data")]
[assembly: PexInstrumentAssembly("System.Web.Optimization")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Web")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.AspNet.FriendlyUrls")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Data")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Web.Optimization")]
[assembly: PexSuppressExplorableEvent(typeof(Seeker_request_for_bloodBLL))]
[assembly: PexInstrumentType(typeof(CallContext))]
[assembly: PexSuppressUninstrumentedMethodFromType(typeof(CallContext))]
[assembly: PexSuppressExplorableEvent(typeof(Issue))]
[assembly: PexSuppressUninstrumentedMethodFromType(typeof(DateTime))]
[assembly: PexSuppressUninstrumentedMethodFromType(typeof(TimeZoneInfo))]
[assembly: PexSuppressExplorableEvent(typeof(DataProvider))]
[assembly: PexSuppressUninstrumentedMethodFromType("System.Runtime.Remoting.Messaging.IllogicalCallContext+Reader")]
[assembly: PexSuppressUninstrumentedMethodFromType("System.Runtime.Remoting.Messaging.LogicalCallContext+Reader")]
