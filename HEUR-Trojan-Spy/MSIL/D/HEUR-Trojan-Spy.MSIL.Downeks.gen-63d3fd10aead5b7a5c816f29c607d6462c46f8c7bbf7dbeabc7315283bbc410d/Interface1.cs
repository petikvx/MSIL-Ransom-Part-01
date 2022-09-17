using System.Runtime.InteropServices;
using System.Security;

[ComImport]
[Guid("C6E13380-30AC-11D0-A18C-00A0C9118956")]
[SuppressUnmanagedCodeSecurity]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface Interface1
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
