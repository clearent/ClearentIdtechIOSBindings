using System.Reflection;
using System.Runtime.CompilerServices;
using ObjCRuntime;
using Foundation;

// This attribute allows you to mark your assemblies as “safe to link”. 
// When the attribute is present, the linker—if enabled—will process the assembly 
// even if you’re using the “Link SDK assemblies only” option, which is the default for device builds.

//[assembly: LinkWith ("ClearentIdtechIOSFramework.framework", SmartLink = true, ForceLoad = true)]

[assembly: LinkWith("ClearentIdtechIOSFramework.framework", LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Arm64 | LinkTarget.Simulator64, SmartLink = true, LinkerFlags = "-lxml2 -ObjC -dead_strip", ForceLoad = true)]
//Frameworks = "QuartzCore CoreText CoreGraphics CoreImage UIKit"
// Information about this assembly is defined by the following attributes. 
// Change them to the values specific to your project.

[assembly: AssemblyTitle("ClearentIdtechIOSFramework.Bindings")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("ClearentIdtechIOSFramework.Bindings")]
[assembly: AssemblyCopyright("Copyright ©  2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// The following attributes are used to specify the signing key for the assembly, 
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]