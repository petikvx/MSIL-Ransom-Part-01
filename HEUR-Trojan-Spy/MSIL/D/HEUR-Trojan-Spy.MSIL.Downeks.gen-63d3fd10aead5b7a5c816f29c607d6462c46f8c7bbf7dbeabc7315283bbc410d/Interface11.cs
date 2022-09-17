using System;
using System.Runtime.InteropServices;
using AForge.Video.DirectShow.Internals;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("56A868A9-0AD4-11CE-B03A-0020AF0BA770")]
internal interface Interface11
{
	[PreserveSig]
	int AddFilter([In] Interface4 filter, [In][MarshalAs(UnmanagedType.LPWStr)] string name);

	[PreserveSig]
	int RemoveFilter([In] Interface4 filter);

	[PreserveSig]
	int EnumFilters(out Interface7 enumerator);

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

	[PreserveSig]
	int Connect([In] Interface14 pinOut, [In] Interface14 pinIn);

	[PreserveSig]
	int Render([In] Interface14 pinOut);

	[PreserveSig]
	int RenderFile([In][MarshalAs(UnmanagedType.LPWStr)] string file, [In][MarshalAs(UnmanagedType.LPWStr)] string playList);

	[PreserveSig]
	int AddSourceFilter([In][MarshalAs(UnmanagedType.LPWStr)] string fileName, [In][MarshalAs(UnmanagedType.LPWStr)] string filterName, out Interface4 filter);

	[PreserveSig]
	int SetLogFile(IntPtr hFile);

	[PreserveSig]
	int Abort();

	[PreserveSig]
	int ShouldOperationContinue();
}