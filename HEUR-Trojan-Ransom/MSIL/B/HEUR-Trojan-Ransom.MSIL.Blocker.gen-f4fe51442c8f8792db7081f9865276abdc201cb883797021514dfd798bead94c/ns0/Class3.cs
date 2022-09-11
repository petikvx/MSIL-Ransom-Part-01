using System.Runtime.InteropServices;

namespace ns0;

internal static class Class3
{
	[return: MarshalAs(UnmanagedType.U1)]
	internal static bool smethod_0(ushort ushort_0)
	{
		return (ushort_0 & 0xF800) == 55296;
	}
}
