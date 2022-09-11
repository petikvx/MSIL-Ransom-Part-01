using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.CoreAudioApi.Interfaces;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.CoreAudioApi;

public sealed class AudioEndpointVolume : IDisposable
{
	private readonly IAudioEndpointVolume audioEndPointVolume;

	private readonly AudioEndpointVolumeChannels channels;

	private readonly AudioEndpointVolumeStepInformation stepInformation;

	private readonly AudioEndpointVolumeVolumeRange volumeRange;

	private readonly EEndpointHardwareSupport hardwareSupport;

	private AudioEndpointVolumeCallback callBack;

	private Guid notificationGuid = Guid.Empty;

	[NonSerialized]
	internal static GetString _0011;

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

	public AudioEndpointVolumeVolumeRange VolumeRange => volumeRange;

	public EEndpointHardwareSupport HardwareSupport => hardwareSupport;

	public AudioEndpointVolumeStepInformation StepInformation => stepInformation;

	public AudioEndpointVolumeChannels Channels => channels;

	public float MasterVolumeLevel
	{
		get
		{
			Marshal.ThrowExceptionForHR(audioEndPointVolume.GetMasterVolumeLevel(out var pfLevelDB));
			return pfLevelDB;
		}
		set
		{
			Marshal.ThrowExceptionForHR(audioEndPointVolume.SetMasterVolumeLevel(value, ref notificationGuid));
		}
	}

	public float MasterVolumeLevelScalar
	{
		get
		{
			Marshal.ThrowExceptionForHR(audioEndPointVolume.GetMasterVolumeLevelScalar(out var pfLevel));
			return pfLevel;
		}
		set
		{
			Marshal.ThrowExceptionForHR(audioEndPointVolume.SetMasterVolumeLevelScalar(value, ref notificationGuid));
		}
	}

	public bool Mute
	{
		get
		{
			Marshal.ThrowExceptionForHR(audioEndPointVolume.GetMute(out var pbMute));
			return pbMute;
		}
		set
		{
			Marshal.ThrowExceptionForHR(audioEndPointVolume.SetMute(value, ref notificationGuid));
		}
	}

	public event AudioEndpointVolumeNotificationDelegate OnVolumeNotification;

	public void VolumeStepUp()
	{
		Marshal.ThrowExceptionForHR(audioEndPointVolume.VolumeStepUp(ref notificationGuid));
	}

	public void VolumeStepDown()
	{
		Marshal.ThrowExceptionForHR(audioEndPointVolume.VolumeStepDown(ref notificationGuid));
	}

	internal AudioEndpointVolume(IAudioEndpointVolume realEndpointVolume)
	{
		audioEndPointVolume = realEndpointVolume;
		channels = new AudioEndpointVolumeChannels(audioEndPointVolume);
		stepInformation = new AudioEndpointVolumeStepInformation(audioEndPointVolume);
		Marshal.ThrowExceptionForHR(audioEndPointVolume.QueryHardwareSupport(out var pdwHardwareSupportMask));
		hardwareSupport = (EEndpointHardwareSupport)pdwHardwareSupportMask;
		volumeRange = new AudioEndpointVolumeVolumeRange(audioEndPointVolume);
		callBack = new AudioEndpointVolumeCallback(this);
		Marshal.ThrowExceptionForHR(audioEndPointVolume.RegisterControlChangeNotify(callBack));
	}

	internal void FireNotification(AudioVolumeNotificationData notificationData)
	{
		this.OnVolumeNotification?.Invoke(notificationData);
	}

	public void Dispose()
	{
		if (callBack != null)
		{
			Marshal.ThrowExceptionForHR(audioEndPointVolume.UnregisterControlChangeNotify(callBack));
			callBack = null;
		}
		GC.SuppressFinalize(this);
	}

	~AudioEndpointVolume()
	{
		Dispose();
	}

	static AudioEndpointVolume()
	{
		Strings.CreateGetStringDelegate(typeof(AudioEndpointVolume));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0011(107400169), _0011(107400132)), _0011(107400127), _0011(107400122)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0011(107400149)))
		{
			return;
		}
		throw new SecurityException(_0011(107400092));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
