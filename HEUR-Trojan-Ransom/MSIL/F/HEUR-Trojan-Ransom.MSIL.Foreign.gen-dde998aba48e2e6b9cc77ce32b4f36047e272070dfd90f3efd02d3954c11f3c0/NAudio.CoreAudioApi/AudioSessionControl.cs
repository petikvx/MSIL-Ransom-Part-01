using System;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi.Interfaces;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.CoreAudioApi;

public sealed class AudioSessionControl : IDisposable
{
	private readonly IAudioSessionControl audioSessionControlInterface;

	private readonly IAudioSessionControl2 audioSessionControlInterface2;

	private AudioSessionEventsCallback audioSessionEventCallback;

	internal AudioMeterInformation audioMeterInformation;

	internal SimpleAudioVolume simpleAudioVolume;

	[NonSerialized]
	internal static GetString _0010;

	public AudioMeterInformation AudioMeterInformation => audioMeterInformation;

	public SimpleAudioVolume SimpleAudioVolume => simpleAudioVolume;

	public AudioSessionState State
	{
		get
		{
			Marshal.ThrowExceptionForHR(audioSessionControlInterface.GetState(out var state));
			return state;
		}
	}

	public string DisplayName
	{
		get
		{
			string displayName = string.Empty;
			Marshal.ThrowExceptionForHR(audioSessionControlInterface.GetDisplayName(out displayName));
			return displayName;
		}
		set
		{
			if (value != string.Empty)
			{
				Marshal.ThrowExceptionForHR(audioSessionControlInterface.SetDisplayName(value, Guid.Empty));
			}
		}
	}

	public string IconPath
	{
		get
		{
			string iconPath = string.Empty;
			Marshal.ThrowExceptionForHR(audioSessionControlInterface.GetIconPath(out iconPath));
			return iconPath;
		}
		set
		{
			if (value != string.Empty)
			{
				Marshal.ThrowExceptionForHR(audioSessionControlInterface.SetIconPath(value, Guid.Empty));
			}
		}
	}

	public string GetSessionIdentifier
	{
		get
		{
			if (audioSessionControlInterface2 == null)
			{
				throw new InvalidOperationException(_0010(107404480));
			}
			Marshal.ThrowExceptionForHR(audioSessionControlInterface2.GetSessionIdentifier(out var retVal));
			return retVal;
		}
	}

	public string GetSessionInstanceIdentifier
	{
		get
		{
			if (audioSessionControlInterface2 == null)
			{
				throw new InvalidOperationException(_0010(107404480));
			}
			Marshal.ThrowExceptionForHR(audioSessionControlInterface2.GetSessionInstanceIdentifier(out var retVal));
			return retVal;
		}
	}

	public uint GetProcessID
	{
		get
		{
			if (audioSessionControlInterface2 == null)
			{
				throw new InvalidOperationException(_0010(107404480));
			}
			Marshal.ThrowExceptionForHR(audioSessionControlInterface2.GetProcessId(out var retVal));
			return retVal;
		}
	}

	public bool IsSystemSoundsSession
	{
		get
		{
			if (audioSessionControlInterface2 == null)
			{
				throw new InvalidOperationException(_0010(107404480));
			}
			return audioSessionControlInterface2.IsSystemSoundsSession() == 0;
		}
	}

	public AudioSessionControl(IAudioSessionControl audioSessionControl)
	{
		audioSessionControlInterface = audioSessionControl;
		audioSessionControlInterface2 = audioSessionControl as IAudioSessionControl2;
		IAudioMeterInformation audioMeterInformation = audioSessionControlInterface as IAudioMeterInformation;
		ISimpleAudioVolume simpleAudioVolume = audioSessionControlInterface as ISimpleAudioVolume;
		if (audioMeterInformation != null)
		{
			this.audioMeterInformation = new AudioMeterInformation(audioMeterInformation);
		}
		if (simpleAudioVolume != null)
		{
			this.simpleAudioVolume = new SimpleAudioVolume(simpleAudioVolume);
		}
	}

	public void Dispose()
	{
		if (audioSessionEventCallback != null)
		{
			Marshal.ThrowExceptionForHR(audioSessionControlInterface.UnregisterAudioSessionNotification(audioSessionEventCallback));
			audioSessionEventCallback = null;
		}
		GC.SuppressFinalize(this);
	}

	~AudioSessionControl()
	{
		Dispose();
	}

	public Guid GetGroupingParam()
	{
		Guid groupingId = Guid.Empty;
		Marshal.ThrowExceptionForHR(audioSessionControlInterface.GetGroupingParam(out groupingId));
		return groupingId;
	}

	public void SetGroupingParam(Guid groupingId, Guid context)
	{
		Marshal.ThrowExceptionForHR(audioSessionControlInterface.SetGroupingParam(groupingId, context));
	}

	public void RegisterEventClient(IAudioSessionEventsHandler eventClient)
	{
		audioSessionEventCallback = new AudioSessionEventsCallback(eventClient);
		Marshal.ThrowExceptionForHR(audioSessionControlInterface.RegisterAudioSessionNotification(audioSessionEventCallback));
	}

	public void UnRegisterEventClient(IAudioSessionEventsHandler eventClient)
	{
		if (audioSessionEventCallback != null)
		{
			Marshal.ThrowExceptionForHR(audioSessionControlInterface.UnregisterAudioSessionNotification(audioSessionEventCallback));
			audioSessionEventCallback = null;
		}
	}

	static AudioSessionControl()
	{
		Strings.CreateGetStringDelegate(typeof(AudioSessionControl));
	}
}
