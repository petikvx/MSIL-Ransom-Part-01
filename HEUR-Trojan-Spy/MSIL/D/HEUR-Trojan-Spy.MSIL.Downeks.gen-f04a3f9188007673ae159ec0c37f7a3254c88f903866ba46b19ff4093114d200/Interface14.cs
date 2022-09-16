using System;
using System.Runtime.InteropServices;
using AForge.Video.DirectShow.Internals;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("56A86891-0AD4-11CE-B03A-0020AF0BA770")]
internal interface Interface14
{
	[PreserveSig]
	int Connect([In] Interface14 receivePin, [In][MarshalAs(UnmanagedType.LPStruct)] AMMediaType mediaType);

	[PreserveSig]
	int ReceiveConnection([In] Interface14 receivePin, [In][MarshalAs(UnmanagedType.LPStruct)] AMMediaType mediaType);

	[PreserveSig]
	int Disconnect();

	[PreserveSig]
	int ConnectedTo(out Interface14 pin);

	[PreserveSig]
	int ConnectionMediaType([Out][MarshalAs(UnmanagedType.LPStruct)] AMMediaType mediaType);

	[PreserveSig]
	int QueryPinInfo(out Struct13 pinInfo);

	[PreserveSig]
	int QueryDirection(out Enum4 pinDirection);

	[PreserveSig]
	int QueryId([MarshalAs(UnmanagedType.LPWStr)] out string id);

	[PreserveSig]
	int QueryAccept([In][MarshalAs(UnmanagedType.LPStruct)] AMMediaType mediaType);

	[PreserveSig]
	int EnumMediaTypes(IntPtr enumerator);

	[PreserveSig]
	int QueryInternalConnections(IntPtr apPin, [In][Out] ref int nPin);

	[PreserveSig]
	int EndOfStream();

	[PreserveSig]
	int BeginFlush();

	[PreserveSig]
	int EndFlush();

	[PreserveSig]
	int NewSegment(long start, long stop, double rate);
}
