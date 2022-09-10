using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Excel;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
[Guid("0002084D-0000-0000-C000-000000000046")]
public interface Font
{
	[DispId(97)]
	object ColorIndex
	{
		[PreserveSig]
		[DispId(97)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[PreserveSig]
		[DispId(97)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(177)]
	object FontStyle
	{
		[PreserveSig]
		[DispId(177)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[PreserveSig]
		[DispId(177)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(110)]
	object Name
	{
		[PreserveSig]
		[DispId(110)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[PreserveSig]
		[DispId(110)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(104)]
	object Size
	{
		[PreserveSig]
		[DispId(104)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[PreserveSig]
		[DispId(104)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	void _VtblGap1_9();

	void _VtblGap2_2();

	void _VtblGap3_4();
}
