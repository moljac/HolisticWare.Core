#if XUNITusing Xunit;// NUnit aliasesusing Test = Xunit.FactAttribute;using OneTimeSetUp = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;// XUnit aliasesusing TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;#elif NUNITusing NUnit.Framework;// MSTest aliasesusing TestInitialize = NUnit.Framework.SetUpAttribute;using TestProperty = NUnit.Framework.PropertyAttribute;using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;using TestMethod = NUnit.Framework.TestAttribute;using TestCleanup = NUnit.Framework.TearDownAttribute;// XUnit aliasesusing Fact = NUnit.Framework.TestAttribute;#elif MSTESTusing Microsoft.VisualStudio.TestTools.UnitTesting;// NUnit aliasesusing Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;// XUnit aliasesusing Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;#endif#if BENCHMARKDOTNETusing BenchmarkDotNet.Running;using BenchmarkDotNet.Configs;using BenchmarkDotNet.Attributes.Jobs;#elseusing Benchmark = HolisticWare.Core.Testing.BenchmarkTests.Benchmark;using ShortRunJob = HolisticWare.Core.Testing.BenchmarkTests.ShortRunJob;#endifusing System;using System.Collections.Generic;using System.Text;using System.Collections;using System.Linq;using Core;namespace Tests.CommonShared.Core{    public partial class UnitTests_VersionSemantic    {        [Test()]        public void String_As_Memory_Clone_Unit_Test()        {
            VersionSemantic version_semantic;            // Assert            #if NUNIT            CollectionAssert.AreEqual                                    (
                                        new int[] { 1, 2 },
                                        new int[] { 1, 2 }
                                    );            #elif XUNIT            Assert.Equal                                    (                                        new int[] { 1, 2 },
                                        new int[] { 1, 2 }
                                    );            #elif MSTEST            CollectionAssert.AreEqual                                    (                                        new int[] { 1, 2 },
                                        new int[] { 1, 2 }
                                    );            #endif            return;        }     }}