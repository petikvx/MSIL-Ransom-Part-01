using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Excel;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[TypeIdentifier]
[Guid("00020849-0000-0000-C000-000000000046")]
[CompilerGenerated]
public interface ChartTitle
{
	[DispId(603)]
	Characters Characters
	{
		[PreserveSig]
		[DispId(603)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_11();
}
