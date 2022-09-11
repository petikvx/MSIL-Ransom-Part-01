using System;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi.Interfaces;

namespace NAudio.CoreAudioApi;

public sealed class AudioSessionManager
{
	public delegate void SessionCreatedDelegate(object sender, IAudioSessionControl newSession);

	private readonly IAudioSessionManager audioSessionInterface;

	private readonly IAudioSessionManager2 audioSessionInterface2;

	private AudioSessionNotification audioSessionNotification;

	private SessionCollection sessions;

	private SimpleAudioVolume simpleAudioVolume;

	private AudioSessionControl audioSessionControl;

	public SimpleAudioVolume SimpleAudioVolume
	{
		get
		{
			if (simpleAudioVolume == null)
			{
				audioSessionInterface.GetSimpleAudioVolume(Guid.Empty, 0u, out var audioVolume);
				simpleAudioVolume = new SimpleAudioVolume(audioVolume);
			}
			return simpleAudioVolume;
		}
	}

	public AudioSessionControl AudioSessionControl
	{
		get
		{
			if (audioSessionControl == null)
			{
				audioSessionInterface.GetAudioSessionControl(Guid.Empty, 0u, out var sessionControl);
				audioSessionControl = new AudioSessionControl(sessionControl);
			}
			return audioSessionControl;
		}
	}

	public SessionCollection Sessions => sessions;

	public event SessionCreatedDelegate OnSessionCreated;

	internal AudioSessionManager(IAudioSessionManager audioSessionManager)
	{
		audioSessionInterface = audioSessionManager;
		audioSessionInterface2 = audioSessionManager as IAudioSessionManager2;
		RefreshSessions();
	}

	internal void FireSessionCreated(IAudioSessionControl newSession)
	{
		if (this.OnSessionCreated != null)
		{
			this.OnSessionCreated(this, newSession);
		}
	}

	public void RefreshSessions()
	{
		UnregisterNotifications();
		if (audioSessionInterface2 != null)
		{
			Marshal.ThrowExceptionForHR(audioSessionInterface2.GetSessionEnumerator(out var sessionEnum));
			sessions = new SessionCollection(sessionEnum);
			audioSessionNotification = new AudioSessionNotification(this);
			Marshal.ThrowExceptionForHR(audioSessionInterface2.RegisterSessionNotification(audioSessionNotification));
		}
	}

	public void Dispose()
	{
		UnregisterNotifications();
		GC.SuppressFinalize(this);
	}

	private void UnregisterNotifications()
	{
		if (sessions != null)
		{
			sessions = null;
		}
		if (audioSessionNotification != null)
		{
			Marshal.ThrowExceptionForHR(audioSessionInterface2.UnregisterSessionNotification(audioSessionNotification));
		}
	}

	~AudioSessionManager()
	{
		Dispose();
	}
}
