using System.Runtime.InteropServices;
using System.Security;

namespace AForge.Video.DirectShow.Internals;

[ComImport]
[SuppressUnmanagedCodeSecurity]
[Guid("C6E13380-30AC-11D0-A18C-00A0C9118956")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IAMCrossbar
{
	int PinCounts
	{
		[PreserveSig]
		get;
	}

	int IsRoutedTo
	{
		[PreserveSig]
		get;
	}

	int CrossbarPinInfo
	{
		[PreserveSig]
		get;
	}

	[PreserveSig]
	int CanRoute([In] int outputPinIndex, [In] int inputPinIndex);

	[PreserveSig]
	int Route([In] int outputPinIndex, [In] int inputPinIndex);
}
