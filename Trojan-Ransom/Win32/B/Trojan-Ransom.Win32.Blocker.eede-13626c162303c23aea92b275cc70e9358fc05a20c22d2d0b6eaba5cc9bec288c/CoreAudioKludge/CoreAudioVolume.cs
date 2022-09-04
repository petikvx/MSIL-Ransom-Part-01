using System;
using CoreAudioApi;

namespace CoreAudioKludge;

internal class CoreAudioVolume
{
	private MMDevice device;

	private int _volume;

	public int Volume
	{
		get
		{
			return _volume;
		}
		set
		{
			if (value < 0 || value > 100)
			{
				throw new ArgumentException("The value should be in range 0-100");
			}
			_volume = value;
			device.AudioEndpointVolume.MasterVolumeLevelScalar = (float)_volume / 100f;
		}
	}

	public bool Mute
	{
		get
		{
			return device.AudioEndpointVolume.Mute;
		}
		set
		{
			device.AudioEndpointVolume.Mute = value;
		}
	}

	public CoreAudioVolume()
	{
		MMDeviceEnumerator mMDeviceEnumerator = new MMDeviceEnumerator();
		device = mMDeviceEnumerator.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);
		_volume = (int)(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100f);
	}
}
