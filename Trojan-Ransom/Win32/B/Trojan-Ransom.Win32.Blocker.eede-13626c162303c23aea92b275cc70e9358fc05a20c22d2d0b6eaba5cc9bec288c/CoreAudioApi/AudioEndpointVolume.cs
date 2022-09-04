using System;
using System.Runtime.InteropServices;
using CoreAudioApi.Interfaces;

namespace CoreAudioApi;

public class AudioEndpointVolume : IDisposable
{
	private IAudioEndpointVolume _AudioEndPointVolume;

	private AudioEndpointVolumeChannels _Channels;

	private AudioEndpointVolumeStepInformation _StepInformation;

	private AudioEndPointVolumeVolumeRange _VolumeRange;

	private EEndpointHardwareSupport _HardwareSupport;

	private AudioEndpointVolumeCallback _CallBack;

	public AudioEndPointVolumeVolumeRange VolumeRange => _VolumeRange;

	public EEndpointHardwareSupport HardwareSupport => _HardwareSupport;

	public AudioEndpointVolumeStepInformation StepInformation => _StepInformation;

	public AudioEndpointVolumeChannels Channels => _Channels;

	public float MasterVolumeLevel
	{
		get
		{
			Marshal.ThrowExceptionForHR(_AudioEndPointVolume.GetMasterVolumeLevel(out var pfLevelDB));
			return pfLevelDB;
		}
		set
		{
			Marshal.ThrowExceptionForHR(_AudioEndPointVolume.SetMasterVolumeLevel(value, Guid.Empty));
		}
	}

	public float MasterVolumeLevelScalar
	{
		get
		{
			Marshal.ThrowExceptionForHR(_AudioEndPointVolume.GetMasterVolumeLevelScalar(out var pfLevel));
			return pfLevel;
		}
		set
		{
			Marshal.ThrowExceptionForHR(_AudioEndPointVolume.SetMasterVolumeLevelScalar(value, Guid.Empty));
		}
	}

	public bool Mute
	{
		get
		{
			Marshal.ThrowExceptionForHR(_AudioEndPointVolume.GetMute(out var pbMute));
			return pbMute;
		}
		set
		{
			Marshal.ThrowExceptionForHR(_AudioEndPointVolume.SetMute(value, Guid.Empty));
		}
	}

	public event AudioEndpointVolumeNotificationDelegate OnVolumeNotification;

	public void VolumeStepUp()
	{
		Marshal.ThrowExceptionForHR(_AudioEndPointVolume.VolumeStepUp(Guid.Empty));
	}

	public void VolumeStepDown()
	{
		Marshal.ThrowExceptionForHR(_AudioEndPointVolume.VolumeStepDown(Guid.Empty));
	}

	internal AudioEndpointVolume(IAudioEndpointVolume realEndpointVolume)
	{
		_AudioEndPointVolume = realEndpointVolume;
		_Channels = new AudioEndpointVolumeChannels(_AudioEndPointVolume);
		_StepInformation = new AudioEndpointVolumeStepInformation(_AudioEndPointVolume);
		Marshal.ThrowExceptionForHR(_AudioEndPointVolume.QueryHardwareSupport(out var pdwHardwareSupportMask));
		_HardwareSupport = (EEndpointHardwareSupport)pdwHardwareSupportMask;
		_VolumeRange = new AudioEndPointVolumeVolumeRange(_AudioEndPointVolume);
		_CallBack = new AudioEndpointVolumeCallback(this);
		Marshal.ThrowExceptionForHR(_AudioEndPointVolume.RegisterControlChangeNotify(_CallBack));
	}

	internal void FireNotification(AudioVolumeNotificationData NotificationData)
	{
		this.OnVolumeNotification?.Invoke(NotificationData);
	}

	public void Dispose()
	{
		if (_CallBack != null)
		{
			Marshal.ThrowExceptionForHR(_AudioEndPointVolume.UnregisterControlChangeNotify(_CallBack));
			_CallBack = null;
		}
	}

	~AudioEndpointVolume()
	{
		Dispose();
	}
}
