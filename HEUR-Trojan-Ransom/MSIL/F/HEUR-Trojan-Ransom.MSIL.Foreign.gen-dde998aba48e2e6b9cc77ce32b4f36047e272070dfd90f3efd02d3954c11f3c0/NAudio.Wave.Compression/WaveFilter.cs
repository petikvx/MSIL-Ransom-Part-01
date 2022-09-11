using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.Compression;

[StructLayout(LayoutKind.Sequential)]
public sealed class WaveFilter
{
	public int StructureSize = Marshal.SizeOf(typeof(WaveFilter));

	public int FilterTag;

	public int Filter;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
	public int[] Reserved;

	[NonSerialized]
	internal static GetString _0082;

	static WaveFilter()
	{
		Strings.CreateGetStringDelegate(typeof(WaveFilter));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0082(107398904), _0082(107398867)), _0082(107398862), _0082(107398857)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0082(107398884)))
		{
			return;
		}
		throw new SecurityException(_0082(107398827));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
