using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.CoreAudioApi.Interfaces;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.CoreAudioApi;

public sealed class MMDevice
{
	private readonly IMMDevice deviceInterface;

	private PropertyStore propertyStore;

	private AudioMeterInformation audioMeterInformation;

	private AudioEndpointVolume audioEndpointVolume;

	private AudioSessionManager audioSessionManager;

	private static Guid IID_IAudioMeterInformation;

	private static Guid IID_IAudioEndpointVolume;

	private static Guid IID_IAudioClient;

	private static Guid IDD_IAudioSessionManager;

	[NonSerialized]
	internal static GetString _0082;

	public AudioClient AudioClient => GetAudioClient();

	public AudioMeterInformation AudioMeterInformation
	{
		get
		{
			if (audioMeterInformation == null)
			{
				GetAudioMeterInformation();
			}
			return audioMeterInformation;
		}
	}

	public AudioEndpointVolume AudioEndpointVolume
	{
		get
		{
			if (audioEndpointVolume == null)
			{
				GetAudioEndpointVolume();
			}
			return audioEndpointVolume;
		}
	}

	public AudioSessionManager AudioSessionManager
	{
		get
		{
			if (audioSessionManager == null)
			{
				GetAudioSessionManager();
			}
			return audioSessionManager;
		}
	}

	public PropertyStore Properties
	{
		get
		{
			if (propertyStore == null)
			{
				GetPropertyInformation();
			}
			return propertyStore;
		}
	}

	public string FriendlyName
	{
		get
		{
			if (propertyStore == null)
			{
				GetPropertyInformation();
			}
			if (propertyStore.Contains(PropertyKeys.PKEY_Device_FriendlyName))
			{
				return (string)propertyStore[PropertyKeys.PKEY_Device_FriendlyName].Value;
			}
			return _0082(107403981);
		}
	}

	public string DeviceFriendlyName
	{
		get
		{
			if (propertyStore == null)
			{
				GetPropertyInformation();
			}
			if (propertyStore.Contains(PropertyKeys.PKEY_DeviceInterface_FriendlyName))
			{
				return (string)propertyStore[PropertyKeys.PKEY_DeviceInterface_FriendlyName].Value;
			}
			return _0082(107403981);
		}
	}

	public string IconPath
	{
		get
		{
			if (propertyStore == null)
			{
				GetPropertyInformation();
			}
			if (propertyStore.Contains(PropertyKeys.PKEY_Device_IconPath))
			{
				return (string)propertyStore[PropertyKeys.PKEY_Device_IconPath].Value;
			}
			return _0082(107403981);
		}
	}

	public string ID
	{
		get
		{
			Marshal.ThrowExceptionForHR(deviceInterface.GetId(out var id));
			return id;
		}
	}

	public DataFlow DataFlow
	{
		get
		{
			(deviceInterface as IMMEndpoint).GetDataFlow(out var dataFlow);
			return dataFlow;
		}
	}

	public DeviceState State
	{
		get
		{
			Marshal.ThrowExceptionForHR(deviceInterface.GetState(out var state));
			return state;
		}
	}

	private void GetPropertyInformation()
	{
		Marshal.ThrowExceptionForHR(deviceInterface.OpenPropertyStore(StorageAccessMode.Read, out var properties));
		propertyStore = new PropertyStore(properties);
	}

	private AudioClient GetAudioClient()
	{
		Marshal.ThrowExceptionForHR(deviceInterface.Activate(ref IID_IAudioClient, ClsCtx.ALL, IntPtr.Zero, out var interfacePointer));
		return new AudioClient(interfacePointer as IAudioClient);
	}

	private void GetAudioMeterInformation()
	{
		Marshal.ThrowExceptionForHR(deviceInterface.Activate(ref IID_IAudioMeterInformation, ClsCtx.ALL, IntPtr.Zero, out var interfacePointer));
		audioMeterInformation = new AudioMeterInformation(interfacePointer as IAudioMeterInformation);
	}

	private void GetAudioEndpointVolume()
	{
		Marshal.ThrowExceptionForHR(deviceInterface.Activate(ref IID_IAudioEndpointVolume, ClsCtx.ALL, IntPtr.Zero, out var interfacePointer));
		audioEndpointVolume = new AudioEndpointVolume(interfacePointer as IAudioEndpointVolume);
	}

	private void GetAudioSessionManager()
	{
		Marshal.ThrowExceptionForHR(deviceInterface.Activate(ref IDD_IAudioSessionManager, ClsCtx.ALL, IntPtr.Zero, out var interfacePointer));
		audioSessionManager = new AudioSessionManager(interfacePointer as IAudioSessionManager);
	}

	internal MMDevice(IMMDevice realDevice)
	{
		deviceInterface = realDevice;
	}

	public override string ToString()
	{
		return FriendlyName;
	}

	static MMDevice()
	{
		Strings.CreateGetStringDelegate(typeof(MMDevice));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0082(107400137), _0082(107400100)).Replace(_0082(107400095), _0082(107400090)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_0082(107400117)))
		{
			throw new SecurityException(_0082(107400060));
		}
		IID_IAudioMeterInformation = new Guid(_0082(107403936));
		IID_IAudioEndpointVolume = new Guid(_0082(107403919));
		IID_IAudioClient = new Guid(_0082(107403326));
		IDD_IAudioSessionManager = new Guid(_0082(107403309));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
