using System.Runtime.InteropServices;
using AForge.Video.DirectShow.Internals;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("C6E13340-30AC-11d0-A18C-00A0C9118956")]
internal interface Interface2
{
	[PreserveSig]
	int SetFormat([In][MarshalAs(UnmanagedType.LPStruct)] AMMediaType mediaType);

	[PreserveSig]
	int GetFormat([MarshalAs(UnmanagedType.LPStruct)] out AMMediaType mediaType);

	[PreserveSig]
	int GetNumberOfCapabilities(out int count, out int size);

	[PreserveSig]
	int GetStreamCaps([In] int index, [MarshalAs(UnmanagedType.LPStruct)] out AMMediaType mediaType, [In][MarshalAs(UnmanagedType.LPStruct)] Class40 streamConfigCaps);
}
