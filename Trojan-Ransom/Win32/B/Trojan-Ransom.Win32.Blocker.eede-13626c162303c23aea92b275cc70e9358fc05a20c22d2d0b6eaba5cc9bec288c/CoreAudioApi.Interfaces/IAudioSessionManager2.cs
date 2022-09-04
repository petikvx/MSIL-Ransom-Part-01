using System;
using System.Runtime.InteropServices;

namespace CoreAudioApi.Interfaces;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("77AA99A0-1BD6-484F-8BC7-2C654C9A9B6F")]
internal interface IAudioSessionManager2
{
	[PreserveSig]
	int GetAudioSessionControl(ref Guid AudioSessionGuid, uint StreamFlags, IntPtr ISessionControl);

	[PreserveSig]
	int GetSimpleAudioVolume(ref Guid AudioSessionGuid, uint StreamFlags, IntPtr SimpleAudioVolume);

	[PreserveSig]
	int GetSessionEnumerator(out IAudioSessionEnumerator SessionEnum);

	[PreserveSig]
	int RegisterSessionNotification(IntPtr IAudioSessionNotification);

	[PreserveSig]
	int UnregisterSessionNotification(IntPtr IAudioSessionNotification);

	[PreserveSig]
	int RegisterDuckNotification(string sessionID, IntPtr IAudioVolumeDuckNotification);

	[PreserveSig]
	int UnregisterDuckNotification(IntPtr IAudioVolumeDuckNotification);
}
