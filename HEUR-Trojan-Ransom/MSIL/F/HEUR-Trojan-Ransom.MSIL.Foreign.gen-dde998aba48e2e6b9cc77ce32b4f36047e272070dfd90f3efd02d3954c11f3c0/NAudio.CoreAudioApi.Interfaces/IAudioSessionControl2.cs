using System;
using System.Runtime.InteropServices;

namespace NAudio.CoreAudioApi.Interfaces;

[Guid("bfb7ff88-7239-4fc9-8fa2-07c950be9c6d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IAudioSessionControl2 : IAudioSessionControl
{
	[PreserveSig]
	new int GetState(out AudioSessionState state);

	[PreserveSig]
	new int GetDisplayName([MarshalAs(UnmanagedType.LPWStr)] out string displayName);

	[PreserveSig]
	new int SetDisplayName([In][MarshalAs(UnmanagedType.LPWStr)] string displayName, [In][MarshalAs(UnmanagedType.LPStruct)] Guid eventContext);

	[PreserveSig]
	new int GetIconPath([MarshalAs(UnmanagedType.LPWStr)] out string iconPath);

	[PreserveSig]
	new int SetIconPath([In][MarshalAs(UnmanagedType.LPWStr)] string iconPath, [In][MarshalAs(UnmanagedType.LPStruct)] Guid eventContext);

	[PreserveSig]
	new int GetGroupingParam(out Guid groupingId);

	[PreserveSig]
	new int SetGroupingParam([In][MarshalAs(UnmanagedType.LPStruct)] Guid groupingId, [In][MarshalAs(UnmanagedType.LPStruct)] Guid eventContext);

	[PreserveSig]
	new int RegisterAudioSessionNotification([In] IAudioSessionEvents client);

	[PreserveSig]
	new int UnregisterAudioSessionNotification([In] IAudioSessionEvents client);

	[PreserveSig]
	int GetSessionIdentifier([MarshalAs(UnmanagedType.LPWStr)] out string retVal);

	[PreserveSig]
	int GetSessionInstanceIdentifier([MarshalAs(UnmanagedType.LPWStr)] out string retVal);

	[PreserveSig]
	int GetProcessId(out uint retVal);

	[PreserveSig]
	int IsSystemSoundsSession();

	[PreserveSig]
	int SetDuckingPreference(bool optOut);
}
