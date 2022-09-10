using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("314111D8-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(4288)]
public interface IHxAttrValue
{
	[DispId(71426)]
	string Value
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(71426)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(71427)]
	string DisplayValue
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(71427)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(71428)]
	int Flag
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(71428)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(71424)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object GetProperty([In] HxQueryPropId propid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(71425)]
	void SetProperty([In] HxQueryPropId propid, [In][MarshalAs(UnmanagedType.Struct)] object var);
}
