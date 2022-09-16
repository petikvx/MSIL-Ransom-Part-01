using System;
using System.Runtime.InteropServices;
using AForge.Video.DirectShow.Internals;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("6B652FFF-11FE-4FCE-92AD-0266B5D7C78F")]
internal interface Interface17
{
	[PreserveSig]
	int SetOneShot([In][MarshalAs(UnmanagedType.Bool)] bool oneShot);

	[PreserveSig]
	int SetMediaType([In][MarshalAs(UnmanagedType.LPStruct)] AMMediaType mediaType);

	[PreserveSig]
	int GetConnectedMediaType([Out][MarshalAs(UnmanagedType.LPStruct)] AMMediaType mediaType);

	[PreserveSig]
	int SetBufferSamples([In][MarshalAs(UnmanagedType.Bool)] bool bufferThem);

	[PreserveSig]
	int GetCurrentBuffer(ref int bufferSize, IntPtr buffer);

	[PreserveSig]
	int GetCurrentSample(IntPtr sample);

	[PreserveSig]
	int SetCallback(Interface18 callback, int whichMethodToCallback);
}
