using System;
using System.Runtime.InteropServices;

namespace CoreAudioApi.Interfaces;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("bfb7ff88-7239-4fc9-8fa2-07c950be9c6d")]
internal interface IAudioSessionControl2
{
	[PreserveSig]
	int GetState(out AudioSessionState state);

	[PreserveSig]
	int GetDisplayName(out IntPtr name);

	[PreserveSig]
	int SetDisplayName(string value, Guid EventContext);

	[PreserveSig]
	int GetIconPath(out IntPtr Path);

	[PreserveSig]
	int SetIconPath(string Value, Guid EventContext);

	[PreserveSig]
	int GetGroupingParam(out Guid GroupingParam);

	[PreserveSig]
	int SetGroupingParam(Guid Override, Guid Eventcontext);

	[PreserveSig]
	int RegisterAudioSessionNotification(IAudioSessionEvents NewNotifications);

	[PreserveSig]
	int UnregisterAudioSessionNotification(IAudioSessionEvents NewNotifications);

	[PreserveSig]
	int GetSessionIdentifier(out IntPtr retVal);

	[PreserveSig]
	int GetSessionInstanceIdentifier(out IntPtr retVal);

	[PreserveSig]
	int GetProcessId(out uint retvVal);

	[PreserveSig]
	int IsSystemSoundsSession();

	[PreserveSig]
	int SetDuckingPreference(bool optOut);
}
