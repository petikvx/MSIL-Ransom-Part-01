using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace JARVIS;

[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
[DebugInfoInPDB]
[MiscellaneousBits(64)]
internal struct RuntimeException
{
}
