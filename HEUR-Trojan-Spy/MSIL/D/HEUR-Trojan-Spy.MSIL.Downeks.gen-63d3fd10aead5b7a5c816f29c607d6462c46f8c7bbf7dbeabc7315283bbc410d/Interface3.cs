using System;
using System.Drawing;
using System.Runtime.InteropServices;

[ComImport]
[Guid("6A2E0670-28E4-11D0-A18c-00A0C9118956")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface Interface3
{
	[PreserveSig]
	int GetCaps([In] Interface14 pin, [MarshalAs(UnmanagedType.I4)] out Enum7 flags);

	[PreserveSig]
	int SetMode([In] Interface14 pin, [In][MarshalAs(UnmanagedType.I4)] Enum7 mode);

	[PreserveSig]
	int GetMode([In] Interface14 pin, [MarshalAs(UnmanagedType.I4)] out Enum7 mode);

	[PreserveSig]
	int GetCurrentActualFrameRate([In] Interface14 pin, [MarshalAs(UnmanagedType.I8)] out long actualFrameRate);

	[PreserveSig]
	int GetMaxAvailableFrameRate([In] Interface14 pin, [In] int index, [In] Size dimensions, out long maxAvailableFrameRate);

	[PreserveSig]
	int GetFrameRateList([In] Interface14 pin, [In] int index, [In] Size dimensions, out int listSize, out IntPtr frameRate);
}
