using System;
using System.Runtime.InteropServices;
using AForge.Video.DirectShow.Internals;

[ComImport]
[Guid("56A8689F-0AD4-11CE-B03A-0020AF0BA770")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface Interface9
{
	[PreserveSig]
	int AddFilter([In] Interface4 filter, [In][MarshalAs(UnmanagedType.LPWStr)] string name);

	[PreserveSig]
	int RemoveFilter([In] Interface4 filter);

	[PreserveSig]
	int EnumFilters(out IntPtr enumerator);

	[PreserveSig]
	int FindFilterByName([In][MarshalAs(UnmanagedType.LPWStr)] string name, out Interface4 filter);

	[PreserveSig]
	int ConnectDirect([In] Interface14 pinOut, [In] Interface14 pinIn, [In][MarshalAs(UnmanagedType.LPStruct)] AMMediaType mediaType);

	[PreserveSig]
	int Reconnect([In] Interface14 pin);

	[PreserveSig]
	int Disconnect([In] Interface14 pin);

	[PreserveSig]
	int SetDefaultSyncSource();
}
