using System;
using System.Runtime.InteropServices;

internal sealed class Class0
{
	private static IntPtr intptr_0 = IntPtr.Zero;

	private static bool bool_0 = false;

	private static void smethod_0()
	{
		if (!bool_0)
		{
			Class8.Struct1 struct1_ = default(Class8.Struct1);
			intptr_0 = Class8.SHGetFileInfo(".txt", 128u, out struct1_, (uint)Marshal.SizeOf((object)struct1_), (Class8.Enum4)16401);
			if (intptr_0.Equals((object?)(nint)IntPtr.Zero))
			{
				throw new Exception("Unable to retrieve system image list handle.");
			}
			bool_0 = true;
		}
	}

	public static void smethod_1(IntPtr intptr_1)
	{
		smethod_0();
		int num = Class8.SendMessage(intptr_1, 4361u, 0u, intptr_0);
		if (num != 0)
		{
			Marshal.ThrowExceptionForHR(num);
		}
	}
}
