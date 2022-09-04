using System.Runtime.InteropServices;
using CoreAudioApi.Interfaces;

namespace CoreAudioApi;

public class AudioSessionControl
{
	internal IAudioSessionControl2 _AudioSessionControl;

	internal AudioMeterInformation _AudioMeterInformation;

	internal SimpleAudioVolume _SimpleAudioVolume;

	public AudioMeterInformation AudioMeterInformation => _AudioMeterInformation;

	public SimpleAudioVolume SimpleAudioVolume => _SimpleAudioVolume;

	public AudioSessionState State
	{
		get
		{
			Marshal.ThrowExceptionForHR(_AudioSessionControl.GetState(out var state));
			return state;
		}
	}

	public string DisplayName
	{
		get
		{
			Marshal.ThrowExceptionForHR(_AudioSessionControl.GetDisplayName(out var name));
			string result = Marshal.PtrToStringAuto(name);
			Marshal.FreeCoTaskMem(name);
			return result;
		}
	}

	public string IconPath
	{
		get
		{
			Marshal.ThrowExceptionForHR(_AudioSessionControl.GetIconPath(out var Path));
			string result = Marshal.PtrToStringAuto(Path);
			Marshal.FreeCoTaskMem(Path);
			return result;
		}
	}

	public string SessionIdentifier
	{
		get
		{
			Marshal.ThrowExceptionForHR(_AudioSessionControl.GetSessionIdentifier(out var retVal));
			string result = Marshal.PtrToStringAuto(retVal);
			Marshal.FreeCoTaskMem(retVal);
			return result;
		}
	}

	public string SessionInstanceIdentifier
	{
		get
		{
			Marshal.ThrowExceptionForHR(_AudioSessionControl.GetSessionInstanceIdentifier(out var retVal));
			string result = Marshal.PtrToStringAuto(retVal);
			Marshal.FreeCoTaskMem(retVal);
			return result;
		}
	}

	public uint ProcessID
	{
		get
		{
			Marshal.ThrowExceptionForHR(_AudioSessionControl.GetProcessId(out var retvVal));
			return retvVal;
		}
	}

	public bool IsSystemIsSystemSoundsSession => _AudioSessionControl.IsSystemSoundsSession() == 0;

	internal AudioSessionControl(IAudioSessionControl2 realAudioSessionControl)
	{
		IAudioMeterInformation audioMeterInformation = realAudioSessionControl as IAudioMeterInformation;
		ISimpleAudioVolume simpleAudioVolume = realAudioSessionControl as ISimpleAudioVolume;
		if (audioMeterInformation != null)
		{
			_AudioMeterInformation = new AudioMeterInformation(audioMeterInformation);
		}
		if (simpleAudioVolume != null)
		{
			_SimpleAudioVolume = new SimpleAudioVolume(simpleAudioVolume);
		}
		_AudioSessionControl = realAudioSessionControl;
	}

	public void RegisterAudioSessionNotification(IAudioSessionEvents eventConsumer)
	{
		Marshal.ThrowExceptionForHR(_AudioSessionControl.RegisterAudioSessionNotification(eventConsumer));
	}

	public void UnregisterAudioSessionNotification(IAudioSessionEvents eventConsumer)
	{
		Marshal.ThrowExceptionForHR(_AudioSessionControl.UnregisterAudioSessionNotification(eventConsumer));
	}
}
