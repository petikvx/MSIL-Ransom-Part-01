using System;
using System.Runtime.InteropServices;
using CoreAudioApi.Interfaces;

namespace CoreAudioApi;

internal class AudioEndpointVolumeCallback : IAudioEndpointVolumeCallback
{
	private AudioEndpointVolume _Parent;

	internal AudioEndpointVolumeCallback(AudioEndpointVolume parent)
	{
		_Parent = parent;
	}

	[PreserveSig]
	public int OnNotify(IntPtr NotifyData)
	{
		AUDIO_VOLUME_NOTIFICATION_DATA aUDIO_VOLUME_NOTIFICATION_DATA = (AUDIO_VOLUME_NOTIFICATION_DATA)Marshal.PtrToStructure(NotifyData, typeof(AUDIO_VOLUME_NOTIFICATION_DATA));
		IntPtr intPtr = Marshal.OffsetOf(typeof(AUDIO_VOLUME_NOTIFICATION_DATA), "ChannelVolume");
		IntPtr ptr = (IntPtr)((long)NotifyData + (long)intPtr);
		float[] array = new float[aUDIO_VOLUME_NOTIFICATION_DATA.nChannels];
		for (int i = 0; i < aUDIO_VOLUME_NOTIFICATION_DATA.nChannels; i++)
		{
			array[i] = (float)Marshal.PtrToStructure(ptr, typeof(float));
		}
		AudioVolumeNotificationData notificationData = new AudioVolumeNotificationData(aUDIO_VOLUME_NOTIFICATION_DATA.guidEventContext, aUDIO_VOLUME_NOTIFICATION_DATA.bMuted, aUDIO_VOLUME_NOTIFICATION_DATA.fMasterVolume, array);
		_Parent.FireNotification(notificationData);
		return 0;
	}
}
