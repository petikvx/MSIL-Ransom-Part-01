using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns7;

internal sealed class Class108
{
	public byte[] byte_0;

	public int int_0;

	public int int_1;

	[NonSerialized]
	internal static GetString getString_0;

	public Class108(int int_2, int int_3, byte[] byte_1)
	{
		int_0 = int_2;
		int_1 = int_3;
		byte_0 = byte_1;
	}

	static Class108()
	{
		Strings.CreateGetStringDelegate(typeof(Class108));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397980), getString_0(107397975)).Replace(getString_0(107397938), getString_0(107397933)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397928)))
		{
			throw new SecurityException(getString_0(107397903));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
