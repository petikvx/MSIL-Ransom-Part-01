using System;
using System.Runtime.InteropServices;

[ComImport]
[Guid("0579154A-2B53-4994-B0D0-E773148EFF85")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface Interface18
{
	[PreserveSig]
	int SampleCB(double sampleTime, IntPtr sample);

	[PreserveSig]
	int BufferCB(double sampleTime, IntPtr buffer, int bufferLen);
}
