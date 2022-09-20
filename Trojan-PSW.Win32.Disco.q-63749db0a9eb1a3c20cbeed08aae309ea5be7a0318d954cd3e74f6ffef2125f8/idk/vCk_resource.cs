using System;
using System.Runtime.InteropServices;
using ns0;

namespace idk;

internal class vCk_resource
{
	public static bool vCk;

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string lpModuleName);

	public unsafe static void vC()
	{
		//Discarded unreachable code: IL_000c
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected F8, but got Unknown
		_003F val = ~/*Error near IL_0001: Stack underflow*/;
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = (double)val;
		checked
		{
			_ = (ushort)/*Error near IL_0003: ldloc 0 (out-of-bounds)*/;
			_ = 0;
			/*Error near IL_0007: Invalid metadata token*/;
		}
	}

	public extern vCk_resource();

	static IntPtr smethod_0(string string_0)
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return Delegate39.delegate39_1(string_0);
	}
}
