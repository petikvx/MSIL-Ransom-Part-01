using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Utils;

public static class BufferHelpers
{
	[NonSerialized]
	internal static GetString _009B;

	public static byte[] Ensure(byte[] buffer, int bytesRequired)
	{
		if (buffer == null || buffer.Length < bytesRequired)
		{
			buffer = new byte[bytesRequired];
		}
		return buffer;
	}

	public static float[] Ensure(float[] buffer, int samplesRequired)
	{
		if (buffer == null || buffer.Length < samplesRequired)
		{
			buffer = new float[samplesRequired];
		}
		return buffer;
	}

	static BufferHelpers()
	{
		Strings.CreateGetStringDelegate(typeof(BufferHelpers));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _009B(107399059), _009B(107399022)), _009B(107399017), _009B(107399012)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _009B(107399039)))
		{
			return;
		}
		throw new SecurityException(_009B(107398982));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
