using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.SoundFont;

public sealed class Preset
{
	private string name;

	private ushort patchNumber;

	private ushort bank;

	internal ushort startPresetZoneIndex;

	internal ushort endPresetZoneIndex;

	internal uint library;

	internal uint genre;

	internal uint morphology;

	private Zone[] zones;

	[NonSerialized]
	internal static GetString _0006;

	public string Name
	{
		get
		{
			return name;
		}
		set
		{
			name = value;
		}
	}

	public ushort PatchNumber
	{
		get
		{
			return patchNumber;
		}
		set
		{
			patchNumber = value;
		}
	}

	public ushort Bank
	{
		get
		{
			return bank;
		}
		set
		{
			bank = value;
		}
	}

	public Zone[] Zones
	{
		get
		{
			return zones;
		}
		set
		{
			zones = value;
		}
	}

	public override string ToString()
	{
		return string.Format(_0006(107394699), bank, patchNumber, name);
	}

	static Preset()
	{
		Strings.CreateGetStringDelegate(typeof(Preset));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(global::_0006._007E_001C(assembly), _0006(107397410), _0006(107397373)), _0006(107397368), _0006(107397363)));
		if (StrongNameSignatureVerificationEx(global::_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(global::_0006._007E_001E(assembly), _0006(107397390)))
		{
			return;
		}
		throw new SecurityException(_0006(107397333));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
