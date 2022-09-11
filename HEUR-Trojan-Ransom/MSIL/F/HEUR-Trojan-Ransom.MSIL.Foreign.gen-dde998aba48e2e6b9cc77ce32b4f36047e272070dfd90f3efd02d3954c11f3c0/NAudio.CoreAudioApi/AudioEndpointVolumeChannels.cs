using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.CoreAudioApi.Interfaces;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.CoreAudioApi;

public sealed class AudioEndpointVolumeChannels
{
	private readonly IAudioEndpointVolume audioEndPointVolume;

	private readonly AudioEndpointVolumeChannel[] channels;

	[NonSerialized]
	internal static GetString _0001;

	public int Count
	{
		get
		{
			Marshal.ThrowExceptionForHR(audioEndPointVolume.GetChannelCount(out var pnChannelCount));
			return pnChannelCount;
		}
	}

	public AudioEndpointVolumeChannel this[int index] => channels[index];

	internal AudioEndpointVolumeChannels(IAudioEndpointVolume parent)
	{
		audioEndPointVolume = parent;
		int count = Count;
		channels = new AudioEndpointVolumeChannel[count];
		for (int i = 0; i < count; i++)
		{
			channels[i] = new AudioEndpointVolumeChannel(audioEndPointVolume, i);
		}
	}

	static AudioEndpointVolumeChannels()
	{
		Strings.CreateGetStringDelegate(typeof(AudioEndpointVolumeChannels));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0001(107400078), _0001(107400041)), _0001(107400036), _0001(107400031)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0001(107400058)))
		{
			return;
		}
		throw new SecurityException(_0001(107400001));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
