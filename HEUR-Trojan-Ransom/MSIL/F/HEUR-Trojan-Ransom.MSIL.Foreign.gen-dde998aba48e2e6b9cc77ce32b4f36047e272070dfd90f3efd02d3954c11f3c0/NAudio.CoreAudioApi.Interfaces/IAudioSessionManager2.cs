using System;
using System.Runtime.InteropServices;

namespace NAudio.CoreAudioApi.Interfaces;

[Guid("77AA99A0-1BD6-484F-8BC7-2C654C9A9B6F")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IAudioSessionManager2 : IAudioSessionManager
{
	[PreserveSig]
	new int GetAudioSessionControl([Optional][In][MarshalAs(UnmanagedType.LPStruct)] Guid sessionId, [In][MarshalAs(UnmanagedType.U4)] uint streamFlags, [MarshalAs(UnmanagedType.Interface)] out IAudioSessionControl sessionControl);

	[PreserveSig]
	new int GetSimpleAudioVolume([Optional][In][MarshalAs(UnmanagedType.LPStruct)] Guid sessionId, [In][MarshalAs(UnmanagedType.U4)] uint streamFlags, [MarshalAs(UnmanagedType.Interface)] out ISimpleAudioVolume audioVolume);

	[PreserveSig]
	int GetSessionEnumerator(out IAudioSessionEnumerator sessionEnum);

	[PreserveSig]
	int RegisterSessionNotification(IAudioSessionNotification sessionNotification);

	[PreserveSig]
	int UnregisterSessionNotification(IAudioSessionNotification sessionNotification);

	[PreserveSig]
	int RegisterDuckNotification(string sessionID, IAudioSessionNotification audioVolumeDuckNotification);

	[PreserveSig]
	int UnregisterDuckNotification(IntPtr audioVolumeDuckNotification);
}
