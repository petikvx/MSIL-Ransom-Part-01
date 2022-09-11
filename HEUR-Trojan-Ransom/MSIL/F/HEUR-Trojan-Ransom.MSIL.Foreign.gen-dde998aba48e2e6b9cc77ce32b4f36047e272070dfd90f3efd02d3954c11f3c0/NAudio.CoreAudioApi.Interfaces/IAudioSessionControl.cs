using System;
using System.Runtime.InteropServices;

namespace NAudio.CoreAudioApi.Interfaces;

[Guid("F4B1A599-7266-4319-A8CA-E70ACB11E8CD")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IAudioSessionControl
{
	[PreserveSig]
	int GetState(out AudioSessionState state);

	[PreserveSig]
	int GetDisplayName([MarshalAs(UnmanagedType.LPWStr)] out string displayName);

	[PreserveSig]
	int SetDisplayName([In][MarshalAs(UnmanagedType.LPWStr)] string displayName, [In][MarshalAs(UnmanagedType.LPStruct)] Guid eventContext);

	[PreserveSig]
	int GetIconPath([MarshalAs(UnmanagedType.LPWStr)] out string iconPath);

	[PreserveSig]
	int SetIconPath([In][MarshalAs(UnmanagedType.LPWStr)] string iconPath, [In][MarshalAs(UnmanagedType.LPStruct)] Guid eventContext);

	[PreserveSig]
	int GetGroupingParam(out Guid groupingId);

	[PreserveSig]
	int SetGroupingParam([In][MarshalAs(UnmanagedType.LPStruct)] Guid groupingId, [In][MarshalAs(UnmanagedType.LPStruct)] Guid eventContext);

	[PreserveSig]
	int RegisterAudioSessionNotification([In] IAudioSessionEvents client);

	[PreserveSig]
	int UnregisterAudioSessionNotification([In] IAudioSessionEvents client);
}
