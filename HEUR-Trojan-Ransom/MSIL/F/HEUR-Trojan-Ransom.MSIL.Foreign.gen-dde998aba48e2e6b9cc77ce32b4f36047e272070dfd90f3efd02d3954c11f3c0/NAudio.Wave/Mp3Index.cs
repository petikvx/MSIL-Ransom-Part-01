using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

internal sealed class Mp3Index
{
	[NonSerialized]
	internal static GetString _007F;

	public long FilePosition { get; set; }

	public long SamplePosition { get; set; }

	public int SampleCount { get; set; }

	public int ByteCount { get; set; }

	static Mp3Index()
	{
		Strings.CreateGetStringDelegate(typeof(Mp3Index));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _007F(107398446), _007F(107398409)), _007F(107398404), _007F(107398399)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _007F(107398426)))
		{
			return;
		}
		throw new SecurityException(_007F(107398369));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
