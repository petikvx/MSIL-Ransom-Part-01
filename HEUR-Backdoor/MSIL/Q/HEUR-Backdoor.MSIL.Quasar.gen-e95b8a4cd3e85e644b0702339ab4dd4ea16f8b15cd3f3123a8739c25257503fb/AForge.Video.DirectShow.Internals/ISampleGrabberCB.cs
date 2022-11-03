using System;
using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[ComImport]
[Guid("0579154A-2B53-4994-B0D0-E773148EFF85")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface ISampleGrabberCB
{
	[PreserveSig]
	int SampleCB(double sampleTime, IntPtr sample);

	[PreserveSig]
	int BufferCB(double sampleTime, IntPtr buffer, int bufferLen);
}
