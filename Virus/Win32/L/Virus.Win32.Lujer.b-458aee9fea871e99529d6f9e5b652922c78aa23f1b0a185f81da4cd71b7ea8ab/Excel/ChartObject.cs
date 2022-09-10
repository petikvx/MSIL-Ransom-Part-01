using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Excel;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[TypeIdentifier]
[Guid("000208CF-0000-0000-C000-000000000046")]
[CompilerGenerated]
public interface ChartObject
{
	[DispId(7)]
	Chart Chart
	{
		[PreserveSig]
		[DispId(7)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_39();
}
