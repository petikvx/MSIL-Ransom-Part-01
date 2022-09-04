using System;
using System.Runtime.InteropServices;
using CoreAudioApi.Interfaces;

namespace CoreAudioApi;

public class SimpleAudioVolume
{
	private ISimpleAudioVolume _SimpleAudioVolume;

	public float MasterVolume
	{
		get
		{
			Marshal.ThrowExceptionForHR(_SimpleAudioVolume.GetMasterVolume(out var pfLevel));
			return pfLevel;
		}
		set
		{
			Guid EventContext = Guid.Empty;
			Marshal.ThrowExceptionForHR(_SimpleAudioVolume.SetMasterVolume(value, ref EventContext));
		}
	}

	public bool Mute
	{
		get
		{
			Marshal.ThrowExceptionForHR(_SimpleAudioVolume.GetMute(out var bMute));
			return bMute;
		}
		set
		{
			Guid EventContext = Guid.Empty;
			Marshal.ThrowExceptionForHR(_SimpleAudioVolume.SetMute(value, ref EventContext));
		}
	}

	internal SimpleAudioVolume(ISimpleAudioVolume realSimpleVolume)
	{
		_SimpleAudioVolume = realSimpleVolume;
	}
}
