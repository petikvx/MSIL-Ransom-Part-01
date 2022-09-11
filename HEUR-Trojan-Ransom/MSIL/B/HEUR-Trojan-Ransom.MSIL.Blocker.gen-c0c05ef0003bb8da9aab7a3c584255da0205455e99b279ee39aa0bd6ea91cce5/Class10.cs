using System;
using System.Runtime.InteropServices;

internal sealed class Class10
{
	private const string string_0 = "{00AAC56B-CD44-11d0-8CC2-00C04FC295EE}";

	private static readonly IntPtr intptr_0;

	[DllImport("wintrust.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	private static extern Enum7 WinVerifyTrust([In] IntPtr intptr_1, [In][MarshalAs(UnmanagedType.LPStruct)] Guid guid_0, [In] Class9 class9_0);

	public static bool smethod_0(string string_1)
	{
		return (bool)Class28.smethod_0(4832800, null, string_1);
	}

	private Class10()
	{
	}

	static Class10()
	{
		Class28.smethod_0(4825335, null, null);
	}
}
