using System;
using System.Runtime.InteropServices;
using CoreAudioApi.Interfaces;

namespace CoreAudioApi;

public class AudioEndpointVolumeChannel
{
	private uint _Channel;

	private IAudioEndpointVolume _AudioEndpointVolume;

	public float VolumeLevel
	{
		get
		{
			Marshal.ThrowExceptionForHR(_AudioEndpointVolume.GetChannelVolumeLevel(_Channel, out var pfLevelDB));
			return pfLevelDB;
		}
		set
		{
			Marshal.ThrowExceptionForHR(_AudioEndpointVolume.SetChannelVolumeLevel(_Channel, value, Guid.Empty));
		}
	}

	public float VolumeLevelScalar
	{
		get
		{
			Marshal.ThrowExceptionForHR(_AudioEndpointVolume.GetChannelVolumeLevelScalar(_Channel, out var pfLevel));
			return pfLevel;
		}
		set
		{
			Marshal.ThrowExceptionForHR(_AudioEndpointVolume.SetChannelVolumeLevelScalar(_Channel, value, Guid.Empty));
		}
	}

	internal AudioEndpointVolumeChannel(IAudioEndpointVolume parent, int channel)
	{
		_Channel = (uint)channel;
		_AudioEndpointVolume = parent;
	}
}
