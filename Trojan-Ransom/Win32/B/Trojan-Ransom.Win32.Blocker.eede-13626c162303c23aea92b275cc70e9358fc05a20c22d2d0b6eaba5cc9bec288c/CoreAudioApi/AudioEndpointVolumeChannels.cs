using System.Runtime.InteropServices;
using CoreAudioApi.Interfaces;

namespace CoreAudioApi;

public class AudioEndpointVolumeChannels
{
	private IAudioEndpointVolume _AudioEndPointVolume;

	private AudioEndpointVolumeChannel[] _Channels;

	public int Count
	{
		get
		{
			Marshal.ThrowExceptionForHR(_AudioEndPointVolume.GetChannelCount(out var pnChannelCount));
			return pnChannelCount;
		}
	}

	public AudioEndpointVolumeChannel this[int index] => _Channels[index];

	internal AudioEndpointVolumeChannels(IAudioEndpointVolume parent)
	{
		_AudioEndPointVolume = parent;
		int count = Count;
		_Channels = new AudioEndpointVolumeChannel[count];
		for (int i = 0; i < count; i++)
		{
			_Channels[i] = new AudioEndpointVolumeChannel(_AudioEndPointVolume, i);
		}
	}
}
