using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[TypeLibType(4288)]
[Guid("314111A1-A502-11D2-BBCA-00C04F8EC294")]
public interface IHxCollection
{
	[DispId(68354)]
	string URL
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(68354)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(68357)]
	IHxAttrNameList AttributeNames
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(68357)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(68358)]
	IHxFilters Filters
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(68358)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(68359)]
	string Title
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(68359)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(68352)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object GetProperty([In] HxCollectionPropId propid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(68353)]
	void SetProperty([In] HxCollectionPropId propid, [In][MarshalAs(UnmanagedType.Struct)] object var);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(68360)]
	void MergeIndex();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(68361)]
	int GetFilterTopicCount([In][MarshalAs(UnmanagedType.BStr)] string bstrQuery);
}
