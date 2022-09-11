using System;
using System.Runtime.InteropServices;

namespace NAudio.CoreAudioApi.Interfaces;

[Guid("24918ACC-64B3-37C1-8CA9-74A66E9957A8")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IAudioSessionEvents
{
	[PreserveSig]
	int OnDisplayNameChanged([In][MarshalAs(UnmanagedType.LPWStr)] string displayName, [In] ref Guid eventContext);

	[PreserveSig]
	int OnIconPathChanged([In][MarshalAs(UnmanagedType.LPWStr)] string iconPath, [In] ref Guid eventContext);

	[PreserveSig]
	int OnSimpleVolumeChanged([In][MarshalAs(UnmanagedType.R4)] float volume, [In][MarshalAs(UnmanagedType.Bool)] bool isMuted, [In] ref Guid eventContext);

	[PreserveSig]
	int OnChannelVolumeChanged([In][MarshalAs(UnmanagedType.U4)] uint channelCount, [In][MarshalAs(UnmanagedType.SysInt)] IntPtr newVolumes, [In][MarshalAs(UnmanagedType.U4)] uint channelIndex, [In] ref Guid eventContext);

	[PreserveSig]
	int OnGroupingParamChanged([In] ref Guid groupingId, [In] ref Guid eventContext);

	[PreserveSig]
	int OnStateChanged([In] AudioSessionState state);

	[PreserveSig]
	int OnSessionDisconnected([In] AudioSessionDisconnectReason disconnectReason);
}
