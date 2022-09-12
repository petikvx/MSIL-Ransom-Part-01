using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace WindowsFormsApp21;

[StructLayout(LayoutKind.Sequential, Size = 1)]
public struct Win32
{
	public static byte[] BUFFER;

	public static List<MethodInfo> METHODS;
}
