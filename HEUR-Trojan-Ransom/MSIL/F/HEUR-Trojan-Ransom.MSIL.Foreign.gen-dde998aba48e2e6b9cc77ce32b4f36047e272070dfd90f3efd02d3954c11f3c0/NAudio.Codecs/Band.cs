using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Codecs;

public sealed class Band
{
	public int s;

	public int sp;

	public int sz;

	public int[] r = new int[3];

	public int[] a = new int[3];

	public int[] ap = new int[3];

	public int[] p = new int[3];

	public int[] d = new int[7];

	public int[] b = new int[7];

	public int[] bp = new int[7];

	public int[] sg = new int[7];

	public int nb;

	public int det;

	[NonSerialized]
	internal static GetString _0080;

	static Band()
	{
		Strings.CreateGetStringDelegate(typeof(Band));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0080(107400341), _0080(107400304)), _0080(107400299), _0080(107400294)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0080(107400321)))
		{
			return;
		}
		throw new SecurityException(_0080(107400264));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
