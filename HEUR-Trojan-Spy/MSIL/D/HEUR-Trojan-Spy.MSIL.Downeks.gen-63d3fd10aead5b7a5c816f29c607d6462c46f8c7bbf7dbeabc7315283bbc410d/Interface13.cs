using System;
using System.Runtime.InteropServices;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[ComVisible(true)]
[Guid("56a868c0-0ad4-11ce-b03a-0020af0ba770")]
internal interface Interface13
{
	[PreserveSig]
	int GetEventHandle(out IntPtr hEvent);

	[PreserveSig]
	int GetEvent([MarshalAs(UnmanagedType.I4)] out Enum5 lEventCode, out IntPtr lParam1, out IntPtr lParam2, int msTimeout);

	[PreserveSig]
	int WaitForCompletion(int msTimeout, out int pEvCode);

	[PreserveSig]
	int CancelDefaultHandling(int lEvCode);

	[PreserveSig]
	int RestoreDefaultHandling(int lEvCode);

	[PreserveSig]
	int FreeEventParams([In][MarshalAs(UnmanagedType.I4)] Enum5 lEvCode, IntPtr lParam1, IntPtr lParam2);

	[PreserveSig]
	int SetNotifyWindow(IntPtr hwnd, int lMsg, IntPtr lInstanceData);

	[PreserveSig]
	int SetNotifyFlags(int lNoNotifyFlags);

	[PreserveSig]
	int GetNotifyFlags(out int lplNoNotifyFlags);
}
