using System;
using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[ComImport]
[Guid("56A868A9-0AD4-11CE-B03A-0020AF0BA770")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IGraphBuilder
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
}
