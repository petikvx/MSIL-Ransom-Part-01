using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class SampleEventArgs : EventArgs
{
	[NonSerialized]
	internal static GetString _001B;

	public float Left { get; set; }

	public float Right { get; set; }

	public SampleEventArgs(float left, float right)
	{
		Left = left;
		Right = right;
	}

	static SampleEventArgs()
	{
		Strings.CreateGetStringDelegate(typeof(SampleEventArgs));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _001B(107398426), _001B(107398389)), _001B(107398384), _001B(107398379)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _001B(107398406)))
		{
			return;
		}
		throw new SecurityException(_001B(107398349));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
