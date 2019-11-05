using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("IrobotBox.Configuration.Tom ConfigurationProvider")]
[assembly: AssemblyCompany("IrobotBox Technology Co., Ltd")]

[assembly: AssemblyVersion(
    ThisAssembly.Git.SemVer.Major + "." +
    ThisAssembly.Git.SemVer.Minor
)]

[assembly: AssemblyFileVersion(
    ThisAssembly.Git.SemVer.Major + "." +
    ThisAssembly.Git.SemVer.Minor + "." +
    ThisAssembly.Git.SemVer.Patch
)]

[assembly: AssemblyInformationalVersion(
    ThisAssembly.Git.SemVer.Major + "." +
    ThisAssembly.Git.SemVer.Minor + "." +
    ThisAssembly.Git.SemVer.Patch + "-" +
    ThisAssembly.Git.Branch + "+" +
    ThisAssembly.Git.Commit
)]