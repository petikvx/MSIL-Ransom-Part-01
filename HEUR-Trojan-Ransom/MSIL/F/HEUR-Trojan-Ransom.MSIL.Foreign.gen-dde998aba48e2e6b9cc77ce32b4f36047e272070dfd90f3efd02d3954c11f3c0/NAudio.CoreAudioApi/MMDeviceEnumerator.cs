using System;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi.Interfaces;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.CoreAudioApi;

public sealed class MMDeviceEnumerator : IDisposable
{
	private IMMDeviceEnumerator realEnumerator;

	[NonSerialized]
	internal static GetString _0019;

	public MMDeviceEnumerator()
	{
		if (Environment.OSVersion.Version.Major < 6)
		{
			throw new NotSupportedException(_0019(107403285));
		}
		realEnumerator = new MMDeviceEnumeratorComObject() as IMMDeviceEnumerator;
	}

	public MMDeviceCollection EnumerateAudioEndPoints(DataFlow dataFlow, DeviceState dwStateMask)
	{
		Marshal.ThrowExceptionForHR(realEnumerator.EnumAudioEndpoints(dataFlow, dwStateMask, out var devices));
		return new MMDeviceCollection(devices);
	}

	public MMDevice GetDefaultAudioEndpoint(DataFlow dataFlow, Role role)
	{
		IMMDevice endpoint = null;
		Marshal.ThrowExceptionForHR(realEnumerator.GetDefaultAudioEndpoint(dataFlow, role, out endpoint));
		return new MMDevice(endpoint);
	}

	public bool HasDefaultAudioEndpoint(DataFlow dataFlow, Role role)
	{
		IMMDevice endpoint = null;
		int defaultAudioEndpoint = realEnumerator.GetDefaultAudioEndpoint(dataFlow, role, out endpoint);
		switch (defaultAudioEndpoint)
		{
		case 0:
			Marshal.ReleaseComObject(endpoint);
			return true;
		case -2147023728:
			return false;
		default:
			Marshal.ThrowExceptionForHR(defaultAudioEndpoint);
			return false;
		}
	}

	public MMDevice GetDevice(string id)
	{
		IMMDevice deviceName = null;
		Marshal.ThrowExceptionForHR(realEnumerator.GetDevice(id, out deviceName));
		return new MMDevice(deviceName);
	}

	public int RegisterEndpointNotificationCallback([In][MarshalAs(UnmanagedType.Interface)] IMMNotificationClient client)
	{
		return realEnumerator.RegisterEndpointNotificationCallback(client);
	}

	public int UnregisterEndpointNotificationCallback([In][MarshalAs(UnmanagedType.Interface)] IMMNotificationClient client)
	{
		return realEnumerator.UnregisterEndpointNotificationCallback(client);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && realEnumerator != null)
		{
			Marshal.ReleaseComObject(realEnumerator);
			realEnumerator = null;
		}
	}

	static MMDeviceEnumerator()
	{
		Strings.CreateGetStringDelegate(typeof(MMDeviceEnumerator));
	}
}
