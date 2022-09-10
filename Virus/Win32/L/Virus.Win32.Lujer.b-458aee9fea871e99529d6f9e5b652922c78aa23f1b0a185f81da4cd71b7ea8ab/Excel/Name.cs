using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Excel;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[Guid("000208B9-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[DefaultMember("_Default")]
public interface Name
{
	[DispId(0)]
	string _Default
	{
		[PreserveSig]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(110)]
	string Name
	{
		[PreserveSig]
		[DispId(110)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[PreserveSig]
		[DispId(110)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	void _VtblGap1_3();

	void _VtblGap2_8();
}
