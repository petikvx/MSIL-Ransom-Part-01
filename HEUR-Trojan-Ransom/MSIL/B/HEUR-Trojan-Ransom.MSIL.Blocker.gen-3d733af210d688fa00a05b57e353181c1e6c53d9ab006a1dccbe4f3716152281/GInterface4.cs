using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComImport]
[CompilerGenerated]
[DefaultMember("FullName")]
[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
[TypeIdentifier]
public interface GInterface4
{
	[DispId(0)]
	string String_0
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1005)]
	string String_1
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1005)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1005)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1007)]
	string String_2
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1007)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1007)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	void _VtblGap1_9();

	void _VtblGap2_2();

	void _VtblGap3_1();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2001)]
	void imethod_0();
}
