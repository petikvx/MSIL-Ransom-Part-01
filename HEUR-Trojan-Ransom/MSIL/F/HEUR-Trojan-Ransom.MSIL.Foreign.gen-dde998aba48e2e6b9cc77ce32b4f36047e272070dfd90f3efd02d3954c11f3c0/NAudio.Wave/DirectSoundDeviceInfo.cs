using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class DirectSoundDeviceInfo
{
	[NonSerialized]
	internal static GetString _008E;

	public Guid Guid { get; set; }

	public string Description { get; set; }

	public string ModuleName { get; set; }

	static DirectSoundDeviceInfo()
	{
		Strings.CreateGetStringDelegate(typeof(DirectSoundDeviceInfo));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _008E(107398237), _008E(107398200)), _008E(107398195), _008E(107398190)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _008E(107398217)))
		{
			return;
		}
		throw new SecurityException(_008E(107398160));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
