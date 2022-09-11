using System;

namespace NAudio.CoreAudioApi.Interfaces;

internal struct AudioVolumeNotificationDataStruct
{
	public Guid guidEventContext;

	public bool bMuted;

	public float fMasterVolume;

	public uint nChannels;

	public float ChannelVolume;

	private void FixCS0649()
	{
		guidEventContext = Guid.Empty;
		bMuted = false;
		fMasterVolume = 0f;
		nChannels = 0u;
		ChannelVolume = 0f;
	}
}
