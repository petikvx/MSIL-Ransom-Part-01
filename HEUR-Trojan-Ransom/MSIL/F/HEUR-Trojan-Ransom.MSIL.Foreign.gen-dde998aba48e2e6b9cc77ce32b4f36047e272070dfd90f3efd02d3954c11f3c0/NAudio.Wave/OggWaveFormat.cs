using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
internal sealed class OggWaveFormat : WaveFormat
{
	public uint dwVorbisACMVersion;

	public uint dwLibVorbisVersion;

	[NonSerialized]
	internal static GetString _0089;

	static OggWaveFormat()
	{
		Strings.CreateGetStringDelegate(typeof(OggWaveFormat));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0089(107397918), _0089(107397881)), _0089(107397876), _0089(107397871)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0089(107397898)))
		{
			return;
		}
		throw new SecurityException(_0089(107397841));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
