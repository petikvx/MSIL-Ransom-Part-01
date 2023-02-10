using System;
using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[ComImport]
[Guid("56A86891-0AD4-11CE-B03A-0020AF0BA770")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IPin
{
	[PreserveSig]
	int Connect([In] IPin receivePin, [In][MarshalAs(UnmanagedType.LPStruct)] AMMediaType mediaType);

	[PreserveSig]
	int ReceiveConnection([In] IPin receivePin, [In][MarshalAs(UnmanagedType.LPStruct)] AMMediaType mediaType);

	[PreserveSig]
	int Disconnect();

	[PreserveSig]
	int ConnectedTo(out IPin pin);

	[PreserveSig]
	int ConnectionMediaType([Out][MarshalAs(UnmanagedType.LPStruct)] AMMediaType mediaType);

	[PreserveSig]
	int QueryPinInfo(out PinInfo pinInfo);

	[PreserveSig]
	int QueryDirection(out PinDirection pinDirection);

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
