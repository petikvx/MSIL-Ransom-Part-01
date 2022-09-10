using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Excel;

[ComImport]
[TypeIdentifier]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[CompilerGenerated]
[Guid("00020893-0000-0000-C000-000000000046")]
public interface Window
{
	void _VtblGap1_3();

	[PreserveSig]
	[DispId(304)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Activate();

	void _VtblGap2_8();

	[PreserveSig]
	[DispId(277)]
	bool Close([Optional][In][MarshalAs(UnmanagedType.Struct)] object SaveChanges, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Filename, [Optional][In][MarshalAs(UnmanagedType.Struct)] object RouteWorkbook);
}
