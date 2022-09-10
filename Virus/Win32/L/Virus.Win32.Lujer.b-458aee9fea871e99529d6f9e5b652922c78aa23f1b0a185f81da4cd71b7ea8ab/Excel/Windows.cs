using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Excel;

[ComImport]
[TypeIdentifier]
[Guid("00020892-0000-0000-C000-000000000046")]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
public interface Windows : IEnumerable
{
	[IndexerName("_Default")]
	[DispId(0)]
	Window this[[In][MarshalAs(UnmanagedType.Struct)] object Index]
	{
		[PreserveSig]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_7();
}
