using System;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi.Interfaces;

namespace NAudio.CoreAudioApi;

public sealed class AudioEndpointVolumeChannel
{
	private readonly uint channel;

	private readonly IAudioEndpointVolume audioEndpointVolume;

	private Guid notificationGuid = Guid.Empty;

	public Guid NotificationGuid
	{
		get
		{
			return notificationGuid;
		}
		set
		{
			notificationGuid = value;
		}
	}

	public float VolumeLevel
	{
		get
		{
			Marshal.ThrowExceptionForHR(audioEndpointVolume.GetChannelVolumeLevel(channel, out var pfLevelDB));
			return pfLevelDB;
		}
		set
		{
			Marshal.ThrowExceptionForHR(audioEndpointVolume.SetChannelVolumeLevel(channel, value, ref notificationGuid));
		}
	}

	public float VolumeLevelScalar
	{
		get
		{
			Marshal.ThrowExceptionForHR(audioEndpointVolume.GetChannelVolumeLevelScalar(channel, out var pfLevel));
			return pfLevel;
		}
		set
		{
			Marshal.ThrowExceptionForHR(audioEndpointVolume.SetChannelVolumeLevelScalar(channel, value, ref notificationGuid));
		}
	}

	internal AudioEndpointVolumeChannel(IAudioEndpointVolume parent, int channel)
	{
		this.channel = (uint)channel;
		audioEndpointVolume = parent;
	}
}
