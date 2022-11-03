using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace AForge.Video.DirectShow.Internals;

[ComImport]
[Guid("36B73882-C2C8-11CF-8B46-00805F6CEF60")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IFilterGraph2
{
	[PreserveSig]
	int AddFilter([In] IBaseFilter filter, [In][MarshalAs(UnmanagedType.LPWStr)] string name);

	[PreserveSig]
	int RemoveFilter([In] IBaseFilter filter);

	[PreserveSig]
	int EnumFilters(out IEnumFilters enumerator);

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

	[PreserveSig]
	int Connect([In] IPin pinOut, [In] IPin pinIn);

	[PreserveSig]
	int Render([In] IPin pinOut);

	[PreserveSig]
	int RenderFile([In][MarshalAs(UnmanagedType.LPWStr)] string file, [In][MarshalAs(UnmanagedType.LPWStr)] string playList);

	[PreserveSig]
	int AddSourceFilter([In][MarshalAs(UnmanagedType.LPWStr)] string fileName, [In][MarshalAs(UnmanagedType.LPWStr)] string filterName, out IBaseFilter filter);

	[PreserveSig]
	int SetLogFile(IntPtr hFile);

	[PreserveSig]
	int Abort();

	[PreserveSig]
	int ShouldOperationContinue();

	[PreserveSig]
	int AddSourceFilterForMoniker([In] IMoniker moniker, [In] IBindCtx bindContext, [In][MarshalAs(UnmanagedType.LPWStr)] string filterName, out IBaseFilter filter);

	[PreserveSig]
	int ReconnectEx([In] IPin pin, [In][MarshalAs(UnmanagedType.LPStruct)] AMMediaType mediaType);

	[PreserveSig]
	int RenderEx([In] IPin outputPin, [In] int flags, [In] IntPtr context);
}
