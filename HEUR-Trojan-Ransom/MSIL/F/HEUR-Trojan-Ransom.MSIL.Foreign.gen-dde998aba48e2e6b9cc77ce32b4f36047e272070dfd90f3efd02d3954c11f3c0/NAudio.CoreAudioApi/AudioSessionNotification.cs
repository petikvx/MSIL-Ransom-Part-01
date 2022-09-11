using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.CoreAudioApi.Interfaces;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.CoreAudioApi;

internal sealed class AudioSessionNotification : IAudioSessionNotification
{
	private AudioSessionManager parent;

	[NonSerialized]
	internal static GetString _0099;

	internal AudioSessionNotification(AudioSessionManager parent)
	{
		this.parent = parent;
	}

	[PreserveSig]
	public int OnSessionCreated(IAudioSessionControl newSession)
	{
		parent.FireSessionCreated(newSession);
		return 0;
	}

	static AudioSessionNotification()
	{
		Strings.CreateGetStringDelegate(typeof(AudioSessionNotification));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0099(107400104), _0099(107400067)), _0099(107400062), _0099(107400057)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0099(107400084)))
		{
			return;
		}
		throw new SecurityException(_0099(107400027));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
