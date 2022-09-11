using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class StoppedEventArgs : EventArgs
{
	private readonly Exception exception;

	[NonSerialized]
	internal static GetString _0018;

	public Exception Exception => exception;

	public StoppedEventArgs(Exception exception = null)
	{
		this.exception = exception;
	}

	static StoppedEventArgs()
	{
		Strings.CreateGetStringDelegate(typeof(StoppedEventArgs));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0018(107398151), _0018(107398114)), _0018(107398109), _0018(107398104)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0018(107398131)))
		{
			return;
		}
		throw new SecurityException(_0018(107398074));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
