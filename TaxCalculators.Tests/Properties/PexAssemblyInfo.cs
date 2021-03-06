using Microsoft.Pex.Engine.Symbols;
using System;
using Microsoft.Pex.Framework.Suppression;
// <copyright file="PexAssemblyInfo.cs">Copyright ©  2015</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("TaxCalculators")]
[assembly: PexInstrumentAssembly("DAL")]
[assembly: PexInstrumentAssembly("Models")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "DAL")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Models")]
[assembly: PexSuppressUninstrumentedMethodFromType(typeof(Math))]
[assembly: PexSuppressUninstrumentedMethodFromType(typeof(__TestabilityHelper))]
[assembly: PexSuppressUninstrumentedMethodFromType(typeof(__LimitationsHelper))]
