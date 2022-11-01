using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("56A86893-0AD4-11CE-B03A-0020AF0BA770")]
internal interface IEnumFilters
{
	[PreserveSig]
	int Next([In] int cFilters, [Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IBaseFilter[] filters, out int filtersFetched);

	[PreserveSig]
	int Skip([In] int cFilters);

	[PreserveSig]
	int Reset();

	[PreserveSig]
	int Clone(out IEnumFilters enumFilters);
}
