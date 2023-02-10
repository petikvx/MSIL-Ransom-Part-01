using System;
using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[ComImport]
[Guid("56a868c0-0ad4-11ce-b03a-0020af0ba770")]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[ComVisible(true)]
internal interface IMediaEventEx
{
	[PreserveSig]
	int GetEventHandle(out IntPtr hEvent);

	[PreserveSig]
	int GetEvent([MarshalAs(UnmanagedType.I4)] out DsEvCode lEventCode, out IntPtr lParam1, out IntPtr lParam2, int msTimeout);

	[PreserveSig]
	int WaitForCompletion(int msTimeout, out int pEvCode);

	[PreserveSig]
	int CancelDefaultHandling(int lEvCode);

	[PreserveSig]
	int RestoreDefaultHandling(int lEvCode);

	[PreserveSig]
	int FreeEventParams([In][MarshalAs(UnmanagedType.I4)] DsEvCode lEvCode, IntPtr lParam1, IntPtr lParam2);

	[PreserveSig]
	int SetNotifyWindow(IntPtr hwnd, int lMsg, IntPtr lInstanceData);

	[PreserveSig]
	int SetNotifyFlags(int lNoNotifyFlags);

	[PreserveSig]
	int GetNotifyFlags(out int lplNoNotifyFlags);
}
