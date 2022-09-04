using System;
using System.Runtime.InteropServices;

namespace CoreAudioApi.Interfaces;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("A95664D2-9614-4F35-A746-DE8DB63617E6")]
internal interface IMMDeviceEnumerator
{
	[PreserveSig]
	int EnumAudioEndpoints(EDataFlow dataFlow, EDeviceState StateMask, out IMMDeviceCollection device);

	[PreserveSig]
	int GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role, out IMMDevice ppEndpoint);

	[PreserveSig]
	int GetDevice(string pwstrId, out IMMDevice ppDevice);

	[PreserveSig]
	int RegisterEndpointNotificationCallback(IntPtr pClient);

	[PreserveSig]
	int UnregisterEndpointNotificationCallback(IntPtr pClient);
}
