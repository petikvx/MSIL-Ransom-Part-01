using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[ComImport]
[Guid("56A86892-0AD4-11CE-B03A-0020AF0BA770")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IEnumPins
{
	[PreserveSig]
	int Next([In] int cPins, [Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IPin[] pins, out int pinsFetched);

	[PreserveSig]
	int Skip([In] int cPins);

	[PreserveSig]
	int Reset();

	[PreserveSig]
	int Clone(out IEnumPins enumPins);
}
