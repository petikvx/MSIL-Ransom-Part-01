using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[ComImport]
[Guid("C6E13340-30AC-11d0-A18C-00A0C9118956")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IAMStreamConfig
{
	[PreserveSig]
	int SetFormat([In][MarshalAs(UnmanagedType.LPStruct)] AMMediaType mediaType);

	[PreserveSig]
	int GetFormat([MarshalAs(UnmanagedType.LPStruct)] out AMMediaType mediaType);

	[PreserveSig]
	int GetNumberOfCapabilities(out int count, out int size);

	[PreserveSig]
	int GetStreamCaps([In] int index, [MarshalAs(UnmanagedType.LPStruct)] out AMMediaType mediaType, [In][MarshalAs(UnmanagedType.LPStruct)] VideoStreamConfigCaps streamConfigCaps);
}
