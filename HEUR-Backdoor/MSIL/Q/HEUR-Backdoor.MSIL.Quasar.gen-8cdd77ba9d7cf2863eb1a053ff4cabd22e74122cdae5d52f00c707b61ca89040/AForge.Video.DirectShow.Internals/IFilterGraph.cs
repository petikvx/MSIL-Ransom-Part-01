using System;
using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[ComImport]
[Guid("56A8689F-0AD4-11CE-B03A-0020AF0BA770")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IFilterGraph
{
	[PreserveSig]
	int AddFilter([In] IBaseFilter filter, [In][MarshalAs(UnmanagedType.LPWStr)] string name);

	[PreserveSig]
	int RemoveFilter([In] IBaseFilter filter);

	[PreserveSig]
	int EnumFilters(out IntPtr enumerator);

	[PreserveSig]
	int FindFilterByName([In][MarshalAs(UnmanagedType.LPWStr)] string name, out IBaseFilter filter);

	[PreserveSig]
	int ConnectDirect([In] IPin pinOut, [In] IPin pinIn, [In][MarshalAs(UnmanagedType.LPStruct)] AMMediaType mediaType);

	[PreserveSig]
	int Reconnect([In] IPin pin);

	[PreserveSig]
	int Disconnect([In] IPin pin);

	[PreserveSig]
	int SetDefaultSyncSource();
}
