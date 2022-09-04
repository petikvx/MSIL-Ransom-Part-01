using System;
using System.Runtime.InteropServices;
using CoreAudioApi.Interfaces;

namespace CoreAudioApi;

public class MMDevice
{
	private IMMDevice _RealDevice;

	private PropertyStore _PropertyStore;

	private AudioMeterInformation _AudioMeterInformation;

	private AudioEndpointVolume _AudioEndpointVolume;

	private AudioSessionManager _AudioSessionManager;

	private static Guid IID_IAudioMeterInformation = typeof(IAudioMeterInformation).GUID;

	private static Guid IID_IAudioEndpointVolume = typeof(IAudioEndpointVolume).GUID;

	private static Guid IID_IAudioSessionManager = typeof(IAudioSessionManager2).GUID;

	public AudioSessionManager AudioSessionManager
	{
		get
		{
			if (_AudioSessionManager == null)
			{
				GetAudioSessionManager();
			}
			return _AudioSessionManager;
		}
	}

	public AudioMeterInformation AudioMeterInformation
	{
		get
		{
			if (_AudioMeterInformation == null)
			{
				GetAudioMeterInformation();
			}
			return _AudioMeterInformation;
		}
	}

	public AudioEndpointVolume AudioEndpointVolume
	{
		get
		{
			if (_AudioEndpointVolume == null)
			{
				GetAudioEndpointVolume();
			}
			return _AudioEndpointVolume;
		}
	}

	public PropertyStore Properties
	{
		get
		{
			if (_PropertyStore == null)
			{
				GetPropertyInformation();
			}
			return _PropertyStore;
		}
	}

	public string FriendlyName
	{
		get
		{
			if (_PropertyStore == null)
			{
				GetPropertyInformation();
			}
			if (_PropertyStore.Contains(PKEY.PKEY_DeviceInterface_FriendlyName))
			{
				return (string)_PropertyStore[PKEY.PKEY_DeviceInterface_FriendlyName].Value;
			}
			return "Unknown";
		}
	}

	public string ID
	{
		get
		{
			Marshal.ThrowExceptionForHR(_RealDevice.GetId(out var ppstrId));
			return ppstrId;
		}
	}

	public EDataFlow DataFlow
	{
		get
		{
			IMMEndpoint iMMEndpoint = _RealDevice as IMMEndpoint;
			iMMEndpoint.GetDataFlow(out var pDataFlow);
			return pDataFlow;
		}
	}

	public EDeviceState State
	{
		get
		{
			Marshal.ThrowExceptionForHR(_RealDevice.GetState(out var pdwState));
			return pdwState;
		}
	}

	private void GetPropertyInformation()
	{
		Marshal.ThrowExceptionForHR(_RealDevice.OpenPropertyStore(EStgmAccess.STGM_READ, out var propertyStore));
		_PropertyStore = new PropertyStore(propertyStore);
	}

	private void GetAudioSessionManager()
	{
		Marshal.ThrowExceptionForHR(_RealDevice.Activate(ref IID_IAudioSessionManager, CLSCTX.ALL, IntPtr.Zero, out var ppInterface));
		_AudioSessionManager = new AudioSessionManager(ppInterface as IAudioSessionManager2);
	}

	private void GetAudioMeterInformation()
	{
		Marshal.ThrowExceptionForHR(_RealDevice.Activate(ref IID_IAudioMeterInformation, CLSCTX.ALL, IntPtr.Zero, out var ppInterface));
		_AudioMeterInformation = new AudioMeterInformation(ppInterface as IAudioMeterInformation);
	}

	private void GetAudioEndpointVolume()
	{
		Marshal.ThrowExceptionForHR(_RealDevice.Activate(ref IID_IAudioEndpointVolume, CLSCTX.ALL, IntPtr.Zero, out var ppInterface));
		_AudioEndpointVolume = new AudioEndpointVolume(ppInterface as IAudioEndpointVolume);
	}

	internal MMDevice(IMMDevice realDevice)
	{
		_RealDevice = realDevice;
	}
}
