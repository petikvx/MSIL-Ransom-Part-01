using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.CoreAudioApi.Interfaces;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.CoreAudioApi;

public sealed class AudioEndpointVolumeVolumeRange
{
	private readonly float volumeMinDecibels;

	private readonly float volumeMaxDecibels;

	private readonly float volumeIncrementDecibels;

	[NonSerialized]
	internal static GetString _0011;

	public float MinDecibels => volumeMinDecibels;

	public float MaxDecibels => volumeMaxDecibels;

	public float IncrementDecibels => volumeIncrementDecibels;

	internal AudioEndpointVolumeVolumeRange(IAudioEndpointVolume parent)
	{
		Marshal.ThrowExceptionForHR(parent.GetVolumeRange(out volumeMinDecibels, out volumeMaxDecibels, out volumeIncrementDecibels));
	}

	static AudioEndpointVolumeVolumeRange()
	{
		Strings.CreateGetStringDelegate(typeof(AudioEndpointVolumeVolumeRange));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0011(107400084), _0011(107400047)), _0011(107400042), _0011(107400037)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0011(107400064)))
		{
			return;
		}
		throw new SecurityException(_0011(107400007));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
