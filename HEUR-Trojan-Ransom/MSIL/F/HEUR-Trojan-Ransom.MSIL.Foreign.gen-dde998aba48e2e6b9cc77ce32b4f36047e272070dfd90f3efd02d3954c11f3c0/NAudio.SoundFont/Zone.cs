using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.SoundFont;

public sealed class Zone
{
	internal ushort generatorIndex;

	internal ushort modulatorIndex;

	internal ushort generatorCount;

	internal ushort modulatorCount;

	private Modulator[] modulators;

	private Generator[] generators;

	[NonSerialized]
	internal static GetString _0096;

	public Modulator[] Modulators
	{
		get
		{
			return modulators;
		}
		set
		{
			modulators = value;
		}
	}

	public Generator[] Generators
	{
		get
		{
			return generators;
		}
		set
		{
			generators = value;
		}
	}

	public override string ToString()
	{
		return string.Format(_0096(107393343), generatorCount, generatorIndex, modulatorCount, modulatorIndex);
	}

	static Zone()
	{
		Strings.CreateGetStringDelegate(typeof(Zone));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0096(107397467), _0096(107397430)), _0096(107397425), _0096(107397420)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0096(107397447)))
		{
			return;
		}
		throw new SecurityException(_0096(107397390));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
