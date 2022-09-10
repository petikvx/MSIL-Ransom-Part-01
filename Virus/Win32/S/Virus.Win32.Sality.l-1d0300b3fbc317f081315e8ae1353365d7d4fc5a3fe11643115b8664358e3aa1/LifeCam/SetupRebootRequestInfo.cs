using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace LifeCam;

[StructLayout(LayoutKind.Sequential, Size = 4)]
[DebugInfoInPDB]
[MiscellaneousBits(64)]
[NativeCppClass]
internal struct SetupRebootRequestInfo
{
}
