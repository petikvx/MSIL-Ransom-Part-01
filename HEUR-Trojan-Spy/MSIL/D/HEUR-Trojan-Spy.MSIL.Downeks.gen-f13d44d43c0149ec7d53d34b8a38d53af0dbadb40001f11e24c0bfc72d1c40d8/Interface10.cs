using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using AForge.Video.DirectShow.Internals;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("36B73882-C2C8-11CF-8B46-00805F6CEF60")]
internal interface Interface10
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

	[PreserveSig]
	int AddSourceFilterForMoniker([In] IMoniker moniker, [In] IBindCtx bindContext, [In][MarshalAs(UnmanagedType.LPWStr)] string filterName, out Interface4 filter);

	[PreserveSig]
	int ReconnectEx([In] Interface14 pin, [In][MarshalAs(UnmanagedType.LPStruct)] AMMediaType mediaType);

	[PreserveSig]
	int RenderEx([In] Interface14 outputPin, [In] int flags, [In] IntPtr context);
}
