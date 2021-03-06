﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Web;
using Glimpse.Core.Extensibility;
using Glimpse.EF;

[assembly: ComVisible(false)]
[assembly: Guid("6F3F9D55-2BE0-47E8-83D2-0F488504CF4A")]

[assembly: AssemblyTitle("Glimpse for EF 4.3 Assembly")]
[assembly: AssemblyDescription("Main extensibility implementations for running Glimpse with EF 4.3.")]
[assembly: AssemblyProduct("Glimpse.EF43")]
[assembly: AssemblyCopyright("© 2012 Nik Molnar & Anthony van der Hoorn")]
[assembly: AssemblyTrademark("Glimpse™")]

// Version is in major.minor.build format to support http://semver.org/
// Keep these three attributes in sync
[assembly: AssemblyVersion("1.3.1")]
[assembly: AssemblyFileVersion("1.3.1")]
[assembly: AssemblyInformationalVersion("1.3.1")] // Used to specify the NuGet version number at build time

[assembly: InternalsVisibleTo("Glimpse.Test.EF")]
[assembly: NuGetPackage("Glimpse.EF6")]
[assembly: PreApplicationStartMethod(typeof(Initialize), "Start")]