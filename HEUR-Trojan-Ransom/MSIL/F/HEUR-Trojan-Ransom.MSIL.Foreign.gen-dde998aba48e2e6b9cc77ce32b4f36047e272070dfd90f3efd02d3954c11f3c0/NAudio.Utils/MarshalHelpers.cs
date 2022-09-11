using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Utils;

public static class MarshalHelpers
{
	[NonSerialized]
	internal static GetString _0012;

	public static int SizeOf<T>()
	{
		return Marshal.SizeOf(typeof(T));
	}

	public static IntPtr OffsetOf<T>(string fieldName)
	{
		return Marshal.OffsetOf(typeof(T), fieldName);
	}

	public static T PtrToStructure<T>(IntPtr pointer)
	{
		return (T)Marshal.PtrToStructure(pointer, typeof(T));
	}

	static MarshalHelpers()
	{
		Strings.CreateGetStringDelegate(typeof(MarshalHelpers));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0012(107399057), _0012(107399020)), _0012(107399015), _0012(107399010)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0012(107399037)))
		{
			return;
		}
		throw new SecurityException(_0012(107398980));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
