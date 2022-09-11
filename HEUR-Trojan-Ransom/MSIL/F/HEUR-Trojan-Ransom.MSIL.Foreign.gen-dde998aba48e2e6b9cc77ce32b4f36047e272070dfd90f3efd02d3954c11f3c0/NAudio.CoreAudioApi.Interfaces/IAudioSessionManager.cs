using System;
using System.Runtime.InteropServices;

namespace NAudio.CoreAudioApi.Interfaces;

[Guid("BFA971F1-4D5E-40BB-935E-967039BFBEE4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IAudioSessionManager
{
	[PreserveSig]
	int GetAudioSessionControl([Optional][In][MarshalAs(UnmanagedType.LPStruct)] Guid sessionId, [In][MarshalAs(UnmanagedType.U4)] uint streamFlags, [MarshalAs(UnmanagedType.Interface)] out IAudioSessionControl sessionControl);

	[PreserveSig]
	int GetSimpleAudioVolume([Optional][In][MarshalAs(UnmanagedType.LPStruct)] Guid sessionId, [In][MarshalAs(UnmanagedType.U4)] uint streamFlags, [MarshalAs(UnmanagedType.Interface)] out ISimpleAudioVolume audioVolume);
}
