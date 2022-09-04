using System;
using System.Runtime.InteropServices;

namespace CoreAudioApi.Interfaces;

[Guid("24918ACC-64B3-37C1-8CA9-74A66E9957A8")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IAudioSessionEvents
{
	[PreserveSig]
	int OnDisplayNameChanged([MarshalAs(UnmanagedType.LPWStr)] string NewDisplayName, Guid EventContext);

	[PreserveSig]
	int OnIconPathChanged([MarshalAs(UnmanagedType.LPWStr)] string NewIconPath, Guid EventContext);

	[PreserveSig]
	int OnSimpleVolumeChanged(float NewVolume, bool newMute, Guid EventContext);

	[PreserveSig]
	int OnChannelVolumeChanged(uint ChannelCount, IntPtr NewChannelVolumeArray, uint ChangedChannel, Guid EventContext);

	[PreserveSig]
	int OnGroupingParamChanged(Guid NewGroupingParam, Guid EventContext);

	[PreserveSig]
	int OnStateChanged(AudioSessionState NewState);

	[PreserveSig]
	int OnSessionDisconnected(AudioSessionDisconnectReason DisconnectReason);
}
