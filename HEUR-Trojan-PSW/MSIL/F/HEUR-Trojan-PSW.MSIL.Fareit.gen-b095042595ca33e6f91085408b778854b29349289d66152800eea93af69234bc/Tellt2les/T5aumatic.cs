using System;
using System.Runtime.InteropServices;

namespace Tellt2les;

public static class T5aumatic
{
	[DllImport("kernel32")]
	public static extern IntPtr GetProcAddress(IntPtr Lo8otypies, string A7chente7ons);

	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_0);

	[DllImport("kernel32")]
	public static extern bool VirtualProtect(IntPtr Aggran3ize3, uint P3ults, uint Over4axa4ion, out uint Mucos4);
}
