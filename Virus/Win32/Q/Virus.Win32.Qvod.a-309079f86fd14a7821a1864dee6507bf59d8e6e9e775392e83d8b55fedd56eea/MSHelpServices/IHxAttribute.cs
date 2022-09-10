using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("314111A9-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(4288)]
public interface IHxAttribute
{
	[DispId(69890)]
	string Name
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(69890)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(69891)]
	string Value
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(69891)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(69892)]
	string DisplayName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(69892)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(69893)]
	string DisplayValue
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(69893)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(69888)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object GetProperty([In] HxQueryPropId propid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(69889)]
	void SetProperty([In] HxQueryPropId propid, [In][MarshalAs(UnmanagedType.Struct)] object var);
}
