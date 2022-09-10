using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 12)]
[NativeCppClass]
[DebugInfoInPDB]
[MiscellaneousBits(64)]
internal struct bad_alloc
{
}
