using System.Runtime.InteropServices;
using System.Security;

namespace AForge.Video.DirectShow.Internals;

[ComImport]
[SuppressUnmanagedCodeSecurity]
[Guid("C6E13380-30AC-11D0-A18C-00A0C9118956")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IAMCrossbar
{
	[PreserveSig]
	int get_PinCounts(out int outputPinCount, out int inputPinCount);

	[PreserveSig]
	int CanRoute([In] int outputPinIndex, [In] int inputPinIndex);

	[PreserveSig]
	int Route([In] int outputPinIndex, [In] int inputPinIndex);

	[PreserveSig]
	int get_IsRoutedTo([In] int outputPinIndex, out int inputPinIndex);

	[PreserveSig]
	int get_CrossbarPinInfo([In][MarshalAs(UnmanagedType.Bool)] bool isInputPin, [In] int pinIndex, out int pinIndexRelated, out PhysicalConnectorType physicalType);
}
