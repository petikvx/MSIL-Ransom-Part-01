using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Excel;

[ComImport]
[Guid("00020878-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[CompilerGenerated]
[TypeIdentifier]
public interface Characters
{
	[DispId(138)]
	string Text
	{
		[PreserveSig]
		[DispId(138)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[PreserveSig]
		[DispId(138)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	void _VtblGap1_9();
}
