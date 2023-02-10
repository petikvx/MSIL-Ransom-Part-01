using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[ComImport]
[Guid("6A2E0670-28E4-11D0-A18c-00A0C9118956")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IAMVideoControl
{
	[PreserveSig]
	int GetCaps([In] IPin pin, [MarshalAs(UnmanagedType.I4)] out VideoControlFlags flags);

	[PreserveSig]
	int SetMode([In] IPin pin, [In][MarshalAs(UnmanagedType.I4)] VideoControlFlags mode);

	[PreserveSig]
	int GetMode([In] IPin pin, [MarshalAs(UnmanagedType.I4)] out VideoControlFlags mode);

	[PreserveSig]
	int GetCurrentActualFrameRate([In] IPin pin, [MarshalAs(UnmanagedType.I8)] out long actualFrameRate);

	[PreserveSig]
	int GetMaxAvailableFrameRate([In] IPin pin, [In] int index, [In] Size dimensions, out long maxAvailableFrameRate);

	[PreserveSig]
	int GetFrameRateList([In] IPin pin, [In] int index, [In] Size dimensions, out int listSize, out IntPtr frameRate);
}
