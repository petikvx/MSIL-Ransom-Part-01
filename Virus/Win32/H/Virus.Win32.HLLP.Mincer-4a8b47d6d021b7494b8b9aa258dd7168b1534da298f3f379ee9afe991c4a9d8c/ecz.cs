using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

[StructLayout(LayoutKind.Sequential, Size = 4)]
[NativeCppClass]
[MiscellaneousBits(64)]
[DebugInfoInPDB]
internal struct ecz
{
	[SpecialName]
	public unsafe static void a(ecz* pEcz_0, ecz* pEcz_1)
	{
		_003CModule_003E.b(pEcz_0, pEcz_1);
	}

	[SpecialName]
	public unsafe static void a(ecz* pEcz_0)
	{
		_003CModule_003E.b(pEcz_0);
	}
}
