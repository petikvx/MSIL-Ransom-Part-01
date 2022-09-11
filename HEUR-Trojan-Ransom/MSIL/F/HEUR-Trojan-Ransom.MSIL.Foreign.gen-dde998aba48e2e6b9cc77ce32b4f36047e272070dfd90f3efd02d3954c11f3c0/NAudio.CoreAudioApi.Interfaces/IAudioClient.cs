using System;
using System.Runtime.InteropServices;
using NAudio.Wave;

namespace NAudio.CoreAudioApi.Interfaces;

[ComImport]
[Guid("1CB9AD4C-DBFA-4c32-B178-C2F568A703B2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IAudioClient
{
	[PreserveSig]
	int Initialize(AudioClientShareMode shareMode, AudioClientStreamFlags streamFlags, long hnsBufferDuration, long hnsPeriodicity, [In] WaveFormat pFormat, [In] ref Guid audioSessionGuid);

	int GetBufferSize(out uint bufferSize);

	[return: MarshalAs(UnmanagedType.I8)]
	long GetStreamLatency();

	int GetCurrentPadding(out int currentPadding);

	[PreserveSig]
	int IsFormatSupported(AudioClientShareMode shareMode, [In] WaveFormat pFormat, IntPtr closestMatchFormat);

	int GetMixFormat(out IntPtr deviceFormatPointer);

	int GetDevicePeriod(out long defaultDevicePeriod, out long minimumDevicePeriod);

	int Start();

	int Stop();

	int Reset();

	int SetEventHandle(IntPtr eventHandle);

	[PreserveSig]
	int GetService([In][MarshalAs(UnmanagedType.LPStruct)] Guid interfaceId, [MarshalAs(UnmanagedType.IUnknown)] out object interfacePointer);
}
