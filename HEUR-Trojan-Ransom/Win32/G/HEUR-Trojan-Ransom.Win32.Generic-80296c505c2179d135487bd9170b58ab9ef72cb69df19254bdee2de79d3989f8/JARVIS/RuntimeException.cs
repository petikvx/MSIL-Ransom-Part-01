using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace JARVIS;

[StructLayout(LayoutKind.Sequential, Size = 16)]
[NativeCppClass]
[MiscellaneousBits(64)]
[DebugInfoInPDB]
internal struct RuntimeException
{
}
