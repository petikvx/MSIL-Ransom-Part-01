using System.Runtime.InteropServices;
using System.Security;

namespace ns0;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 180)]
internal struct Struct2
{
	[SecuritySafeCritical]
	static Struct2()
	{
		Class7.smethod_6();
	}
}
