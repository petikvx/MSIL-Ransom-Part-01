using System;

namespace CoreAudioApi;

public class AudioVolumeNotificationData
{
	private Guid _EventContext;

	private bool _Muted;

	private float _MasterVolume;

	private int _Channels;

	private float[] _ChannelVolume;

	public Guid EventContext => _EventContext;

	public bool Muted => _Muted;

	public float MasterVolume => _MasterVolume;

	public int Channels => _Channels;

	public float[] ChannelVolume => _ChannelVolume;

	public AudioVolumeNotificationData(Guid eventContext, bool muted, float masterVolume, float[] channelVolume)
	{
		_EventContext = eventContext;
		_Muted = muted;
		_MasterVolume = masterVolume;
		_Channels = channelVolume.Length;
		_ChannelVolume = channelVolume;
	}
}
