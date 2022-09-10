using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Excel;

[ComImport]
[DefaultMember("_Default")]
[TypeIdentifier]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[Guid("0002443A-0000-0000-C000-000000000046")]
[CompilerGenerated]
public interface Shapes : IEnumerable
{
	[DispId(118)]
	int Count
	{
		[PreserveSig]
		[DispId(118)]
		get;
	}

	void _VtblGap1_3();

	void _VtblGap2_1();

	[PreserveSig]
	[DispId(0)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Shape _Default([In][MarshalAs(UnmanagedType.Struct)] object Index);
}
