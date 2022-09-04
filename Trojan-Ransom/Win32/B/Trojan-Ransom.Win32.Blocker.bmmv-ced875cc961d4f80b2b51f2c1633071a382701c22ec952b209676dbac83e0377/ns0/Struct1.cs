using System.Runtime.InteropServices;
using System.Security;

namespace ns0;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 470)]
internal struct Struct1
{
	[SecuritySafeCritical]
	static Struct1()
	{
		Class8.smethod_6();
	}
}
