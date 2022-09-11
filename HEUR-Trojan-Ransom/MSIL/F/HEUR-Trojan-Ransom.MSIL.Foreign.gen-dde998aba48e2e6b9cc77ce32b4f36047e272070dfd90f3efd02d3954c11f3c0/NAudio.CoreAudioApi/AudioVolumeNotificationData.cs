using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.CoreAudioApi;

public sealed class AudioVolumeNotificationData
{
	private readonly Guid eventContext;

	private readonly bool muted;

	private readonly float masterVolume;

	private readonly int channels;

	private readonly float[] channelVolume;

	private readonly Guid guid;

	[NonSerialized]
	internal static GetString _0099;

	public Guid EventContext => eventContext;

	public bool Muted => muted;

	public Guid Guid => guid;

	public float MasterVolume => masterVolume;

	public int Channels => channels;

	public float[] ChannelVolume => channelVolume;

	public AudioVolumeNotificationData(Guid eventContext, bool muted, float masterVolume, float[] channelVolume, Guid guid)
	{
		this.eventContext = eventContext;
		this.muted = muted;
		this.masterVolume = masterVolume;
		channels = channelVolume.Length;
		this.channelVolume = channelVolume;
		this.guid = guid;
	}

	static AudioVolumeNotificationData()
	{
		Strings.CreateGetStringDelegate(typeof(AudioVolumeNotificationData));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0099(107400122), _0099(107400085)), _0099(107400080), _0099(107400075)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0099(107400102)))
		{
			return;
		}
		throw new SecurityException(_0099(107400045));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
