using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("314111D2-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(4288)]
public interface IHxAttrName
{
	[DispId(70658)]
	string Name
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(70658)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(70659)]
	string DisplayName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(70659)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(70660)]
	int Flag
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(70660)]
		get;
	}

	[DispId(70661)]
	IHxAttrValueList AttributeValues
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(70661)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(70656)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object GetProperty([In] HxQueryPropId propid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(70657)]
	void SetProperty([In] HxQueryPropId propid, [In][MarshalAs(UnmanagedType.Struct)] object var);
}
