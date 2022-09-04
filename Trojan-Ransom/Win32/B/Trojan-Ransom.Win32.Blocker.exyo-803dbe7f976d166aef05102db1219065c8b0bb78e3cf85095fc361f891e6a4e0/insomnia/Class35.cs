using System;
using System.Runtime.InteropServices;

namespace insomnia;

internal class Class35
{
	[Flags]
	internal enum Enum6
	{
		Field1 = 4
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool MoveFileEx(string A_0, string A_1, Enum6 A_2);

	public static bool Method1(string A_0)
	{
		if (!MoveFileEx(A_0, null, Enum6.Field1))
		{
			return false;
		}
		return true;
	}
}
