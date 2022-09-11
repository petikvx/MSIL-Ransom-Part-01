using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.CoreAudioApi.Interfaces;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.CoreAudioApi;

public sealed class AudioSessionEventsCallback : IAudioSessionEvents
{
	private readonly IAudioSessionEventsHandler audioSessionEventsHandler;

	[NonSerialized]
	internal static GetString _0016;

	public AudioSessionEventsCallback(IAudioSessionEventsHandler handler)
	{
		audioSessionEventsHandler = handler;
	}

	public int OnDisplayNameChanged([In][MarshalAs(UnmanagedType.LPWStr)] string displayName, [In] ref Guid eventContext)
	{
		audioSessionEventsHandler.OnDisplayNameChanged(displayName);
		return 0;
	}

	public int OnIconPathChanged([In][MarshalAs(UnmanagedType.LPWStr)] string iconPath, [In] ref Guid eventContext)
	{
		audioSessionEventsHandler.OnIconPathChanged(iconPath);
		return 0;
	}

	public int OnSimpleVolumeChanged([In][MarshalAs(UnmanagedType.R4)] float volume, [In][MarshalAs(UnmanagedType.Bool)] bool isMuted, [In] ref Guid eventContext)
	{
		audioSessionEventsHandler.OnVolumeChanged(volume, isMuted);
		return 0;
	}

	public int OnChannelVolumeChanged([In][MarshalAs(UnmanagedType.U4)] uint channelCount, [In][MarshalAs(UnmanagedType.SysInt)] IntPtr newVolumes, [In][MarshalAs(UnmanagedType.U4)] uint channelIndex, [In] ref Guid eventContext)
	{
		audioSessionEventsHandler.OnChannelVolumeChanged(channelCount, newVolumes, channelIndex);
		return 0;
	}

	public int OnGroupingParamChanged([In] ref Guid groupingId, [In] ref Guid eventContext)
	{
		audioSessionEventsHandler.OnGroupingParamChanged(ref groupingId);
		return 0;
	}

	public int OnStateChanged([In] AudioSessionState state)
	{
		audioSessionEventsHandler.OnStateChanged(state);
		return 0;
	}

	public int OnSessionDisconnected([In] AudioSessionDisconnectReason disconnectReason)
	{
		audioSessionEventsHandler.OnSessionDisconnected(disconnectReason);
		return 0;
	}

	static AudioSessionEventsCallback()
	{
		Strings.CreateGetStringDelegate(typeof(AudioSessionEventsCallback));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0016(107400095), _0016(107400058)), _0016(107400053), _0016(107400048)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0016(107400075)))
		{
			return;
		}
		throw new SecurityException(_0016(107400018));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
