using System;
using System.Runtime.InteropServices;
using CoreAudioApi.Interfaces;

namespace CoreAudioApi;

public class MMDeviceEnumerator
{
	private IMMDeviceEnumerator _realEnumerator = new _MMDeviceEnumerator() as IMMDeviceEnumerator;

	public MMDeviceCollection EnumerateAudioEndPoints(EDataFlow dataFlow, EDeviceState dwStateMask)
	{
		Marshal.ThrowExceptionForHR(_realEnumerator.EnumAudioEndpoints(dataFlow, dwStateMask, out var device));
		return new MMDeviceCollection(device);
	}

	public MMDevice GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role)
	{
		IMMDevice ppEndpoint = null;
		Marshal.ThrowExceptionForHR(_realEnumerator.GetDefaultAudioEndpoint(dataFlow, role, out ppEndpoint));
		return new MMDevice(ppEndpoint);
	}

	public MMDevice GetDevice(string ID)
	{
		IMMDevice ppDevice = null;
		Marshal.ThrowExceptionForHR(_realEnumerator.GetDevice(ID, out ppDevice));
		return new MMDevice(ppDevice);
	}

	public MMDeviceEnumerator()
	{
		if (Environment.OSVersion.Version.Major < 6)
		{
			throw new NotSupportedException("This functionality is only supported on Windows Vista or newer.");
		}
	}
}
