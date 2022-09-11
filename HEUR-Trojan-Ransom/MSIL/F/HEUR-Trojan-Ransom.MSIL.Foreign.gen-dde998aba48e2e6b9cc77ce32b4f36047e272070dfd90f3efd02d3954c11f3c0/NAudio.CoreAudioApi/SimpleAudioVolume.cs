using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.CoreAudioApi.Interfaces;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.CoreAudioApi;

public sealed class SimpleAudioVolume : IDisposable
{
	private readonly ISimpleAudioVolume simpleAudioVolume;

	[NonSerialized]
	internal static GetString _0010;

	public float Volume
	{
		get
		{
			Marshal.ThrowExceptionForHR(simpleAudioVolume.GetMasterVolume(out var levelNorm));
			return levelNorm;
		}
		set
		{
			if ((double)value >= 0.0 && (double)value <= 1.0)
			{
				Marshal.ThrowExceptionForHR(simpleAudioVolume.SetMasterVolume(value, Guid.Empty));
			}
		}
	}

	public bool Mute
	{
		get
		{
			Marshal.ThrowExceptionForHR(simpleAudioVolume.GetMute(out var isMuted));
			return isMuted;
		}
		set
		{
			Marshal.ThrowExceptionForHR(simpleAudioVolume.SetMute(value, Guid.Empty));
		}
	}

	internal SimpleAudioVolume(ISimpleAudioVolume realSimpleVolume)
	{
		simpleAudioVolume = realSimpleVolume;
	}

	public void Dispose()
	{
		GC.SuppressFinalize(this);
	}

	~SimpleAudioVolume()
	{
		Dispose();
	}

	static SimpleAudioVolume()
	{
		Strings.CreateGetStringDelegate(typeof(SimpleAudioVolume));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0010(107400155), _0010(107400118)), _0010(107400113), _0010(107400108)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0010(107400135)))
		{
			return;
		}
		throw new SecurityException(_0010(107400078));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
