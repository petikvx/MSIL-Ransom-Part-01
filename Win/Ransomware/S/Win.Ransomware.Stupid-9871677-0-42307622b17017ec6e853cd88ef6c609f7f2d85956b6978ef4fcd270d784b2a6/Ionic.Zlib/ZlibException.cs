using System;
using System.Runtime.InteropServices;

namespace Ionic.Zlib;

[Guid("ebc25cf6-9120-4283-b972-0e5520d0000E")]
public class ZlibException : Exception
{
	public extern ZlibException();

	public unsafe ZlibException(string s)
	{
		//Discarded unreachable code: IL_0006, IL_0009, IL_0011, IL_0017, IL_001c, IL_0022, IL_0027, IL_002a, IL_0031, IL_0038
		//IL_0008: Expected I4, but got O
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}
}
