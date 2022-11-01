using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Shell32;

[ComImport]
[DefaultMember("Name")]
[CompilerGenerated]
[TypeIdentifier]
[Guid("FAC32C80-CBE4-11CE-8350-444553540000")]
public interface ZZZZZZZZZZZZe
{
	[DispId(0)]
	string ZZZZZZZZZZZZf
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1610743813)]
	object ZZZZZZZZZZZZg
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743813)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	void _VtblGap1_2();

	void _VtblGap2_1();
}
